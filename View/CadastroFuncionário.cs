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

        private void BtSalvar_Click(object sender, EventArgs e)
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

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
