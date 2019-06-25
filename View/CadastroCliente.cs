using AtividadeTelas.control;
using AtividadeTelas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                //Alerta na tecla de atalho 

                DialogResult resultado = MessageBox.Show("Você deseja realmente fechar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)

                    this.Close();           
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mtxtTelefone.Text;
            cliente.Cpf = mtxtCPF.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Email = txtEmail.Text;
            cliente.DataNasc = DateTime.ParseExact(mtxtNascimento.Text, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
            new ClienteControle().CadastrarCliente(cliente);
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
