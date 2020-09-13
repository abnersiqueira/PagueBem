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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbData_a_Pagar = new System.Windows.Forms.DateTimePicker();
            this.txbDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnCad_Debito = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txbData_a_Pagar);
            this.panel1.Controls.Add(this.txbDataPagamento);
            this.panel1.Controls.Add(this.btnCad_Debito);
            this.panel1.Controls.Add(this.txbStatus);
            this.panel1.Controls.Add(this.txbValor);
            this.panel1.Location = new System.Drawing.Point(428, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 137);
            this.panel1.TabIndex = 0;
            // 
            // txbData_a_Pagar
            // 
            this.txbData_a_Pagar.Location = new System.Drawing.Point(220, 56);
            this.txbData_a_Pagar.Name = "txbData_a_Pagar";
            this.txbData_a_Pagar.Size = new System.Drawing.Size(200, 20);
            this.txbData_a_Pagar.TabIndex = 6;
            // 
            // txbDataPagamento
            // 
            this.txbDataPagamento.Location = new System.Drawing.Point(0, 56);
            this.txbDataPagamento.Name = "txbDataPagamento";
            this.txbDataPagamento.Size = new System.Drawing.Size(200, 20);
            this.txbDataPagamento.TabIndex = 4;
            // 
            // btnCad_Debito
            // 
            this.btnCad_Debito.Location = new System.Drawing.Point(102, 102);
            this.btnCad_Debito.Name = "btnCad_Debito";
            this.btnCad_Debito.Size = new System.Drawing.Size(75, 23);
            this.btnCad_Debito.TabIndex = 5;
            this.btnCad_Debito.Text = "Cadastrar Debido";
            this.btnCad_Debito.UseVisualStyleBackColor = true;
            this.btnCad_Debito.Click += new System.EventHandler(this.btnCad_Debito_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(220, 16);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(100, 20);
            this.txbStatus.TabIndex = 4;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(102, 16);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.txbTelefone);
            this.panel2.Controls.Add(this.txbCPF);
            this.panel2.Controls.Add(this.txbNome);
            this.panel2.Location = new System.Drawing.Point(70, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 137);
            this.panel2.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(139, 92);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Incluir cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(4, 70);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(4, 44);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 1;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(4, 18);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.DateTimePicker txbData_a_Pagar;
        private System.Windows.Forms.DateTimePicker txbDataPagamento;
        private System.Windows.Forms.Button btnCad_Debito;
        private System.Windows.Forms.Button btnCadastrar;
    }
}