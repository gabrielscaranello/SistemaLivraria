using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace AtividadeTelas.control
{
    class DB
    {

        public static Boolean Execute(String sql)
        {
            string conexao = "Server=srv02.hostoo.io;Port=3306;Database=sistemalivraria;Uid=sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
            MySqlConnection connection = new MySqlConnection(conexao);

            try
            {
                
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
            connection.Close();
            return true;
        }
        public static MySqlDataReader Select(String sql)
        {
            string conexao = "Server=srv02.hostoo.io;Port=3306;Database=sistemalivraria;Uid=sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
            MySqlConnection connection = new MySqlConnection(conexao);

            try
            {
                
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                connection.Open();
                MySqlDataReader result = command.ExecuteReader();


                return result;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                throw;
            }
        }

        internal object Conn()
        {
            throw new NotImplementedException();
        }
    }
}
