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
            MySqlDataReader clientes = DB.Select("select * from clientes where id_cliente = 1");

            while(clientes.Read())
            {
                Console.WriteLine(clientes["nome"].ToString());
            }
            Console.WriteLine("Essa merda não funciona");

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

