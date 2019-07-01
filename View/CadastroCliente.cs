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
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.BackColor = Color.White;
                txtNome.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(mtxtCPF.Text))
            {
                mtxtCPF.BackColor = Color.White;
                mtxtCPF.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(mtxtNascimento.Text))
            {
                mtxtNascimento.BackColor = Color.White;
                mtxtNascimento.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(mtxtTelefone.Text))
            {
                mtxtTelefone.BackColor = Color.White;
                mtxtTelefone.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.White;
                txtEmail.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                txtEndereco.BackColor = Color.White;
                txtEndereco.ForeColor = Color.Black;
            }


            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.SlateGray;
                txtNome.ForeColor = Color.White;
                txtNome.Focus();
            }
            else if (String.IsNullOrWhiteSpace(mtxtCPF.Text) || !mtxtCPF.MaskCompleted)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtCPF.BackColor = Color.SlateGray;
                mtxtCPF.ForeColor = Color.White;
                mtxtCPF.Focus();
            }
            else if (String.IsNullOrWhiteSpace(mtxtNascimento.Text) || !mtxtNascimento.MaskCompleted)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtNascimento.ForeColor = Color.White;
                mtxtNascimento.BackColor = Color.SlateGray;
                mtxtNascimento.Focus();
            }
            else if (String.IsNullOrWhiteSpace(mtxtTelefone.Text) || !mtxtTelefone.MaskCompleted)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtTelefone.BackColor = Color.SlateGray;
                mtxtTelefone.ForeColor = Color.White;
                mtxtTelefone.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.ForeColor = Color.White;
                txtEmail.BackColor = Color.SlateGray;
                txtEmail.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.ForeColor = Color.White;
                txtEndereco.BackColor = Color.SlateGray;
                txtEndereco.Focus();
            }
            else
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
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
