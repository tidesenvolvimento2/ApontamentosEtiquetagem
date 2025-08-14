namespace ApontamentosProducao.Formularios
{
    partial class FrmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            btnAvancar = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            txtIdentificador = new TextBox();
            lblIdentificador = new Label();
            label1 = new Label();
            label2 = new Label();
            cboLinha = new ComboBox();
            cboGalpao = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAvancar
            // 
            btnAvancar.BackColor = Color.FromArgb(242, 242, 242);
            btnAvancar.FlatAppearance.BorderSize = 2;
            btnAvancar.FlatStyle = FlatStyle.Flat;
            btnAvancar.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancar.ForeColor = SystemColors.MenuText;
            btnAvancar.Location = new Point(169, 409);
            btnAvancar.Margin = new Padding(3, 2, 3, 2);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(232, 46);
            btnAvancar.TabIndex = 10;
            btnAvancar.Text = "CARREGANDO...";
            btnAvancar.UseVisualStyleBackColor = false;
            btnAvancar.Click += btnAvancar_Click;
            btnAvancar.MouseEnter += btnAvancar_MouseEnter;
            btnAvancar.MouseLeave += btnAvancar_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 163);
            label3.Name = "label3";
            label3.Size = new Size(0, 46);
            label3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(3, 2);
            label4.Name = "label4";
            label4.Size = new Size(320, 22);
            label4.TabIndex = 16;
            label4.Text = "APONTAMENTOS ETIQUETAGEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 24);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(528, 2);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(32, 22);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += Acao_clicarNoBotaoDeFechar;
            // 
            // txtIdentificador
            // 
            txtIdentificador.Location = new Point(37, 316);
            txtIdentificador.Multiline = true;
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.Size = new Size(500, 40);
            txtIdentificador.TabIndex = 18;
            txtIdentificador.TextChanged += txtIdentificador_TextChanged;
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.Font = new Font("Corbel", 24F, FontStyle.Bold);
            lblIdentificador.Location = new Point(31, 274);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(500, 39);
            lblIdentificador.TabIndex = 19;
            lblIdentificador.Text = "BIPE O IDENTIFICADOR DA LINHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 24F, FontStyle.Bold);
            label1.Location = new Point(180, 86);
            label1.Name = "label1";
            label1.Size = new Size(109, 39);
            label1.TabIndex = 11;
            label1.Text = "LINHA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 86);
            label2.Name = "label2";
            label2.Size = new Size(139, 39);
            label2.TabIndex = 12;
            label2.Text = "GALPAO";
            label2.Click += label2_Click;
            // 
            // cboLinha
            // 
            cboLinha.BackColor = Color.FromArgb(191, 27, 27);
            cboLinha.DropDownHeight = 250;
            cboLinha.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLinha.FlatStyle = FlatStyle.Flat;
            cboLinha.Font = new Font("Segoe UI", 28.2F);
            cboLinha.ForeColor = SystemColors.Window;
            cboLinha.FormattingEnabled = true;
            cboLinha.IntegralHeight = false;
            cboLinha.Location = new Point(37, 190);
            cboLinha.Margin = new Padding(3, 2, 3, 2);
            cboLinha.Name = "cboLinha";
            cboLinha.Size = new Size(420, 59);
            cboLinha.TabIndex = 6;
            // 
            // cboGalpao
            // 
            cboGalpao.BackColor = Color.FromArgb(191, 27, 27);
            cboGalpao.DropDownHeight = 300;
            cboGalpao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGalpao.FlatStyle = FlatStyle.Popup;
            cboGalpao.Font = new Font("Segoe UI", 28.2F);
            cboGalpao.ForeColor = SystemColors.Window;
            cboGalpao.FormattingEnabled = true;
            cboGalpao.ImeMode = ImeMode.NoControl;
            cboGalpao.IntegralHeight = false;
            cboGalpao.Location = new Point(37, 127);
            cboGalpao.Margin = new Padding(3, 2, 3, 2);
            cboGalpao.Name = "cboGalpao";
            cboGalpao.Size = new Size(420, 59);
            cboGalpao.TabIndex = 8;
            cboGalpao.SelectedIndexChanged += cboGalpao_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(569, 466);
            Controls.Add(lblIdentificador);
            Controls.Add(txtIdentificador);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAvancar);
            Controls.Add(cboGalpao);
            Controls.Add(cboLinha);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APONTAMENTO PRODUCAO - REV 271124 - DB | Equipe: Desenvolvimento";
            Load += FrmTelaInicial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvancar;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button1;
        private TextBox txtIdentificador;
        private Label lblIdentificador;
        private Label label1;
        private Label label2;
        private ComboBox cboLinha;
        private ComboBox cboGalpao;
        private PictureBox pictureBox1;
    }
}