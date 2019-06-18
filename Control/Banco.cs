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

        public static MySqlConnection Execute(String type, String sql)
        {
            string conexao = "Server=srv02.hostoo.io;Port=3306;Database=sistemalivraria;Uid=sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
            MySqlConnection connection = new MySqlConnection(conexao);
            
            try {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.text;

                if(type.Equals("select")){
                    MySqlDataReader result;
                    result = command.ExecuteReader();
                    return result.Read();
                }else{
                    command.ExecuteNonQuery();
                }
                connection.Close();
            } catch (Exception error) {
                return error.Message;
                throw;
                }
            return "Success";
        }
    }
}
