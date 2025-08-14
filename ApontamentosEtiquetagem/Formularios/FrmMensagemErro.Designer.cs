namespace ApontamentosProducao.Formularios
{
    partial class FrmMensagemErro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            btnClose = new Button();
            lblAtencao = new Label();
            lblMensagem = new Label();
            TEMPO = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 500);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(lblAtencao);
            panel2.Controls.Add(lblMensagem);
            panel2.Location = new Point(25, 20);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 450);
            panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(394, 375);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(172, 47);
            btnClose.TabIndex = 2;
            btnClose.Text = "FECHAR";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblAtencao
            // 
            lblAtencao.AutoSize = true;
            lblAtencao.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtencao.ForeColor = SystemColors.ControlLightLight;
            lblAtencao.Location = new Point(350, 13);
            lblAtencao.Name = "lblAtencao";
            lblAtencao.Size = new Size(237, 65);
            lblAtencao.TabIndex = 0;
            lblAtencao.Text = "ATENÇÃO";
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.None;
            lblMensagem.AutoEllipsis = true;
            lblMensagem.AutoSize = true;
            lblMensagem.FlatStyle = FlatStyle.Flat;
            lblMensagem.Font = new Font("Segoe UI", 30F);
            lblMensagem.ForeColor = SystemColors.ControlLightLight;
            lblMensagem.Location = new Point(109, 166);
            lblMensagem.MaximumSize = new Size(900, 0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 54);
            lblMensagem.TabIndex = 1;
            // 
            // TEMPO
            // 
            TEMPO.Interval = 4000;
            TEMPO.Tick += TEMPO_Tick;
            // 
            // FrmMensagemErro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1000, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMensagemErro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmMensagemErro";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMensagem;
        private Label lblAtencao;
        private Panel panel2;
        private Button btnClose;
        private System.Windows.Forms.Timer TEMPO;
    }
}