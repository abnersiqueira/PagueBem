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
            this.dataGridView1.Refresh();
            this.dataGridView1.RefreshEdit();
            this.dataGridView1.Update();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_Pessoa cad = new Cadastro_Pessoa(txbNome.Text, txbCPF.Text, txbTelefone.Text);
            MessageBox.Show(cad.mensagem);
            this.dataGridView1.Refresh();
            this.dataGridView1.RefreshEdit();
            this.dataGridView1.Update();

            txbNome.Text = "";
            txbCPF.Text = "";
            txbTelefone.Text = "";

        }



        private void btnCad_Debito_Click(object sender, EventArgs e)
        {
            Cadastro_Debito cad_deb = new Cadastro_Debito(txbStatus.Text, Convert.ToDouble(txbValor.Text), DateTime.Now.ToString("yyyy/MM/dd"),
                 txbData_a_Pagar.Value.ToString("yyyy/MM/dd"),Convert.ToInt32 (cbCliente.SelectedValue.ToString()));
            MessageBox.Show(cad_deb.mensagem);
            this.dataGridView1.Refresh();


            this.dataGridView1.RefreshEdit();
            this.dataGridView1.Update();

            txbStatus.Text = null;
            txbValor.Text = null;            
            txbData_a_Pagar.Text = null;


           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'paguebembdDataSet1.InnerJoinConsulta'. Você pode movê-la ou removê-la conforme necessário.
            this.innerJoinConsultaTableAdapter.Fill(this.paguebembdDataSet1.InnerJoinConsulta);
            // TODO: esta linha de código carrega dados na tabela 'paguebembdDataSet1.InnerJoinConsulta'. Você pode movê-la ou removê-la conforme necessário.

            // TODO: esta linha de código carrega dados na tabela 'paguebembdDataSet1.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter1.Fill(this.paguebembdDataSet1.pessoa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
