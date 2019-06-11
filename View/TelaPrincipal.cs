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
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CadastroFuncionário cadFunc = new CadastroFuncionário();
            cadFunc.ShowDialog();
        }

        private void BtPesqFunc_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario pesquisaFuncionario = new PesquisaFuncionario();
            pesquisaFuncionario.ShowDialog();
        }

        private void BtVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.ShowDialog();

        }

        private void BtCadCli_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cadCli = new Cadastro_Cliente();
            cadCli.ShowDialog();


        }

        private void BtCadLivros_Click(object sender, EventArgs e)
        {
            Cadastro_de_livro cadLiv = new Cadastro_de_livro();
            cadLiv.ShowDialog();
        }
    }
}
