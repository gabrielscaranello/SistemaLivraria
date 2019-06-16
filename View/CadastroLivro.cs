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
    public partial class Cadastro_de_livro : Form
    {
        public Cadastro_de_livro()
        {
            InitializeComponent();
        }

        private void Cadastro_de_livro_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_de_livro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
