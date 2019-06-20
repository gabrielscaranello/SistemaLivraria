using SistemaBiblioteca.View;
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
            StartPosition = FormStartPosition.CenterScreen;
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

               private void TelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void TelaPrincipal_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void BtControleVenda_Click(object sender, EventArgs e)
        {
            PesquisaVenda pesVenda = new PesquisaVenda();
            pesVenda.ShowDialog();
        }

        private void BtControleCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesCliente = new PesquisaCliente();
            pesCliente.ShowDialog();
        }

        private void BtControleLivro_Click(object sender, EventArgs e)
        {
            PesquisaLivro pesLivro = new PesquisaLivro();
            pesLivro.ShowDialog();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio telaRelatorio = new Relatorio();
            telaRelatorio.ShowDialog();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            pnlTelaInicio.Location = new Point(this.Width / 2 - 326, this.Height / 2 - 250);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PnlTelaInicio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
