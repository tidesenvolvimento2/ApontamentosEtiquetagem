namespace ApontamentosProducao.Formularios
{
    partial class FrmEscala
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
            if(disposing && (components != null))
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
            BtnRegistrarEntrada = new Button();
            cbxColaboradores = new ComboBox();
            label1 = new Label();
            dgvStatus = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            lblNomeLinha = new Label();
            label3 = new Label();
            lblQuantidadeNaLinha = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStatus).BeginInit();
            SuspendLayout();
            // 
            // BtnRegistrarEntrada
            // 
            BtnRegistrarEntrada.FlatAppearance.BorderColor = Color.Red;
            BtnRegistrarEntrada.FlatAppearance.BorderSize = 2;
            BtnRegistrarEntrada.FlatAppearance.MouseDownBackColor = Color.Maroon;
            BtnRegistrarEntrada.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            BtnRegistrarEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnRegistrarEntrada.Location = new Point(308, 46);
            BtnRegistrarEntrada.Name = "BtnRegistrarEntrada";
            BtnRegistrarEntrada.Size = new Size(212, 38);
            BtnRegistrarEntrada.TabIndex = 1;
            BtnRegistrarEntrada.Text = "REGISTRAR 1ª ENTRADA";
            BtnRegistrarEntrada.UseVisualStyleBackColor = true;
            BtnRegistrarEntrada.Click += BtnRegistrarEntrada_Click;
            // 
            // cbxColaboradores
            // 
            cbxColaboradores.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxColaboradores.FormattingEnabled = true;
            cbxColaboradores.Location = new Point(12, 45);
            cbxColaboradores.Name = "cbxColaboradores";
            cbxColaboradores.Size = new Size(279, 38);
            cbxColaboradores.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 4;
            label1.Text = "Colaborador";
            // 
            // dgvStatus
            // 
            dgvStatus.AllowUserToAddRows = false;
            dgvStatus.AllowUserToDeleteRows = false;
            dgvStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatus.Location = new Point(12, 109);
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            dgvStatus.RowHeadersVisible = false;
            dgvStatus.Size = new Size(935, 500);
            dgvStatus.TabIndex = 5;
            dgvStatus.CellFormatting += dgvStatus_CellFormatting;
            dgvStatus.CellValueChanged += dgvStatus_CellValueChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(308, 9);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 6;
            button1.Text = "RECARREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(526, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 7;
            label2.Text = "Linha:";
            // 
            // lblNomeLinha
            // 
            lblNomeLinha.AutoSize = true;
            lblNomeLinha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeLinha.ForeColor = SystemColors.ButtonFace;
            lblNomeLinha.Location = new Point(605, 9);
            lblNomeLinha.Name = "lblNomeLinha";
            lblNomeLinha.Size = new Size(31, 30);
            lblNomeLinha.TabIndex = 8;
            lblNomeLinha.Text = ",,,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(526, 53);
            label3.Name = "label3";
            label3.Size = new Size(219, 30);
            label3.TabIndex = 9;
            label3.Text = "Quantidade na linha:";
            // 
            // lblQuantidadeNaLinha
            // 
            lblQuantidadeNaLinha.AutoSize = true;
            lblQuantidadeNaLinha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeNaLinha.ForeColor = SystemColors.ButtonFace;
            lblQuantidadeNaLinha.Location = new Point(751, 53);
            lblQuantidadeNaLinha.Name = "lblQuantidadeNaLinha";
            lblQuantidadeNaLinha.Size = new Size(31, 30);
            lblQuantidadeNaLinha.TabIndex = 10;
            lblQuantidadeNaLinha.Text = ",,,";
            // 
            // FrmEscala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(959, 621);
            Controls.Add(lblQuantidadeNaLinha);
            Controls.Add(label3);
            Controls.Add(lblNomeLinha);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dgvStatus);
            Controls.Add(label1);
            Controls.Add(cbxColaboradores);
            Controls.Add(BtnRegistrarEntrada);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmEscala";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEscala";
            ((System.ComponentModel.ISupportInitialize)dgvStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnRegistrarEntrada;
        private ComboBox cbxColaboradores;
        private Label label1;
        private DataGridView dgvStatus;
        private Button button1;
        private Label label2;
        private Label lblNomeLinha;
        private Label label3;
        private Label lblQuantidadeNaLinha;
    }
}