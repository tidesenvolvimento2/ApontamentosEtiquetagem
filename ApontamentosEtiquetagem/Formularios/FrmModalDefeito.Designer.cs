
namespace ApontamentosProducao.Formularios
{
    partial class FrmModalDefeito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModalDefeito));
            cboDefeito = new ComboBox();
            lblDefeito = new Label();
            txtBipe = new TextBox();
            lblCodigo = new Label();
            btnFecharModalDefeito = new Button();
            dgvDefeitos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDefeitos).BeginInit();
            SuspendLayout();
            // 
            // cboDefeito
            // 
            cboDefeito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDefeito.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDefeito.FormattingEnabled = true;
            cboDefeito.Location = new Point(75, 81);
            cboDefeito.Name = "cboDefeito";
            cboDefeito.Size = new Size(1138, 40);
            cboDefeito.TabIndex = 0;
            // 
            // lblDefeito
            // 
            lblDefeito.AutoSize = true;
            lblDefeito.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDefeito.ForeColor = Color.White;
            lblDefeito.Location = new Point(75, 53);
            lblDefeito.Name = "lblDefeito";
            lblDefeito.Size = new Size(210, 25);
            lblDefeito.TabIndex = 1;
            lblDefeito.Text = "SELECIONE O DEFEITO ";
            // 
            // txtBipe
            // 
            txtBipe.Font = new Font("Segoe UI", 18F);
            txtBipe.Location = new Point(75, 175);
            txtBipe.MaxLength = 26;
            txtBipe.Name = "txtBipe";
            txtBipe.Size = new Size(1138, 39);
            txtBipe.TabIndex = 2;
            txtBipe.TextChanged += txtBipe_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(75, 147);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(93, 25);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "QR CODE";
            // 
            // btnFecharModalDefeito
            // 
            btnFecharModalDefeito.FlatAppearance.BorderSize = 0;
            btnFecharModalDefeito.FlatStyle = FlatStyle.Flat;
            btnFecharModalDefeito.ForeColor = Color.Transparent;
            btnFecharModalDefeito.Image = (Image)resources.GetObject("btnFecharModalDefeito.Image");
            btnFecharModalDefeito.Location = new Point(1180, 7);
            btnFecharModalDefeito.Margin = new Padding(0);
            btnFecharModalDefeito.Name = "btnFecharModalDefeito";
            btnFecharModalDefeito.Size = new Size(32, 22);
            btnFecharModalDefeito.TabIndex = 20;
            btnFecharModalDefeito.UseVisualStyleBackColor = true;
            btnFecharModalDefeito.Click += btnFecharModalDefeito_Click;
            // 
            // dgvDefeitos
            // 
            dgvDefeitos.AllowUserToAddRows = false;
            dgvDefeitos.AllowUserToDeleteRows = false;
            dgvDefeitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDefeitos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDefeitos.BackgroundColor = SystemColors.ButtonFace;
            dgvDefeitos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvDefeitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDefeitos.Location = new Point(75, 245);
            dgvDefeitos.MultiSelect = false;
            dgvDefeitos.Name = "dgvDefeitos";
            dgvDefeitos.ReadOnly = true;
            dgvDefeitos.RowHeadersVisible = false;
            dgvDefeitos.RowHeadersWidth = 51;
            dgvDefeitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDefeitos.Size = new Size(1138, 454);
            dgvDefeitos.TabIndex = 21;
            dgvDefeitos.CellContentClick += dgvDefeitos_CellContentClick;
            // 
            // FrmModalDefeito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1387, 711);
            Controls.Add(dgvDefeitos);
            Controls.Add(btnFecharModalDefeito);
            Controls.Add(lblCodigo);
            Controls.Add(txtBipe);
            Controls.Add(lblDefeito);
            Controls.Add(cboDefeito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModalDefeito";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmModalDefeito";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvDefeitos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private ComboBox cboDefeito;
        private Label lblDefeito;
        private TextBox txtBipe;
        private Label lblCodigo;
        private Button btnFecharModalDefeito;
        private DataGridView dgvDefeitos;
    }
}