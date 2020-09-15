using PagueBem.Funcions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagueBem
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
                    }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_Pessoa cad = new Cadastro_Pessoa(txbNome.Text, txbCPF.Text, txbTelefone.Text);
            MessageBox.Show(cad.mensagem);


            txbNome.Text = "";
            txbCPF.Text = "";
            txbTelefone.Text = "";
            this.pessoaTableAdapter.Fill(this.dataSet_Tabelas.pessoa);
        }



        private void btnCad_Debito_Click(object sender, EventArgs e)
        {
            Cadastro_Debito cad_deb = new Cadastro_Debito(txbStatus.Text, Convert.ToDouble(txbValor.Text), DateTime.Now.ToString("yyyy/MM/dd"),
                 txbData_a_Pagar.Value.ToString("yyyy/MM/dd"),Convert.ToInt32 (cbCliente.SelectedValue.ToString()));
            MessageBox.Show(cad_deb.mensagem);


            txbStatus.Text = null;
            txbValor.Text = null;            
            txbData_a_Pagar.Text = null;
            this.dataTable1TableAdapter.Fill(this.dataSet_Tabelas.DataTable1);


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Tabelas.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTable1TableAdapter.Fill(this.dataSet_Tabelas.DataTable1);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Tabelas.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Tabelas.pessoa);



        }

    }
}
