using ApontamentoEtiquetagem;
using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosEtiquetagem.Services;
using ApontamentosProducao.Services;

namespace ApontamentosProducao.Formularios
{
    public partial class FrmTelaInicial : Form
    {
        private readonly GalpaoService _galpaoService;
        private readonly LinhaService _linhaService;
        private List<GalpaoResponseDto> listaGalpoes = new();
        private List<ProducaoEsteiraResponseDto> listaLinha = new();

        public FrmTelaInicial()
        {
            InitializeComponent();
            _galpaoService = new GalpaoService();
            _linhaService = new LinhaService();
            CarregarGalpoes();
        }

        private async void btnAvancar_Click(object sender, EventArgs e)
        {
            var galpao = cboGalpao.SelectedValue as GalpaoResponseDto;
            var linha = cboLinha.SelectedValue as ProducaoEsteiraResponseDto;

            if (galpao is not null && linha is not null)
            {
                FrmPrincipal frmPrincipal = new(galpao, linha);
                this.Visible = false;
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione o Galpão e Linha!");
            }
        }

        private async void CarregarGalpoes()
        {
            try
            {
                listaGalpoes = await _galpaoService.CarregarGalpoesAsync();
                listaGalpoes.Insert(0, new GalpaoResponseDto
                {
                    GalpaoId = 0,
                    Nome = "Selecione um Galpão"
                });
                cboGalpao.DataSource = listaGalpoes;
                cboGalpao.DisplayMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro galpões: {ex.Message}", "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CarregarLinhas()
        {
            if (cboGalpao.SelectedIndex != 0)
            {
                var idGalpao = cboGalpao.SelectedValue as GalpaoResponseDto;
                try
                {
                    listaLinha = await _linhaService.CarregarLinhaAsync(idGalpao.GalpaoId);
                    cboLinha.DataSource = listaLinha;
                    cboLinha.DisplayMember = "Nome";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro linhas: {ex.Message}", "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Acao_clicarNoBotaoDeFechar(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {
        }

        private void btnAvancar_MouseLeave(object sender, EventArgs e)
        {
            btnAvancar.BackColor = Color.FromArgb(242, 242, 242);
            btnAvancar.FlatAppearance.BorderSize = 2;
            btnAvancar.ForeColor = SystemColors.MenuText;
        }

        private void btnAvancar_MouseEnter(object sender, EventArgs e)
        {
            btnAvancar.BackColor = Color.FromArgb(191, 27, 27);
            btnAvancar.FlatAppearance.BorderSize = 0;
            btnAvancar.ForeColor = Color.FromArgb(242, 242, 242);
        }

        private void cboGalpao_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarLinhas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void label4_Click(object sender, EventArgs e)
        //{
        //}
    }
}