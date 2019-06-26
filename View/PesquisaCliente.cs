using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtividadeTelas.control;
using AtividadeTelas.model;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class PesquisaCliente : Form
    {
        private OleDbCommand cmd;

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
            String pesquisa = txtPesquisarNome.Text;
            MySqlDataReader clientes;

            clientes = DB.Select("select * from clientes where nome like '%" + pesquisa + "%'");

            dgvTabCliente.Rows.Clear();




            while (clientes.Read())
            {
                dgvTabCliente.Rows.Add(clientes["id_cliente"].ToString(), clientes["nome"].ToString());
            }


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

        private void DgvTabCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

