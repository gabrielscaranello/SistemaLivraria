﻿using System;
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
            string conexao = "Server=srv02.hostoo.io;Port=3306;Database=Sistemalivraria;Uid=Sistemalivraria;Pwd=T5-G&w&EfQ5K5RCZ";
            MySqlConnection connection = new MySqlConnection(conexao);
            return connection;
        }


    }


}
