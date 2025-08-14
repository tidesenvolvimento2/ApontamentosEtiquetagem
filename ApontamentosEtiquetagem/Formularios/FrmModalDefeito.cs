using ApontamentosEtiquetagem.Dto.Request;
using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosEtiquetagem.Dto.Response.Apontamentos;
using ApontamentosEtiquetagem.Services;
using ApontamentosEtiquetagem.Utils;

namespace ApontamentosProducao.Formularios
{
    public partial class FrmModalDefeito : Form
    {
        private readonly DefeitoService _defeitoService;
        public readonly ApontamentosService _apontamentosService;
        private List<DefeitoResponseDto> listaDefeitos = new();
        public ProducaoEsteiraResponseDto _linha;
        public GalpaoResponseDto _galpao;
        //public OrdemProducaoDto _Op;
        private readonly int _quantidadeColaboradores;
        private List<ApontamentosDefeitoResponse> _ultimosApontamentosDefeito = new();
        private OrdemProducaoDto _Op;

        public FrmModalDefeito(GalpaoResponseDto galpao, ProducaoEsteiraResponseDto linha, int quantidadeColaboradores, OrdemProducaoDto Op)
        {
            InitializeComponent();

            this._linha = linha;
            _galpao = galpao;
            //_Op = Op;
            _quantidadeColaboradores = quantidadeColaboradores;

            _defeitoService = new DefeitoService();
            _apontamentosService = new ApontamentosService();

            CarregarDefeitos();
            CarregarUltimosApontamentosDefeito(linha, galpao);
        }

        private async void FrmModalDefeito_Load(object sender, EventArgs e)
        {
            await CarregarDefeitos();
        }

        private async Task CarregarDefeitos()
        {
            try
            {
                listaDefeitos = await _defeitoService.CarregarDefeitosAsync();

                cboDefeito.DataSource = listaDefeitos;
                cboDefeito.DisplayMember = "Descricao";
            }

            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao carregar defeitos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CarregarUltimosApontamentosDefeito(ProducaoEsteiraResponseDto linha, GalpaoResponseDto galpao)
        {
            try
            {
                DateTime dataAtual = DateTime.Now;
                _ultimosApontamentosDefeito = await _apontamentosService.InicializarUltimosApontamentosDefeitoAsync(linha.EsteiraId);
                ConfigurarTabela(_ultimosApontamentosDefeito);
            }
            catch(Exception ex)
            {
                MostrarErro($"Erro CarregarUltimosApontamentosDefeito: {ex.InnerException.Message}");
            }
        }

        private void ConfigurarTabela(List<ApontamentosDefeitoResponse> lista)
        {
            dgvDefeitos.AutoGenerateColumns = false;
            dgvDefeitos.DataSource = lista;

            dgvDefeitos.Columns.Add(new DataGridViewTextBoxColumn

            {
                Name = "QrCode",
                HeaderText = "QrCode",
                DataPropertyName = nameof(ApontamentosDefeitoResponse.QrCode),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Coluna Codigo
            dgvDefeitos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = nameof(ApontamentosDefeitoResponse.Codigo),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Coluna DataProducao (string vindo da API -> formatar)
            dgvDefeitos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DataProducao",
                HeaderText = "Data Produção",
                DataPropertyName = nameof(ApontamentosDefeitoResponse.DataProducao),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Coluna Linha
            dgvDefeitos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Linha",
                HeaderText = "Linha",
                DataPropertyName = nameof(ApontamentosDefeitoResponse.Linha),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Coluna Op
            dgvDefeitos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Op",
                HeaderText = "OP",
                DataPropertyName = nameof(ApontamentosDefeitoResponse.Op),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Coluna Defeito
            dgvDefeitos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Defeito",
                HeaderText = "Defeito",
                DataPropertyName = nameof(ApontamentosDefeitoResponse.Defeito),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void btnFecharModalDefeito_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDefeitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void txtBipe_TextChanged(object sender, EventArgs e)
        {
            if(txtBipe.Text.Length == 26)
            {
                string qrcode = txtBipe.Text;

                //if(!ValidacoesApontamentos.ValidarOp(_Op, qrcode).Result)
                //{
                //    MostrarErro("PRODUTO NÃO PERTENCE\n A OP SELECIONADA");
                //    return;
                //}
                if(!ValidacoesApontamentos.ValidarQrcode(qrcode).Result)
                {
                    MostrarErro("QRCODE INVÁLIDO,\n FORMATAÇÃO INCORRETA!");
                    return;
                }
                if(!ValidacoesApontamentos.ValidarGalpao(qrcode, _galpao).Result)
                {
                    MostrarErro("QRCODE NÃO PERTENCE\n AO GALPAO");
                    return;
                }

                var apontamento = GerarEntidadeApontamentoDefeito(qrcode, DateTime.Now, _Op, _quantidadeColaboradores);
                await RegistrarApontamentoDefeito(apontamento);

                txtBipe.Clear();
                txtBipe.Focus();
            }
        }

        private ApontamentoDefeitoPostDto GerarEntidadeApontamentoDefeito(string qrCode, DateTime dataAtual, OrdemProducaoDto op, int quantidadeColaboradores)
        {
            var codigo = qrCode.Substring(10, 9);
            var sequencial = Convert.ToInt32(qrCode.Substring(qrCode.Length - 6));

            var response = new ApontamentoDefeitoPostDto
            {
                QrCode = qrCode,
                Apont_Ano = dataAtual.Year,
                Apont_Mes = dataAtual.Month,
                Apont_Dia = dataAtual.Day,
                Apont_Hora = dataAtual.Hour,
                Apont_Min = dataAtual.Minute,
                DataProducao = dataAtual.ToString("yyyy-MM-dd HH:mm:ss"),
                Codigo = qrCode.Substring(10, 9),
                QtdOperadores = quantidadeColaboradores,
                QtdOp = op.Quantidade,
                Op = op.NumeroOp,
                GalpaoId = _galpao.GalpaoId,
                Linha = _linha.EsteiraId,
                Sequencial = Convert.ToInt32(qrCode.Substring(qrCode.Length - 6)),
                IdMotivoDefeito = ((DefeitoResponseDto)cboDefeito.SelectedItem).IdDefeito
            };

            return response;
        }

        private async Task<ApontamentoDto> RegistrarApontamentoDefeito(ApontamentoDefeitoPostDto apontamento)
        {
            try
            {
                var registro = await _apontamentosService.RegistrarApontamentoDefeitoAsync(apontamento);

                return GerarApontamentoDto(registro);
            }
            catch(Exception ex)
            {
                MostrarErro(ex.InnerException.Message);
                //MostrarErro("RegistrarApontamento: " + ex.InnerException.Message);
                return null;
            }
        }

        public static ApontamentoDto GerarApontamentoDto(ApontamentoDto apontamentoRegistrado)
        {
            return new ApontamentoDto
            {
                QrCode = apontamentoRegistrado.QrCode,
                Codigo = apontamentoRegistrado.Codigo,
                DataProducao = apontamentoRegistrado.DataProducao,
                Linha = apontamentoRegistrado.Linha,
                Op = apontamentoRegistrado.Op,
                QtdOperadores = apontamentoRegistrado.QtdOperadores
            };
        }

        private bool MostrarErro(string mensagem)
        {
            FrmMensagemErro frmMensagemErro = new(mensagem);
            frmMensagemErro.ShowDialog();

            txtBipe.Clear();
            txtBipe.Focus();
            return false;
        }
    }
}