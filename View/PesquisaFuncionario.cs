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
    public partial class PesquisaFuncionario : Form
    {
        public PesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void Controle_Funcionário_Load(object sender, EventArgs e)
        {

        }

        private void PesquisaFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
