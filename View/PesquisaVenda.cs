using AtividadeTelas.control;
using MySql.Data.MySqlClient;
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

        private void BtPesquisarVenda_Click(object sender, EventArgs e)
        {
            String pesquisa = txtVenda.Text;
            MySqlDataReader vendas;

            vendas = DB.Select("select vendas.id_venda, titulo , data_venda, " +
                "valor_total from vendas inner join items_venda inner join livros on items_venda.id_livro = livros.id_livro;" +
                " where titulo like '%" + pesquisa + "%'");

            dgvTabVenda.Rows.Clear();




            while (vendas.Read())
            {
                dgvTabVenda.Rows.Add(vendas["id_venda"].ToString(), vendas["titulo"].ToString(),vendas["valor_total"].ToString());
            }
        }
    }
}
