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
        private String strComand = "select * from livraria.Cliente where nome=@nome";

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string de conexão
                strCon objconn = new strCon("Server=srv02.hostoo.io;Port=3306;Database=Sistemalivraria;Uid=Sistemalivraria;Pwd=B1n2&thcHhj9CdP4");
     
                //abre a conexão com o banco de dados
                sqlconn.Open();

                var strcom = new strComand("select nome from livraria.Cliente where nome=@nome", strComand);



                //fecha conexão com o banco
                sqlconn.Close();
            }
            catch (Exception erro) {
                MessageBox.Show("Erro na pesquisa" + erro);
            }
            

        }

        private void ResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
