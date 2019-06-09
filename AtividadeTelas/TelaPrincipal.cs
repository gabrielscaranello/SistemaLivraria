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
    public partial class tela1 : Form
    {
        public tela1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lOCAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

        }

        private void btCadFuncionário_Click(object sender, EventArgs e)
        {

        }

        private void btLocar_Click(object sender, EventArgs e)
        {
            Vendas telaVenda = new Vendas();
            telaVenda.Show();

       
        }
    }

    internal class Form2
    {
    }
}
