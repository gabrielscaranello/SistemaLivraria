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
    public partial class PesquisaFuncionario : Form
    {
        public PesquisaFuncionario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void BtVoltar_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisarFunc_Click(object sender, EventArgs e)
        {
            String pesquisa = txtNomeFunc.Text;
            MySqlDataReader funcionarios;
            if (pesquisa.Length > 0)
            {
                funcionarios = AtividadeTelas.control.DB.Select("select * from funcionarios where nome like '%" + pesquisa + "%'");
            }
            else
            {
                funcionarios = DB.Select("select * from funcionarios");

            }
            //dgvTabPesquisaFunc.Columns.Clear();


            while (funcionarios.Read())
            {


                //dgvTabCliente
                //dgvTabPesquisaFunc.Columns.Add(funcionarios["id"].ToString());

                //dgvTabCliente
               // dgvTabPesquisaFunc.Columns.Add(funcionarios[ "nome"].ToString());

            }
            Console.WriteLine("Essa merda não funciona");
        }

        private void TxtNomeFunc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
