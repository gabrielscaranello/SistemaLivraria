﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeTelas.model;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }       
        
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String connString = " Server=srv02.hostoo.io; Port=3306;Database=sistemalivraria;Uid=sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand comand = conn.CreateCommand();
            comand.CommandText = "select * from livraria.cliente where nome";
            comand.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                MySqlDataReader result;
                result = comand.ExecuteReader();
                Cliente cliente = new Cliente();
                //cliente = ;
                Console.WriteLine(result.Read());


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na pesquisa" + erro);
            }
            finally
            {
                conn.Close();

            }

            
            }
          

        }

<<<<<<< HEAD
        //private void ResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        //{}

       // private void PesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        //{
         //   if (e.KeyValue.Equals(27))
          //  {
           //     this.Close();
            //}
        //}
=======
        private void PesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {

        }
>>>>>>> master
    }
