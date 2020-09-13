using MySql.Data.MySqlClient;
using PagueBem;
using PagueBem.Funcions;
using PagueBem.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PagueBem.Funcions
{


    public class Cadastro_Pessoa
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = "";

        public Cadastro_Pessoa(String Nome, String Cpf, String Telefone)
        {
            cmd.CommandText = "INSERT INTO PESSOA (Nome, Cpf, Telefone) VALUES (@Nome, @Cpf, @Telefone)";

            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Cpf", Cpf);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);

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