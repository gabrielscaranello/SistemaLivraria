using AtividadeTelas.control;
using AtividadeTelas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class Cadastro_de_livro : Form
    {
        public Cadastro_de_livro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Cadastro_de_livro_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_de_livro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                //Alerta na tecla de atalho 

                DialogResult resultado = MessageBox.Show("Você deseja realmente fechar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == System.Windows.Forms.DialogResult.Yes)

                    this.Close();
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Livro livro = new Livro();
                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.Editora = txtEditora.Text;
                livro.Genero = cboGenero.Text;
                livro.Estoque = int.Parse(txtEstoque.Text);
                livro.Isbn = txtISBN.Text;
                livro.Ano = int.Parse(txtAno.Text);
                livro.Preco = float.Parse(txtPreco.Text);
                new LivroControle().CadastrarLivro(livro);
                MessageBox.Show("seu cadastro foi feita com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
