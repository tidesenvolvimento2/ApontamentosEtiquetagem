namespace ApontamentosProducao.Formularios
{
    public partial class FrmMensagemErro : Form
    {
        public FrmMensagemErro(string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;

            TEMPO.Interval = 5000;  // Intervalo de 1000 ms (1 segundo)
            TEMPO.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TEMPO_Tick(object sender, EventArgs e)
        {
            TEMPO.Stop();
            this.Close();
        }
    }
}