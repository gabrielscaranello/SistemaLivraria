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
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.BackColor = Color.White;
                txtNome.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtCargo.Text))
            {
                txtCargo.BackColor = Color.White;
                txtCargo.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                txtEndereco.BackColor = Color.White;
                txtEndereco.ForeColor = Color.White;
            }

            if (!String.IsNullOrWhiteSpace(mtxtTelefone.Text))
            {
                mtxtTelefone.BackColor = Color.White;
                mtxtTelefone.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(mtxtCPF.Text))
            {
                mtxtCPF.BackColor = Color.White;
                mtxtCPF.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(mtxtDataNasc.Text))
            {
                mtxtDataNasc.BackColor = Color.White;
                mtxtDataNasc.ForeColor = Color.Black;
            }


            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.SlateGray;
                txtNome.ForeColor = Color.White;
                txtNome.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.BackColor = Color.SlateGray;
                txtCargo.ForeColor = Color.White;
                txtCargo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.BackColor = Color.SlateGray;
                txtEndereco.ForeColor = Color.White;
                txtEndereco.Focus();
            }

            else if (String.IsNullOrWhiteSpace(mtxtTelefone.Text) || !mtxtTelefone.MaskCompleted)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtTelefone.BackColor = Color.SlateGray;
                mtxtTelefone.ForeColor = Color.White;
                mtxtTelefone.Focus();
            }
            else if (String.IsNullOrWhiteSpace(mtxtCPF.Text) || !mtxtCPF.MaskCompleted)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtCPF.BackColor = Color.SlateGray;
                mtxtCPF.ForeColor = Color.White;
                mtxtCPF.Focus();
            }
            else if (String.IsNullOrWhiteSpace(mtxtDataNasc.Text) || !mtxtDataNasc.MaskCompleted)
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtDataNasc.BackColor = Color.SlateGray;
                mtxtDataNasc.ForeColor = Color.White;
                mtxtDataNasc.Focus();
            }
            else
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Cargo = txtCargo.Text;
                funcionario.Cpf = mtxtCPF.Text;
                funcionario.Endereco = txtEndereco.Text;
                funcionario.Telefone = mtxtTelefone.Text;
                funcionario.DataNasc = DateTime.ParseExact(mtxtDataNasc.Text, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                new FuncionarioControle().CadastrarFuncionario(funcionario);
            }

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
