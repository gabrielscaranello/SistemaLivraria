using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeTelas.control;
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

            //MySqlDataReader pesquisa = DB.Select("select nome from clientes");

            //while (pesquisa.Read())
            //{
            //    Console.WriteLine(pesquisa["id"].ToString());
            //}

            //String sql = "insert into clientes(nome, telefone, cpf, endereco, email, data_nasc)" +
            //    "values('gabriel', '9999', '123123', 'hchchc', 'mail','1998-12-29')";
            //String sql = "delete from clientes where id_cliente = 2";
            //DB.Execute(sql);
        }


        private void ResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

// HEAD
        //private void ResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        //{}

       // private void PesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        //{
         //   if (e.KeyValue.Equals(27))
          //  {
           //     this.Close();
            //}
        //}


     //   private void PesquisaCliente_KeyDown(object sender, KeyEventArgs e)
      //  {
          //  if (e.KeyValue.Equals(27))
            //{
                
            //}
        //}

       // private void PesquisaCliente_Load(object sender, EventArgs e)
       // {

      //  }


        }

    }

