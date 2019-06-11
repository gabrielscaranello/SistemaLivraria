using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        SqlConnection sqlconn = null;
        private String strCon = "Server=srv02.hostoo.io;Port=3306;Database=Sistemalivraria;Uid=Sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
        private String strSql = String.Empty;

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            strCon = "select * from livraria.Cliente where nome=@nome";
        }
    }
}
