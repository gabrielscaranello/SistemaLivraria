using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace AtividadeTelas.controle
{
    class Banco
    {

        public void Connectar()
        {
            string conexao = "Server=localhost;Database=livraria;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(conexao);
            connection.Open();
        }



    }


}
