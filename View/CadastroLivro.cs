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
                this.Close();
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"[^\d]");
                Livro livro = new Livro();
                livro.Titulo = txtTitulo.Text;
                livro.Autor = txtAutor.Text;
                livro.Editora = txtEditora.Text;
                livro.Genero = cboGenero.Text;
                livro.Estoque = int.Parse(txtEstoque.Text);
                livro.Isbn = txtISBN.Text;
                livro.Ano =int.Parse(mtxtDataPublicacao)
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

        private void BtSalvar_Click_1(object sender, EventArgs e)
        {
       
            Livro livro = new Livro();
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.Estoque = int.Parse(txtEstoque.Text);
            livro.Ano = int.Parse(mtxtDataPublicacao.Text);
            livro.Editora = txtEditora.Text;
            livro.Genero = cboGenero.Text;
            livro.Isbn = txtISBN.Text;
            livro.Preco =float.Parse(txtPreco.Text);

            new LivroControle().CadastrarLivro(livro);
        }
    }
}
