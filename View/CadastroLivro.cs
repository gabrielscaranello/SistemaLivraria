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
            if (!String.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                txtTitulo.BackColor = Color.White;
                txtTitulo.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtAutor.Text))
            {
                txtAutor.BackColor = Color.White;
                txtAutor.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtEditora.Text))
            {
                txtEditora.BackColor = Color.White;
                txtEditora.ForeColor = Color.White;
            }

            if (!String.IsNullOrWhiteSpace(cboGenero.Text))
            {
                cboGenero.BackColor = Color.White;
                cboGenero.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                txtEstoque.BackColor = Color.White;
                txtEstoque.ForeColor = Color.Black;
            }

            if (!String.IsNullOrWhiteSpace(txtISBN.Text))
            {
                txtISBN.BackColor = Color.White;
                txtISBN.ForeColor = Color.Black;
            }
            if (!String.IsNullOrWhiteSpace(txtAno.Text))
            {
                txtAno.BackColor = Color.White;
                txtAno.ForeColor = Color.Black;
            }
            if (!String.IsNullOrWhiteSpace(txtPreco.Text))
            {
                txtPreco.BackColor = Color.White;
                txtPreco.ForeColor = Color.Black;
            }


            if (String.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.BackColor = Color.SlateGray;
                txtTitulo.ForeColor = Color.White;
                txtTitulo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.BackColor = Color.SlateGray;
                txtAutor.ForeColor = Color.White;
                txtAutor.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtEditora.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditora.BackColor = Color.SlateGray;
                txtEditora.ForeColor = Color.White;
                txtEditora.Focus();
            }

            else if (String.IsNullOrWhiteSpace(cboGenero.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenero.BackColor = Color.SlateGray;
                cboGenero.ForeColor = Color.White;
                cboGenero.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.BackColor = Color.SlateGray;
                txtEstoque.ForeColor = Color.White;
                txtEstoque.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.BackColor = Color.SlateGray;
                txtISBN.ForeColor = Color.White;
                txtISBN.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAno.BackColor = Color.SlateGray;
                txtAno.ForeColor = Color.White;
                txtAno.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Campo obrigatório vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.BackColor = Color.SlateGray;
                txtPreco.ForeColor = Color.White;
                txtPreco.Focus();
            }
            else
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
                    MessageBox.Show("Seu cadastro foi feito com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
