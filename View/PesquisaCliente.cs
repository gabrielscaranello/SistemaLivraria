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
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        

        
        
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String connString = " Server=srv02.hostoo.io; Port=3306;Database=Sistemalivraria;Uid=Sistemalivraria;Pwd=B1n2&thcHhj9CdP4";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand comand = conn.CreateCommand();
            comand.CommandText = "select nome from livraria.Cliente";

            try
            {
                conn.Open();

                

                conn.Close();
            }
            catch (Exception erro) {
                MessageBox.Show("Erro na pesquisa" + erro);
            }
            MySqlDataReader reader = comand.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine(reader["nome"].ToString());
            }
            Console.ReadLine();

        }

        private void ResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
