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
            this.dataGridView1.Refresh();
            this.dataGridView1.RefreshEdit();
            this.dataGridView1.Update();

            txbNome.Text = "";
            txbCPF.Text = "";
            txbTelefone.Text = "";

        }



        private void btnCad_Debito_Click(object sender, EventArgs e)
        {
            Cadastro_Debito cad_deb = new Cadastro_Debito(Convert.ToInt32(txbStatus.Text), Convert.ToDouble(txbValor.Text), txbDataPagamento.Value.ToString("yyyy/MM/dd"), txbData_a_Pagar.Value.ToString("yyyy/MM/dd"));
            MessageBox.Show(cad_deb.mensagem);
            this.dataGridView1.Refresh();


            this.dataGridView1.RefreshEdit();
            this.dataGridView1.Update();

            txbStatus.Text = null;
            txbValor.Text = null;
            txbDataPagamento.Text = null;
            txbData_a_Pagar.Text = null;
        }


    }
}
