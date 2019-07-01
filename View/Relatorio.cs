using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.View
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PrintDialog p1 = new PrintDialog();
            PrintDocument p2 = new PrintDocument();
            p2.DocumentName = "Imprimindo página";
            p1.Document = p2;
            p1.AllowSelection = true;
            p1.AllowSomePages = true;

            if(p1.ShowDialog() == DialogResult.OK)
            {
                p2.Print();
            }
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
