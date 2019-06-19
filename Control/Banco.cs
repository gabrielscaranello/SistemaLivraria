using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace AtividadeTelas.control
{
    class Banco
    {

        public static MySqlConnection Execute(String type, String sql)
        {
            string conexao = "Server=srv02.hostoo.io;Port=3306;Database=sistemalivraria;Uid=sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
            MySqlConnection connection = new MySqlConnection(conexao);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                if (type.Equals("select"))
                {
                    MySqlDataReader result;
                    result = command.ExecuteReader();
                    
                }
                else
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                throw;
            }
            return null;
        }

        internal object Conn()
        {
            throw new NotImplementedException();
        }
    }
}
