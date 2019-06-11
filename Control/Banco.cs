using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace AtividadeTelas.control
{
    class Banco
    {

        public MySqlConnection Conn()
        {
            string conexao = "Server=localhost;Port=3306;Database=livraria;Uid=root;Pwd=12345";
            MySqlConnection connection = new MySqlConnection(conexao);
            return connection;
        }


    }


}
