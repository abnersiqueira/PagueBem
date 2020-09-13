using MySql.Data.MySqlClient;
using PagueBem.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagueBem.Funcions
{

    public class Cadastro_Debito
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = "";



        public Cadastro_Debito(int Status, Double Valor, string Data_Pagamento, string Data_a_Vencer)
        {
            cmd.CommandText = "INSERT INTO conta1 (statu1, Valor, data1, data2) VALUES (@Status, @Valor, @Data_Pagamento, @Data_a_Vencer)";

            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            cmd.Parameters.AddWithValue("@Data_Pagamento", Data_Pagamento);
            cmd.Parameters.AddWithValue("@Data_a_Vencer", Data_a_Vencer);



            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (Exception)
            {
                this.mensagem = "Erro de conexão com banco";
            }
        }
    }


    
    
}
