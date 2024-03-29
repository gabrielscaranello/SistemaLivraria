﻿using AtividadeTelas.control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class PesquisaLivro : Form
    {
        public PesquisaLivro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void PesquisaLivro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void PesquisaLivro_Load(object sender, EventArgs e)
        {

        }

        private void BtPesquisarLivro_Click(object sender, EventArgs e)
        {
            String pesquisa = txtTitulo.Text;
            MySqlDataReader livro;

            livro = DB.Select("select id_livro, titulo from livros where titulo like '%" + pesquisa + "%'");

            dgvTabPesquisaLivros.Rows.Clear();




            while (livro.Read())
            {
                dgvTabPesquisaLivros.Rows.Add(livro["id_livro"].ToString(), livro["titulo"].ToString());
            }
        }
    }
}
