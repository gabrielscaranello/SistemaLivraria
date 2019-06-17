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
    public partial class PesquisaVenda : Form
    {
        public PesquisaVenda()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void PesquisaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();

            }
        }

        private void PesquisaVenda_Load(object sender, EventArgs e)
        {

            
        }
    }
}
