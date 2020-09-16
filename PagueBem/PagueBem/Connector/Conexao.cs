using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagueBem.Connector
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Server=127.0.0.1; Database = paguebembd; Uid = root; Pwd = 19954567";
        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                
            }

        }

    }
}


