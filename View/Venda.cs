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

            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Button1_Click(object sender, EventArgs e)
        { 
          
            PesquisaLivro pesquisaLivro = new PesquisaLivro();
            pesquisaLivro.ShowDialog();
        }


        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {
            if (e.Equals(13))
            {
                SendKeys.Send("{TAB}");
                PesquisaCliente pesquisaCliente = new PesquisaCliente();
                pesquisaCliente.ShowDialog();
            }
        }
        private void BtnPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario pesquisaFuncionario = new PesquisaFuncionario();
            pesquisaFuncionario.ShowDialog();
        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Venda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                //Alerta na tecla de atalho 

                DialogResult resultado = MessageBox.Show("Você deseja realmente fechar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                

            }
        }


        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpDataVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnPesquisaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtCodFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Venda_Load(object sender, EventArgs e)
        {

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                txtNomeCliente.BackColor = Color.White;
                txtNomeCliente.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtCodFunc.Text))
            {
                txtCodFunc.BackColor = Color.White;
                txtCodFunc.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtProduto.Text))
            {
                txtProduto.BackColor = Color.White;
                txtProduto.ForeColor = Color.White;
            }



            if (String.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.BackColor = Color.SlateGray;
                txtNomeCliente.ForeColor = Color.White;
                txtNomeCliente.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCodFunc.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodFunc.BackColor = Color.SlateGray;
                txtCodFunc.ForeColor = Color.White;
                txtCodFunc.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtProduto.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.BackColor = Color.SlateGray;
                txtProduto.ForeColor = Color.White;
                txtProduto.Focus();
            }
            else
            {

                //inserir o código de salvar aqui...
            }
        }
    }
}


















