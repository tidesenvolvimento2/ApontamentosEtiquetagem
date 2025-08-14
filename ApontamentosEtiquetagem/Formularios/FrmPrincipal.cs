using ApontamentoEtiquetagem.Dto.Response;
using ApontamentoEtiquetagem.Services;
using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosProducao.Formularios;
using System.Text.RegularExpressions;

namespace ApontamentoEtiquetagem
{
    public partial class FrmPrincipal : Form
    {
        private readonly PecasService _pecasService;
        public PecaResponseDto peca = new PecaResponseDto();
        public List<PecaResponseDto> listPeca = new List<PecaResponseDto>();
        private Queue<string> filaQrCodes = new Queue<string>();
        private int fila;
        private GalpaoResponseDto _galpao;
        private ProducaoEsteiraResponseDto _linha;

        //public readonly EscalaService _escalaService();


        public FrmPrincipal(GalpaoResponseDto galpao, ProducaoEsteiraResponseDto linha)
        {
            InitializeComponent();
            _pecasService = new PecasService();
            _galpao = galpao;
            _linha = linha;
        }

        private void lblDataHora_Click(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FormEtiquetagem_Load(object sender, EventArgs e)
        {
            timerHora.Start();
        }

        private async void txtQrcode_TextChanged(object sender, EventArgs e)
        {
            if (txtQrcode.Text.Length == 21)
            {
                string qrcode = txtQrcode.Text;
                string codigo = qrcode.Substring(6, 9);

                if (!ValidarQrcode(qrcode).Result)
                {
                    Console.WriteLine("QRCODE INVÁLIDO,\n FORMAÇÃO INCORRETA!");
                }

                await CarregarPeca(codigo);

                txtQrcode.Clear();
                txtQrcode.Focus();
            }
        }

        private async Task<bool> ValidarQrcode(string qrcode)
        {
            string padrao = @"^[A-Z0-9]{21}$";

            return Regex.IsMatch(qrcode, padrao);
        }

        private async Task CarregarPeca(string codigo) //tem que pegar somente o código do produto
        {
            try
            {
                peca = await _pecasService.CarregarPecasAsync(codigo);
                txtPeca.Text = peca.Nome;
            }
            catch (Exception ex)
            {
                MostrarErro("CarregarProduto: " + ex.InnerException.Message);
            }
        }

        private bool MostrarErro(string mensagem)
        {
            FrmMensagemErro frmMensagemErro = new FrmMensagemErro(mensagem);
            frmMensagemErro.ShowDialog();

            txtQrcode.Clear();
            txtQrcode.Focus();
            return false;
        }

        private void btnRegistrarParada_Click(object sender, EventArgs e)
        {
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox.AutoSize = false;
        }

        private void lblQtdEtiquetada_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlQuantidadePalete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvApontamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InserirApontamentoNaTabela()
        {

        }

        private void lblQuantidadeGravada_Click(object sender, EventArgs e)
        {

        }

        private void chkDevolucao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboQuantidadeOperadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEscala_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEscala frmEscala = new(_galpao, _linha);
                    frmEscala.ShowDialog();
            }
            catch (Exception ex)
            {
                MostrarErro("Escala: " + ex.InnerException.Message);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
