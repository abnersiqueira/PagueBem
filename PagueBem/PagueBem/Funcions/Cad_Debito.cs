using MySql.Data.MySqlClient;
using PagueBem.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace PagueBem.Funcions
{

    public class Cadastro_Debito
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = "";



        public Cadastro_Debito(string Status, Double Valor, string Data_Pagamento, string Data_a_Vencer,int FKPessoa)
        {
            cmd.CommandText = "INSERT INTO conta (status, valor, dataVenda , dataVencimento,FKPessoa) VALUES (@Status, @Valor, @Data_Pagamento, @Data_a_Vencer,@FKPessoa)";

            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            cmd.Parameters.AddWithValue("@Data_Pagamento", Data_Pagamento);
            cmd.Parameters.AddWithValue("@Data_a_Vencer", Data_a_Vencer);
            cmd.Parameters.AddWithValue("@FKPessoa", FKPessoa);

            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

            try
            {
                

            }
            catch (Exception)
            {
                this.mensagem = "Erro de conexão com banco";
            }
        }
    }


    
    
}
