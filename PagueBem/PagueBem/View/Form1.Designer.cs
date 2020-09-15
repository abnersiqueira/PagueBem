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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(309, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 131);
            this.panel1.TabIndex = 0;
            // 
            // lbldePagamento
            // 
            this.lbldePagamento.AutoSize = true;
            this.lbldePagamento.Location = new System.Drawing.Point(171, 67);
            this.lbldePagamento.Name = "lbldePagamento";
            this.lbldePagamento.Size = new System.Drawing.Size(102, 13);
            this.lbldePagamento.TabIndex = 11;
            this.lbldePagamento.Text = "Data de Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(171, 18);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            // 
            // lblSelCliente
            // 
            this.lblSelCliente.AutoSize = true;
            this.lblSelCliente.Location = new System.Drawing.Point(3, 18);
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
            this.txbStatus.Location = new System.Drawing.Point(262, 33);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(107, 21);
            this.txbStatus.TabIndex = 8;
            // 
            // cbCliente
            // 
            this.cbCliente.DataSource = this.pessoaBindingSource;
            this.cbCliente.DisplayMember = "Nome";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(3, 33);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(157, 21);
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
            this.txbData_a_Pagar.Location = new System.Drawing.Point(169, 82);
            this.txbData_a_Pagar.Name = "txbData_a_Pagar";
            this.txbData_a_Pagar.Size = new System.Drawing.Size(200, 20);
            this.txbData_a_Pagar.TabIndex = 6;
            // 
            // btnCad_Debito
            // 
            this.btnCad_Debito.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCad_Debito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad_Debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad_Debito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCad_Debito.Location = new System.Drawing.Point(387, 33);
            this.btnCad_Debito.Name = "btnCad_Debito";
            this.btnCad_Debito.Size = new System.Drawing.Size(75, 71);
            this.btnCad_Debito.TabIndex = 5;
            this.btnCad_Debito.Text = "Cadastrar Debido";
            this.btnCad_Debito.UseVisualStyleBackColor = false;
            this.btnCad_Debito.Click += new System.EventHandler(this.btnCad_Debito_Click);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(169, 33);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(90, 20);
            this.txbValor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PagueBem.Properties.Resources.businessmen;
            this.pictureBox1.Location = new System.Drawing.Point(449, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(21, 21);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(21, 59);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 1;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(21, 95);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(139, 53);
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
            this.panel2.Location = new System.Drawing.Point(2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 131);
            this.panel2.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 82);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(20, 44);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 5);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 416);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idconta";
            this.dataGridViewTextBoxColumn1.HeaderText = "idconta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cpf";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cpf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataVenda";
            this.dataGridViewTextBoxColumn5.HeaderText = "dataVenda";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataVencimento";
            this.dataGridViewTextBoxColumn6.HeaderText = "dataVencimento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn7.HeaderText = "valor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn8.HeaderText = "status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paguebembdDataSet1BindingSource;
        private DataSet_Pessoa dataSet_Pessoa;
        private System.Windows.Forms.BindingSource dataSetPessoaBindingSource;
        private DataSet_Tabelas dataSet_Tabelas;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSet_TabelasTableAdapters.pessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet_TabelasTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}