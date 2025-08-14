using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosEtiquetagem.Dto.Response.Colaboradores;
using ApontamentosEtiquetagem.Dto.Response.Escala;
using ApontamentosEtiquetagem.Services;

namespace ApontamentosProducao.Formularios;

public partial class FrmEscala : Form
{
    private readonly GalpaoResponseDto _galpao;
    private readonly ProducaoEsteiraResponseDto _linha;

    private List<ColaboradoresResponse> listaColaboradores = new();
    private readonly ColaboradorService _colaboradorService;
    private readonly EscalaService _escalaService;

    public FrmEscala(GalpaoResponseDto galpao, ProducaoEsteiraResponseDto linha)
    {
        InitializeComponent();

        _galpao = galpao;
        _linha  = linha;

        ConfigurarGrid();
        dgvStatus.CurrentCellDirtyStateChanged += (s, e) =>
        {
            if(dgvStatus.IsCurrentCellDirty)
                dgvStatus.CommitEdit(DataGridViewDataErrorContexts.Commit);
        };

        _escalaService      = new EscalaService();
        _colaboradorService = new ColaboradorService();

        lblNomeLinha.Text = _linha.Nome;

        CarregarColaboradores();
        CarregarStatusAsync(_linha.EsteiraId);
        ContarQuantidadeColaboradores();
    }

    private bool MostrarErro(string mensagem)
    {
        FrmMensagemErro frmMensagemErro = new(mensagem);
        frmMensagemErro.ShowDialog();

        return false;
    }

    private async void CarregarColaboradores()
    {
        try
        {
            listaColaboradores = await _colaboradorService.CarregarColaboradoresAsync();
            cbxColaboradores.DataSource   = listaColaboradores;
            cbxColaboradores.DisplayMember = nameof(ColaboradoresResponse.Nome);
            cbxColaboradores.ValueMember   = nameof(ColaboradoresResponse.IdColaborador);
        }
        catch(Exception ex)
        {
            MessageBox.Show(
                $"Carregar Colaboradores: {ex.Message}",
                "Erro Inesperado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private async void RegistrarEntrada()
    {
        if(cbxColaboradores.SelectedValue is int idColaborador)
        {
            try
            {
                var resultado = await _escalaService.RegistrarEntradaAsync(_linha.EsteiraId, idColaborador, 3);

                MessageBox.Show(
                    "Entrada registrada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                await CarregarStatusAsync(_linha.EsteiraId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    $"Falha ao registrar entrada: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        else
        {
            MessageBox.Show(
                "Selecione um colaborador antes de registrar a entrada.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }

    private async void RegistrarSaida()
    {
        if(cbxColaboradores.SelectedValue is int idColaborador)
        {
            try
            {
                var resultado = await _escalaService.RegistrarSaidaAsync(_linha.EsteiraId, idColaborador);

                MessageBox.Show(
                    "Saída registrada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                await CarregarStatusAsync(_linha.EsteiraId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    $"Falha ao registrar saída: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        else
        {
            MessageBox.Show(
                "Selecione um colaborador antes de registrar a saída.",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }

    private async Task CarregarStatusAsync(int idLinha)
    {
        try
        {
            var lista = await _escalaService.CarregarEscalaStatus(idLinha);
            dgvStatus.DataSource = lista;
        }
        catch(Exception ex)
        {
            MessageBox.Show(
                $"Erro ao carregar status: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void ConfigurarGrid()
    {
        dgvStatus.AutoGenerateColumns   = false;
        dgvStatus.Columns.Clear();
        dgvStatus.RowHeadersVisible     = false;
        dgvStatus.AllowUserToAddRows     = false;
        dgvStatus.AllowUserToDeleteRows  = false;
        dgvStatus.ReadOnly              = false;
        dgvStatus.EditMode = DataGridViewEditMode.EditOnEnter;

        // Coluna de texto: Nome
        dgvStatus.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name             = "Colaborador",
            DataPropertyName = nameof(ColaboradoresStatusResponse.Nome),
            HeaderText       = "Colaborador",
            AutoSizeMode     = DataGridViewAutoSizeColumnMode.Fill,
            ReadOnly         = true
        });

        // Coluna de checkbox: EstaNaLinha
        dgvStatus.Columns.Add(new DataGridViewCheckBoxColumn
        {
            Name             = "EstaNaLinha",
            DataPropertyName = nameof(ColaboradoresStatusResponse.EstaNaLinha),
            HeaderText       = "Na Linha",
            Width            = 60,
            TrueValue        = true,
            FalseValue       = false,
            ReadOnly         = false
        });
    }

    private void dgvStatus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        // só queremos tratar a coluna cujo Name foi definido como "Status"
        if(dgvStatus.Columns[ e.ColumnIndex ].Name != "Status")
            return;

        // Extrai o objeto da linha, usando o DTO correto
        if(dgvStatus.Rows[ e.RowIndex ].DataBoundItem is ColaboradoresStatusResponse item)
        {
            var img = item.EstaNaLinha
                ? ApontamentosEtiquetagem.Properties.Resources.GreenCircle
                : ApontamentosEtiquetagem.Properties.Resources.RedCircle;

            e.Value = img;
            e.FormattingApplied = true;
        }
    }

    private void BtnRegistrarEntrada_Click(object sender, EventArgs e)
        => RegistrarEntrada();

    private void button1_Click(object sender, EventArgs e)
    {
        CarregarStatusAsync(_linha.EsteiraId);
        ContarQuantidadeColaboradores();
    }

    private async void dgvStatus_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if(dgvStatus.Columns[ e.ColumnIndex ].Name != "EstaNaLinha")
            return;

        if(dgvStatus.Rows[ e.RowIndex ].DataBoundItem is ColaboradoresStatusResponse item)
        {
            bool novaPresenca = (bool)dgvStatus.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].Value;

            if(!novaPresenca)
            {
                var confirm = MessageBox.Show(
                    $"Deseja realmente RETIRAR o colaborador '{item.Nome}' da linha?",
                    "Confirmar SAÍDA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if(confirm == DialogResult.Yes)
                {
                    await _escalaService.RegistrarSaidaAsync(_linha.EsteiraId, item.IdColaborador);
                    await CarregarStatusAsync(_linha.EsteiraId);
                }
                else
                {
                    dgvStatus.CellValueChanged -= dgvStatus_CellValueChanged;
                    dgvStatus.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].Value = true;
                    dgvStatus.CellValueChanged += dgvStatus_CellValueChanged;
                    await CarregarStatusAsync(_linha.EsteiraId);
                }
            }

            if(novaPresenca)
            {
                var confirm = MessageBox.Show(
                    $"Deseja realmente REGISTRAR entrada do colaborador '{item.Nome}' da linha?",
                    "Confirmar ENTRADA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if(confirm == DialogResult.Yes)
                {
                    await _escalaService.RegistrarEntradaAsync(_linha.EsteiraId, item.IdColaborador, 3);
                    await CarregarStatusAsync(_linha.EsteiraId);
                }
                else
                {
                    dgvStatus.CellValueChanged -= dgvStatus_CellValueChanged;
                    dgvStatus.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].Value = true;
                    dgvStatus.CellValueChanged += dgvStatus_CellValueChanged;
                    await CarregarStatusAsync(_linha.EsteiraId);
                }
            }
        }
    }

    private async void ContarQuantidadeColaboradores()
    {
        try
        {
            var quantidade = await _escalaService.ContarColaboradoresAtivosNaLinha(_linha.EsteiraId, 3);
            lblQuantidadeNaLinha.Text = quantidade.ToString();
        }
        catch(Exception ex)
        {
            MostrarErro("ContarQuantidadeColaboradores: " + ex.InnerException?.Message ?? ex.Message);
        }
    }
}