﻿using System;
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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            PesquisaLivro pesquisaLivro = new PesquisaLivro();
            pesquisaLivro.ShowDialog();
        }

       
        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesquisaCliente = new PesquisaCliente();
            pesquisaCliente.ShowDialog();
        }

        private void BtnPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            
        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
