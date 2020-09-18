using MySql.Data.MySqlClient;
using PagueBem.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagueBem.Funcions
{
    class Cad_Consulta
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = "";

        public DataTable Localizar(string Data1, string Data2, string Data3, string Data4, string status, string nome)
        {
            cmd.CommandText = "SELECT pessoa.ID, pessoa.Nome, pessoa.Cpf, pessoa.Telefone, conta.dataVenda, conta.dataVencimento, conta.valor, conta.status FROM conta INNER JOIN pessoa ON conta.FKPessoa = pessoa.ID where conta.dataVenda between '"+Data1+"' and '"+Data2+"' and conta.dataVencimento between '"+Data3+"' and '"+Data4+"' and pessoa.Nome like  '%"+nome+"%' and conta.status like '%"+status+"%'";

            try
            {
                cmd.Connection = conexao.conectar();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dtLista = new DataTable();

                da.Fill(dtLista);

                return dtLista;

            }
            catch (Exception e)
            {
                this.mensagem = "Ocorreu um erro!";
                throw;
            }
            finally
            {
                conexao.desconectar();
            }
        }
    }
}
