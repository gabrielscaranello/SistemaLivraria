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
    public partial class CadastroFuncionário : Form
    {
        public CadastroFuncionário()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TbCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroFuncionário_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                //Alerta na tecla de atalho 

                DialogResult resultado = MessageBox.Show("Você deseja realmente fechar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)

                    this.Close();

            }
        }

        private void CadastroFuncionário_Load(object sender, EventArgs e)
        {
           
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == string.Empty || txtEndereco.Text == string.Empty || txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.BackColor = Color.Blue;
            }
        }
    }
}
