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
    public partial class PesquisaFuncionario : Form
    {
        public PesquisaFuncionario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Controle_Funcionário_Load(object sender, EventArgs e)
        {

        }

        private void PesquisaFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisarFunc_Click(object sender, EventArgs e)
        {
            String pesquisa = txtNomeFunc.Text;
            MySqlDataReader funcionarios;

            funcionarios = DB.Select("select * from funcionarios where nome like '%" + pesquisa + "%'");

            dgvTabPesquisaFunc.Rows.Clear();




            while (funcionarios.Read())
            {
                dgvTabPesquisaFunc.Rows.Add(funcionarios["id"].ToString(), funcionarios["nome"].ToString());
            }

        }

        private void TxtNomeFunc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
