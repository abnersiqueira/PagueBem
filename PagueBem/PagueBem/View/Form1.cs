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

        public static string MascaraCnpjCpf(string pCnpjCpf)
        {
            string result = "";

            if (pCnpjCpf.Length == 11)
            {
                result = pCnpjCpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            if(pCnpjCpf.Length != 11)
            {
                result = pCnpjCpf;
            }
            return result;
        }

        public static string MascaraTelefone(string pmaskTelefone)
        {
            string rTel = "";

            try
            {
                rTel = pmaskTelefone.Insert(0, "(").Insert(3, ")").Insert(5, ".").Insert(10, "-");
                if (pmaskTelefone.Length != 11)
                {
                    rTel = pmaskTelefone;
                }
               
            }
            catch
            {

            }
            return rTel;
        }


        public static void Moeda(ref TextBox txt)
        {
            String n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")

                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = String.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception)
            {

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txbNome.Text != "" && txbTelefone.Text != "" && txbCPF.Text != "")
            {

                Cadastro_Pessoa cad = new Cadastro_Pessoa(txbNome.Text, txbCPF.Text, txbTelefone.Text);
                MessageBox.Show(cad.mensagem);


                txbNome.Text = "";
                txbCPF.Text = "";
                txbTelefone.Text = "";
                this.dataTable1TableAdapter.Fill(this.dataSet_Tabelas.DataTable1);
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos!","Campos incompletos");
            }
           
        }

        private void btnCad_Debito_Click(object sender, EventArgs e)
        {
            Cadastro_Debito cad_deb = new Cadastro_Debito(txbStatus.Text, Convert.ToDouble(txbValor.Text), DateTime.Now.ToString("yyyy/MM/dd"),
                 txbData_a_Pagar.Value.ToString("yyyy/MM/dd"),Convert.ToInt32 (cbCliente.SelectedValue.ToString()));
            MessageBox.Show(cad_deb.mensagem);

            txbStatus.Text = null;
            txbValor.Text = null;            
            txbData_a_Pagar.Text = null;
           

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'paguebembdDataSet.pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter2.Fill(this.paguebembdDataSet.pessoa);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Tabelas.conta'. Você pode movê-la ou removê-la conforme necessário.
            this.contaTableAdapter.Fill(this.dataSet_Tabelas.conta);


        }

        private void txbValor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txbValor);
        }


        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;

            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Cad_Consulta consulta = new Cad_Consulta();          
            dataGridView1.DataSource = consulta.Localizar(dateTimeInicialCadastro.Value.ToString("yyyy/MM/dd"), dateTimeFinalCadastro.Value.ToString("yyyy/MM/dd"), dateTimeInicioVencimento.Value.ToString("yyyy/MM/dd"), dateTimeFinalVencimento.Value.ToString("yyyy/MM/dd"), cbStatusPesquisa.Text, CbPesqueisaCliente.Text);
            
        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;

            }
        }

        private void txbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;

            }

        }


        private void txbCPF_Leave(object sender, EventArgs e)
        {
            txbCPF.Text = MascaraCnpjCpf(txbCPF.Text);
        }

        private void txbTelefone_Leave(object sender, EventArgs e)
        {
            txbTelefone.Text = MascaraTelefone(txbTelefone.Text);
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
