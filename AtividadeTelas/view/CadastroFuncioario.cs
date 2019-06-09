using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTelas
{
    public partial class CadastroFuncioario : Form
    {
        public CadastroFuncioario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisarCliente cliente = new PesquisarCliente();
            cliente.ShowDialog();
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLivros livros = new CadastroLivros();
            livros.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cliente = new CadastroCliente();
            cliente.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
