namespace ApontamentoEtiquetagem
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlCabecalho = new Panel();
            btnFechar = new Button();
            btnEscala = new Button();
            btnRegistrarParada = new Button();
            chkDevolucao = new CheckBox();
            lblDataHora = new Label();
            label1 = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            txtQuantidadeGravada = new TextBox();
            pnlQuantidadeOP = new Panel();
            txtQuantidadeOP = new TextBox();
            lblQuantidadeOP = new Label();
            pnlQrcode = new Panel();
            txtQrcode = new TextBox();
            lblQrcode = new Label();
            pnlQuantidadePalete = new Panel();
            textBox2 = new TextBox();
            lblQuantidadePalete = new Label();
            pnlPeca = new Panel();
            txtPeca = new TextBox();
            lblPeca = new Label();
            pnlQuantidadeOperadores = new Panel();
            cboQuantidadeOperadores = new ComboBox();
            lblQuantidadeOperadores = new Label();
            pnlQuantidadeGravada = new Panel();
            lblQuantidadeGravada = new Label();
            dgvApontamentos = new DataGridView();
            OP = new DataGridViewTextBoxColumn();
            QuantidadeOP = new DataGridViewTextBoxColumn();
            CodigoPeca = new DataGridViewTextBoxColumn();
            DescricaoPeca = new DataGridViewTextBoxColumn();
            QuantidadePalete = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            QuantidadeOperadores = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            cboOP = new ComboBox();
            pnlCabecalho.SuspendLayout();
            pnlQuantidadeOP.SuspendLayout();
            pnlQrcode.SuspendLayout();
            pnlQuantidadePalete.SuspendLayout();
            pnlPeca.SuspendLayout();
            pnlQuantidadeOperadores.SuspendLayout();
            pnlQuantidadeGravada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApontamentos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.DarkRed;
            pnlCabecalho.Controls.Add(btnFechar);
            pnlCabecalho.Controls.Add(btnEscala);
            pnlCabecalho.Controls.Add(btnRegistrarParada);
            pnlCabecalho.Controls.Add(chkDevolucao);
            pnlCabecalho.Controls.Add(lblDataHora);
            pnlCabecalho.Controls.Add(label1);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(4, 3, 4, 3);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1425, 100);
            pnlCabecalho.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.Transparent;
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(1362, 9);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(32, 22);
            btnFechar.TabIndex = 21;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // btnEscala
            // 
            btnEscala.BackColor = Color.White;
            btnEscala.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            btnEscala.ForeColor = Color.Black;
            btnEscala.Location = new Point(1280, 43);
            btnEscala.Margin = new Padding(4, 3, 4, 3);
            btnEscala.Name = "btnEscala";
            btnEscala.Size = new Size(114, 46);
            btnEscala.TabIndex = 7;
            btnEscala.Text = "ESCALA";
            btnEscala.UseVisualStyleBackColor = false;
            btnEscala.Click += btnEscala_Click;
            // 
            // btnRegistrarParada
            // 
            btnRegistrarParada.BackColor = Color.White;
            btnRegistrarParada.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            btnRegistrarParada.ForeColor = Color.Black;
            btnRegistrarParada.Location = new Point(1040, 43);
            btnRegistrarParada.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarParada.Name = "btnRegistrarParada";
            btnRegistrarParada.Size = new Size(233, 46);
            btnRegistrarParada.TabIndex = 3;
            btnRegistrarParada.Text = "REGISTRAR PARADA";
            btnRegistrarParada.UseVisualStyleBackColor = false;
            btnRegistrarParada.Click += btnRegistrarParada_Click;
            // 
            // chkDevolucao
            // 
            chkDevolucao.AutoSize = true;
            chkDevolucao.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            chkDevolucao.ForeColor = Color.White;
            chkDevolucao.Location = new Point(772, 57);
            chkDevolucao.Margin = new Padding(4, 3, 4, 3);
            chkDevolucao.Name = "chkDevolucao";
            chkDevolucao.Size = new Size(246, 21);
            chkDevolucao.TabIndex = 2;
            chkDevolucao.Text = "APONTAR PEÇA PARA DEVOLUÇÃO";
            chkDevolucao.UseVisualStyleBackColor = true;
            chkDevolucao.CheckedChanged += chkDevolucao_CheckedChanged;
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataHora.ForeColor = Color.White;
            lblDataHora.Location = new Point(26, 59);
            lblDataHora.Margin = new Padding(4, 0, 4, 0);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(90, 21);
            lblDataHora.TabIndex = 1;
            lblDataHora.Text = "Data/Hora";
            lblDataHora.Click += lblDataHora_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(412, 32);
            label1.TabIndex = 0;
            label1.Text = "APONTAMENTO DA ETIQUETAGEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // timerHora
            // 
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // txtQuantidadeGravada
            // 
            txtQuantidadeGravada.Anchor = AnchorStyles.None;
            txtQuantidadeGravada.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            txtQuantidadeGravada.ForeColor = SystemColors.WindowFrame;
            txtQuantidadeGravada.Location = new Point(30, 278);
            txtQuantidadeGravada.Margin = new Padding(4, 3, 4, 3);
            txtQuantidadeGravada.Multiline = true;
            txtQuantidadeGravada.Name = "txtQuantidadeGravada";
            txtQuantidadeGravada.RightToLeft = RightToLeft.No;
            txtQuantidadeGravada.Size = new Size(274, 46);
            txtQuantidadeGravada.TabIndex = 64;
            txtQuantidadeGravada.Text = "0";
            txtQuantidadeGravada.TextAlign = HorizontalAlignment.Center;
            txtQuantidadeGravada.TextChanged += textBox1_TextChanged;
            // 
            // pnlQuantidadeOP
            // 
            pnlQuantidadeOP.BackColor = Color.DarkRed;
            pnlQuantidadeOP.Controls.Add(txtQuantidadeOP);
            pnlQuantidadeOP.Controls.Add(lblQuantidadeOP);
            pnlQuantidadeOP.Location = new Point(323, 233);
            pnlQuantidadeOP.Margin = new Padding(4, 3, 4, 3);
            pnlQuantidadeOP.Name = "pnlQuantidadeOP";
            pnlQuantidadeOP.Size = new Size(344, 91);
            pnlQuantidadeOP.TabIndex = 69;
            pnlQuantidadeOP.Paint += panel2_Paint;
            // 
            // txtQuantidadeOP
            // 
            txtQuantidadeOP.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtQuantidadeOP.Location = new Point(0, 44);
            txtQuantidadeOP.Margin = new Padding(4, 3, 4, 3);
            txtQuantidadeOP.Multiline = true;
            txtQuantidadeOP.Name = "txtQuantidadeOP";
            txtQuantidadeOP.Size = new Size(344, 47);
            txtQuantidadeOP.TabIndex = 75;
            // 
            // lblQuantidadeOP
            // 
            lblQuantidadeOP.AutoSize = true;
            lblQuantidadeOP.BackColor = Color.DarkRed;
            lblQuantidadeOP.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            lblQuantidadeOP.ForeColor = Color.White;
            lblQuantidadeOP.Location = new Point(4, 8);
            lblQuantidadeOP.Margin = new Padding(4, 0, 4, 0);
            lblQuantidadeOP.Name = "lblQuantidadeOP";
            lblQuantidadeOP.Size = new Size(271, 31);
            lblQuantidadeOP.TabIndex = 65;
            lblQuantidadeOP.Text = "QUANTIDADE DA OP";
            lblQuantidadeOP.Click += label4_Click;
            // 
            // pnlQrcode
            // 
            pnlQrcode.BackColor = Color.DarkRed;
            pnlQrcode.Controls.Add(txtQrcode);
            pnlQrcode.Controls.Add(lblQrcode);
            pnlQrcode.Location = new Point(29, 129);
            pnlQrcode.Margin = new Padding(4, 3, 4, 3);
            pnlQrcode.Name = "pnlQrcode";
            pnlQrcode.Size = new Size(274, 91);
            pnlQrcode.TabIndex = 70;
            // 
            // txtQrcode
            // 
            txtQrcode.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtQrcode.Location = new Point(0, 44);
            txtQrcode.Margin = new Padding(4, 3, 4, 3);
            txtQrcode.Multiline = true;
            txtQrcode.Name = "txtQrcode";
            txtQrcode.Size = new Size(274, 47);
            txtQrcode.TabIndex = 74;
            txtQrcode.TextChanged += txtQrcode_TextChanged;
            // 
            // lblQrcode
            // 
            lblQrcode.AutoSize = true;
            lblQrcode.BackColor = Color.DarkRed;
            lblQrcode.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            lblQrcode.ForeColor = Color.White;
            lblQrcode.Location = new Point(4, 6);
            lblQrcode.Margin = new Padding(4, 0, 4, 0);
            lblQrcode.Name = "lblQrcode";
            lblQrcode.Size = new Size(120, 31);
            lblQrcode.TabIndex = 65;
            lblQrcode.Text = "QRCODE";
            // 
            // pnlQuantidadePalete
            // 
            pnlQuantidadePalete.BackColor = Color.DarkRed;
            pnlQuantidadePalete.Controls.Add(textBox2);
            pnlQuantidadePalete.Controls.Add(lblQuantidadePalete);
            pnlQuantidadePalete.Location = new Point(686, 129);
            pnlQuantidadePalete.Margin = new Padding(4, 3, 4, 3);
            pnlQuantidadePalete.Name = "pnlQuantidadePalete";
            pnlQuantidadePalete.Size = new Size(344, 91);
            pnlQuantidadePalete.TabIndex = 71;
            pnlQuantidadePalete.Paint += pnlQuantidadePalete_Paint;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(0, 44);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 47);
            textBox2.TabIndex = 76;
            // 
            // lblQuantidadePalete
            // 
            lblQuantidadePalete.AutoSize = true;
            lblQuantidadePalete.BackColor = Color.DarkRed;
            lblQuantidadePalete.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            lblQuantidadePalete.ForeColor = Color.White;
            lblQuantidadePalete.Location = new Point(4, 7);
            lblQuantidadePalete.Margin = new Padding(4, 0, 4, 0);
            lblQuantidadePalete.Name = "lblQuantidadePalete";
            lblQuantidadePalete.Size = new Size(281, 31);
            lblQuantidadePalete.TabIndex = 75;
            lblQuantidadePalete.Text = "QUANTIDADE PALETE";
            lblQuantidadePalete.Click += label3_Click_1;
            // 
            // pnlPeca
            // 
            pnlPeca.BackColor = Color.DarkRed;
            pnlPeca.Controls.Add(txtPeca);
            pnlPeca.Controls.Add(lblPeca);
            pnlPeca.Location = new Point(686, 234);
            pnlPeca.Margin = new Padding(4, 3, 4, 3);
            pnlPeca.Name = "pnlPeca";
            pnlPeca.Size = new Size(708, 91);
            pnlPeca.TabIndex = 72;
            // 
            // txtPeca
            // 
            txtPeca.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPeca.Location = new Point(0, 44);
            txtPeca.Margin = new Padding(4, 3, 4, 3);
            txtPeca.Multiline = true;
            txtPeca.Name = "txtPeca";
            txtPeca.ReadOnly = true;
            txtPeca.Size = new Size(708, 47);
            txtPeca.TabIndex = 75;
            txtPeca.TextChanged += txtDescricao_TextChanged;
            // 
            // lblPeca
            // 
            lblPeca.AutoSize = true;
            lblPeca.BackColor = Color.DarkRed;
            lblPeca.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            lblPeca.ForeColor = Color.White;
            lblPeca.Location = new Point(4, 7);
            lblPeca.Margin = new Padding(4, 0, 4, 0);
            lblPeca.Name = "lblPeca";
            lblPeca.Size = new Size(156, 31);
            lblPeca.TabIndex = 71;
            lblPeca.Text = "DESCRIÇÃO";
            lblPeca.Click += label2_Click;
            // 
            // pnlQuantidadeOperadores
            // 
            pnlQuantidadeOperadores.BackColor = Color.DarkRed;
            pnlQuantidadeOperadores.Controls.Add(cboQuantidadeOperadores);
            pnlQuantidadeOperadores.Controls.Add(lblQuantidadeOperadores);
            pnlQuantidadeOperadores.Location = new Point(1050, 129);
            pnlQuantidadeOperadores.Margin = new Padding(4, 3, 4, 3);
            pnlQuantidadeOperadores.Name = "pnlQuantidadeOperadores";
            pnlQuantidadeOperadores.Size = new Size(344, 91);
            pnlQuantidadeOperadores.TabIndex = 73;
            // 
            // cboQuantidadeOperadores
            // 
            cboQuantidadeOperadores.BackColor = SystemColors.Window;
            cboQuantidadeOperadores.DropDownHeight = 250;
            cboQuantidadeOperadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuantidadeOperadores.DropDownWidth = 210;
            cboQuantidadeOperadores.Font = new Font("Microsoft Sans Serif", 24F);
            cboQuantidadeOperadores.FormattingEnabled = true;
            cboQuantidadeOperadores.IntegralHeight = false;
            cboQuantidadeOperadores.ItemHeight = 37;
            cboQuantidadeOperadores.Location = new Point(0, 46);
            cboQuantidadeOperadores.Margin = new Padding(4, 3, 4, 3);
            cboQuantidadeOperadores.MaxDropDownItems = 6;
            cboQuantidadeOperadores.Name = "cboQuantidadeOperadores";
            cboQuantidadeOperadores.Size = new Size(344, 45);
            cboQuantidadeOperadores.TabIndex = 74;
            cboQuantidadeOperadores.SelectedIndexChanged += cboQuantidadeOperadores_SelectedIndexChanged;
            // 
            // lblQuantidadeOperadores
            // 
            lblQuantidadeOperadores.AutoSize = true;
            lblQuantidadeOperadores.BackColor = Color.DarkRed;
            lblQuantidadeOperadores.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            lblQuantidadeOperadores.ForeColor = Color.White;
            lblQuantidadeOperadores.Location = new Point(4, 8);
            lblQuantidadeOperadores.Margin = new Padding(4, 0, 4, 0);
            lblQuantidadeOperadores.Name = "lblQuantidadeOperadores";
            lblQuantidadeOperadores.Size = new Size(183, 31);
            lblQuantidadeOperadores.TabIndex = 73;
            lblQuantidadeOperadores.Text = "OPERADORES";
            // 
            // pnlQuantidadeGravada
            // 
            pnlQuantidadeGravada.BackColor = Color.DarkRed;
            pnlQuantidadeGravada.Controls.Add(lblQuantidadeGravada);
            pnlQuantidadeGravada.Location = new Point(29, 233);
            pnlQuantidadeGravada.Margin = new Padding(4, 3, 4, 3);
            pnlQuantidadeGravada.Name = "pnlQuantidadeGravada";
            pnlQuantidadeGravada.Size = new Size(274, 71);
            pnlQuantidadeGravada.TabIndex = 66;
            // 
            // lblQuantidadeGravada
            // 
            lblQuantidadeGravada.AutoSize = true;
            lblQuantidadeGravada.BackColor = Color.DarkRed;
            lblQuantidadeGravada.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            lblQuantidadeGravada.ForeColor = Color.White;
            lblQuantidadeGravada.Location = new Point(4, 8);
            lblQuantidadeGravada.Margin = new Padding(4, 0, 4, 0);
            lblQuantidadeGravada.Name = "lblQuantidadeGravada";
            lblQuantidadeGravada.Size = new Size(184, 31);
            lblQuantidadeGravada.TabIndex = 65;
            lblQuantidadeGravada.Text = "QUANTIDADE";
            lblQuantidadeGravada.Click += lblQuantidadeGravada_Click;
            // 
            // dgvApontamentos
            // 
            dgvApontamentos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvApontamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvApontamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvApontamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApontamentos.BackgroundColor = Color.White;
            dgvApontamentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApontamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApontamentos.Columns.AddRange(new DataGridViewColumn[] { OP, QuantidadeOP, CodigoPeca, DescricaoPeca, QuantidadePalete, Data, QuantidadeOperadores, Situacao });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvApontamentos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvApontamentos.EnableHeadersVisualStyles = false;
            dgvApontamentos.GridColor = Color.Silver;
            dgvApontamentos.Location = new Point(29, 345);
            dgvApontamentos.Margin = new Padding(4, 3, 4, 3);
            dgvApontamentos.Name = "dgvApontamentos";
            dgvApontamentos.ReadOnly = true;
            dgvApontamentos.RowHeadersVisible = false;
            dgvApontamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApontamentos.Size = new Size(1368, 487);
            dgvApontamentos.StandardTab = true;
            dgvApontamentos.TabIndex = 66;
            dgvApontamentos.CellContentClick += dgvApontamentos_CellContentClick;
            // 
            // OP
            // 
            OP.HeaderText = "OP";
            OP.Name = "OP";
            OP.ReadOnly = true;
            // 
            // QuantidadeOP
            // 
            QuantidadeOP.HeaderText = "QUANTIDADE DA OP";
            QuantidadeOP.Name = "QuantidadeOP";
            QuantidadeOP.ReadOnly = true;
            // 
            // CodigoPeca
            // 
            CodigoPeca.HeaderText = "CÓDIGO DA PEÇA";
            CodigoPeca.Name = "CodigoPeca";
            CodigoPeca.ReadOnly = true;
            // 
            // DescricaoPeca
            // 
            DescricaoPeca.FillWeight = 200F;
            DescricaoPeca.HeaderText = "DESCRIÇÃO";
            DescricaoPeca.Name = "DescricaoPeca";
            DescricaoPeca.ReadOnly = true;
            // 
            // QuantidadePalete
            // 
            QuantidadePalete.FillWeight = 120F;
            QuantidadePalete.HeaderText = "QUANTIDADE DE PALETE";
            QuantidadePalete.Name = "QuantidadePalete";
            QuantidadePalete.ReadOnly = true;
            // 
            // Data
            // 
            Data.HeaderText = "DATA";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // QuantidadeOperadores
            // 
            QuantidadeOperadores.HeaderText = "QUANTIDADE DE OPERADORES";
            QuantidadeOperadores.Name = "QuantidadeOperadores";
            QuantidadeOperadores.ReadOnly = true;
            // 
            // Situacao
            // 
            Situacao.HeaderText = "SITUAÇÃO";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkRed;
            label2.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 31);
            label2.TabIndex = 65;
            label2.Text = "OP";
            label2.Click += label2_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(cboOP);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(323, 129);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 91);
            panel1.TabIndex = 74;
            // 
            // cboOP
            // 
            cboOP.BackColor = SystemColors.Window;
            cboOP.DropDownHeight = 250;
            cboOP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOP.DropDownWidth = 210;
            cboOP.Font = new Font("Microsoft Sans Serif", 24F);
            cboOP.FormattingEnabled = true;
            cboOP.IntegralHeight = false;
            cboOP.ItemHeight = 37;
            cboOP.Location = new Point(0, 46);
            cboOP.Margin = new Padding(4, 3, 4, 3);
            cboOP.MaxDropDownItems = 6;
            cboOP.Name = "cboOP";
            cboOP.Size = new Size(344, 45);
            cboOP.TabIndex = 75;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1425, 849);
            Controls.Add(panel1);
            Controls.Add(dgvApontamentos);
            Controls.Add(txtQuantidadeGravada);
            Controls.Add(pnlQuantidadeOperadores);
            Controls.Add(pnlPeca);
            Controls.Add(pnlQuantidadePalete);
            Controls.Add(pnlQrcode);
            Controls.Add(pnlQuantidadeOP);
            Controls.Add(pnlQuantidadeGravada);
            Controls.Add(pnlCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apontamento da Etiquetagem";
            Load += FormEtiquetagem_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlQuantidadeOP.ResumeLayout(false);
            pnlQuantidadeOP.PerformLayout();
            pnlQrcode.ResumeLayout(false);
            pnlQrcode.PerformLayout();
            pnlQuantidadePalete.ResumeLayout(false);
            pnlQuantidadePalete.PerformLayout();
            pnlPeca.ResumeLayout(false);
            pnlPeca.PerformLayout();
            pnlQuantidadeOperadores.ResumeLayout(false);
            pnlQuantidadeOperadores.PerformLayout();
            pnlQuantidadeGravada.ResumeLayout(false);
            pnlQuantidadeGravada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApontamentos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnRegistrarParada;
        private System.Windows.Forms.CheckBox chkDevolucao;
        private System.Windows.Forms.TextBox txtQuantidadeGravada;
        private System.Windows.Forms.Panel pnlQuantidadeOP;
        private System.Windows.Forms.Label lblQuantidadeOP;
        private System.Windows.Forms.Panel pnlQrcode;
        private System.Windows.Forms.Label lblQrcode;
        private System.Windows.Forms.Panel pnlQuantidadePalete;
        private System.Windows.Forms.Panel pnlPeca;
        private System.Windows.Forms.Panel pnlQuantidadeOperadores;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.Label lblQuantidadePalete;
        private System.Windows.Forms.ComboBox cboQuantidadeOperadores;
        private System.Windows.Forms.Label lblQuantidadeOperadores;
        private System.Windows.Forms.Panel pnlQuantidadeGravada;
        private System.Windows.Forms.Label lblQuantidadeGravada;
        private System.Windows.Forms.DataGridView dgvApontamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadePalete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeOperadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.TextBox txtQrcode;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.Button btnEscala;
        private Label label2;
        private Panel panel1;
        private TextBox txtQuantidadeOP;
        private TextBox textBox2;
        private Button btnFechar;
        private ComboBox cboOP;
    }
}

