namespace PagueBem
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCad_Pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbData_a_Inicio = new System.Windows.Forms.DateTimePicker();
            this.lbldePagamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSelCliente = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Tabelas = new PagueBem.DataSet_Tabelas();
            this.txbData_a_Pagar = new System.Windows.Forms.DateTimePicker();
            this.btnCad_Debito = new System.Windows.Forms.Button();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paguebembdDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Pessoa = new PagueBem.DataSet_Pessoa();
            this.dataSetPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new PagueBem.DataSet_TabelasTableAdapters.pessoaTableAdapter();
            this.dataTable1TableAdapter = new PagueBem.DataSet_TabelasTableAdapters.DataTable1TableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeInicioVencimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeFinalVencimento = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFinalCadastro = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatusPesquisa = new System.Windows.Forms.ComboBox();
            this.CbPesqueisaCliente = new System.Windows.Forms.ComboBox();
            this.txbPesquisaCliente = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimeInicialCadastro = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Tabelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paguebembdDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Pessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoaBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCad_Pesquisar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbData_a_Inicio);
            this.panel1.Controls.Add(this.lbldePagamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.lblSelCliente);
            this.panel1.Controls.Add(this.txbStatus);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.txbData_a_Pagar);
            this.panel1.Controls.Add(this.btnCad_Debito);
            this.panel1.Controls.Add(this.txbValor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 175);
            this.panel1.TabIndex = 0;
            // 
            // btnCad_Pesquisar
            // 
            this.btnCad_Pesquisar.Location = new System.Drawing.Point(425, 128);
            this.btnCad_Pesquisar.Name = "btnCad_Pesquisar";
            this.btnCad_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnCad_Pesquisar.TabIndex = 15;
            this.btnCad_Pesquisar.Text = "Pesquisar";
            this.btnCad_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data inicio";
            // 
            // txbData_a_Inicio
            // 
            this.txbData_a_Inicio.Location = new System.Drawing.Point(3, 80);
            this.txbData_a_Inicio.Name = "txbData_a_Inicio";
            this.txbData_a_Inicio.Size = new System.Drawing.Size(200, 20);
            this.txbData_a_Inicio.TabIndex = 13;
            // 
            // lbldePagamento
            // 
            this.lbldePagamento.AutoSize = true;
            this.lbldePagamento.Location = new System.Drawing.Point(221, 65);
            this.lbldePagamento.Name = "lbldePagamento";
            this.lbldePagamento.Size = new System.Drawing.Size(104, 13);
            this.lbldePagamento.TabIndex = 11;
            this.lbldePagamento.Text = "Data de Vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(219, 14);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            // 
            // lblSelCliente
            // 
            this.lblSelCliente.AutoSize = true;
            this.lblSelCliente.Location = new System.Drawing.Point(3, 14);
            this.lblSelCliente.Name = "lblSelCliente";
            this.lblSelCliente.Size = new System.Drawing.Size(108, 13);
            this.lblSelCliente.TabIndex = 7;
            this.lblSelCliente.Text = "Selecione seu cliente";
            // 
            // txbStatus
            // 
            this.txbStatus.FormattingEnabled = true;
            this.txbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.txbStatus.Location = new System.Drawing.Point(310, 29);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(107, 21);
            this.txbStatus.TabIndex = 8;
            // 
            // cbCliente
            // 
            this.cbCliente.DataSource = this.pessoaBindingSource;
            this.cbCliente.DisplayMember = "Nome";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(3, 29);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(202, 21);
            this.cbCliente.TabIndex = 7;
            this.cbCliente.ValueMember = "ID";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.dataSet_Tabelas;
            // 
            // dataSet_Tabelas
            // 
            this.dataSet_Tabelas.DataSetName = "DataSet_Tabelas";
            this.dataSet_Tabelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbData_a_Pagar
            // 
            this.txbData_a_Pagar.Location = new System.Drawing.Point(219, 80);
            this.txbData_a_Pagar.Name = "txbData_a_Pagar";
            this.txbData_a_Pagar.Size = new System.Drawing.Size(200, 20);
            this.txbData_a_Pagar.TabIndex = 6;
            // 
            // btnCad_Debito
            // 
            this.btnCad_Debito.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCad_Debito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCad_Debito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad_Debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad_Debito.ForeColor = System.Drawing.Color.Black;
            this.btnCad_Debito.Location = new System.Drawing.Point(425, 29);
            this.btnCad_Debito.Name = "btnCad_Debito";
            this.btnCad_Debito.Size = new System.Drawing.Size(75, 71);
            this.btnCad_Debito.TabIndex = 5;
            this.btnCad_Debito.Text = "Cadastrar Debido";
            this.btnCad_Debito.UseVisualStyleBackColor = false;
            this.btnCad_Debito.Click += new System.EventHandler(this.btnCad_Debito_Click);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(217, 29);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(90, 20);
            this.txbValor.TabIndex = 3;
            this.txbValor.TextChanged += new System.EventHandler(this.txbValor_TextChanged);
            this.txbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValor_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PagueBem.Properties.Resources.businessmen;
            this.pictureBox1.Location = new System.Drawing.Point(523, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(32, 36);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(32, 75);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 1;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(32, 112);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(136, 75);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Incluir cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTelefone);
            this.panel2.Controls.Add(this.lblCPF);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.txbTelefone);
            this.panel2.Controls.Add(this.txbCPF);
            this.panel2.Controls.Add(this.txbNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 174);
            this.panel2.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(31, 97);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(31, 60);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(970, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idconta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cpf";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataVenda";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data da Venda";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataVencimento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de Vencimento";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet_Tabelas;
            // 
            // dataSet_Pessoa
            // 
            this.dataSet_Pessoa.DataSetName = "DataSet_Pessoa";
            this.dataSet_Pessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetPessoaBindingSource
            // 
            this.dataSetPessoaBindingSource.DataSource = this.dataSet_Pessoa;
            this.dataSetPessoaBindingSource.Position = 0;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maskedTextBox4);
            this.panel3.Controls.Add(this.maskedTextBox3);
            this.panel3.Controls.Add(this.maskedTextBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, -97);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9585, 4343);
            this.panel3.TabIndex = 3;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(4758, 2177);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 8;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(4750, 2169);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 7;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(4742, 2161);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 6;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btnPesquisa);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cbStatusPesquisa);
            this.panel4.Controls.Add(this.CbPesqueisaCliente);
            this.panel4.Controls.Add(this.txbPesquisaCliente);
            this.panel4.Location = new System.Drawing.Point(12, 610);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 205);
            this.panel4.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Data do vencimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Data do Cadatro da Conta ";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.dateTimeInicioVencimento);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.dateTimeFinalVencimento);
            this.panel7.Location = new System.Drawing.Point(13, 136);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 52);
            this.panel7.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data inicio";
            // 
            // dateTimeInicioVencimento
            // 
            this.dateTimeInicioVencimento.Location = new System.Drawing.Point(3, 18);
            this.dateTimeInicioVencimento.Name = "dateTimeInicioVencimento";
            this.dateTimeInicioVencimento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeInicioVencimento.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Data Final";
            // 
            // dateTimeFinalVencimento
            // 
            this.dateTimeFinalVencimento.Location = new System.Drawing.Point(219, 18);
            this.dateTimeFinalVencimento.Name = "dateTimeFinalVencimento";
            this.dateTimeFinalVencimento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFinalVencimento.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dateTimeInicialCadastro);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.dateTimeFinalCadastro);
            this.panel6.Location = new System.Drawing.Point(13, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 52);
            this.panel6.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Data inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Data Final";
            // 
            // dateTimeFinalCadastro
            // 
            this.dateTimeFinalCadastro.Location = new System.Drawing.Point(219, 18);
            this.dateTimeFinalCadastro.Name = "dateTimeFinalCadastro";
            this.dateTimeFinalCadastro.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFinalCadastro.TabIndex = 27;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(534, 57);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 27;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Selecione seu cliente";
            // 
            // cbStatusPesquisa
            // 
            this.cbStatusPesquisa.FormattingEnabled = true;
            this.cbStatusPesquisa.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cbStatusPesquisa.Location = new System.Drawing.Point(320, 21);
            this.cbStatusPesquisa.Name = "cbStatusPesquisa";
            this.cbStatusPesquisa.Size = new System.Drawing.Size(107, 21);
            this.cbStatusPesquisa.TabIndex = 21;
            // 
            // CbPesqueisaCliente
            // 
            this.CbPesqueisaCliente.DataSource = this.pessoaBindingSource;
            this.CbPesqueisaCliente.DisplayMember = "Nome";
            this.CbPesqueisaCliente.FormattingEnabled = true;
            this.CbPesqueisaCliente.Location = new System.Drawing.Point(13, 21);
            this.CbPesqueisaCliente.Name = "CbPesqueisaCliente";
            this.CbPesqueisaCliente.Size = new System.Drawing.Size(202, 21);
            this.CbPesqueisaCliente.TabIndex = 20;
            this.CbPesqueisaCliente.ValueMember = "ID";
            // 
            // txbPesquisaCliente
            // 
            this.txbPesquisaCliente.Location = new System.Drawing.Point(227, 21);
            this.txbPesquisaCliente.Name = "txbPesquisaCliente";
            this.txbPesquisaCliente.Size = new System.Drawing.Size(90, 20);
            this.txbPesquisaCliente.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(2, 98);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(968, 174);
            this.panel5.TabIndex = 3;
            // 
            // dateTimeInicialCadastro
            // 
            this.dateTimeInicialCadastro.Location = new System.Drawing.Point(6, 19);
            this.dateTimeInicialCadastro.Name = "dateTimeInicialCadastro";
            this.dateTimeInicialCadastro.Size = new System.Drawing.Size(200, 20);
            this.dateTimeInicialCadastro.TabIndex = 31;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 729);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Pague Bem";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Tabelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paguebembdDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Pessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoaBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.DateTimePicker txbData_a_Pagar;
        private System.Windows.Forms.Button btnCad_Debito;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox txbStatus;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbldePagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSelCliente;
        private System.Windows.Forms.BindingSource paguebembdDataSet1BindingSource;
        private DataSet_Pessoa dataSet_Pessoa;
        private System.Windows.Forms.BindingSource dataSetPessoaBindingSource;
        private DataSet_Tabelas dataSet_Tabelas;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSet_TabelasTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet_TabelasTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCad_Pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txbData_a_Inicio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatusPesquisa;
        private System.Windows.Forms.ComboBox CbPesqueisaCliente;
        private System.Windows.Forms.TextBox txbPesquisaCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimeFinalVencimento;
        private System.Windows.Forms.DateTimePicker dateTimeInicioVencimento;
        private System.Windows.Forms.DateTimePicker dateTimeFinalCadastro;
        private System.Windows.Forms.DateTimePicker dateTimeInicialCadastro;
    }
}