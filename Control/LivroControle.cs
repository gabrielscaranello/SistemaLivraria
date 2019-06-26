using AtividadeTelas.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.control
{
    class LivroControle : Livro
    {
        public LivroControle()
        {
            
        }
        public Boolean CadastrarLivro(Livro Livro)
        {
            try
            {
                DB.Execute($"insert into livros (titulo, autor, qtd_estoque, ano, editora, genero, isbn, valor_unitario) values ('{Livro.Titulo}', '{Livro.Autor}', {Livro.Estoque}, {Livro.Ano}, '{Livro.Editora}', '{Livro.Genero}','{Livro.Isbn}',{Livro.Preco} )");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean AtualizarLivro(Livro Livro)
        {
            return DB.Execute("UPDATE livro SET titulo = @Livro.titulo, autor = @Livro.autor, estoque = @Livro.estoque ano = @Livro.ano, editora = @Livro.editora, genero = @Livro.genero, isbn = @Livro.isbn WHERE id = @Livro.id");
        }
        public Boolean ExcluirLivro(Livro Livro)
        {
            return false;
        }

        public Array BuscarLivroNome(String nome)
        {

            return null;

        }

        public Livro BuscarLivroId(int id)
        {

            return null;

        }

        public Array ListaLivro()
        {



            return null;

        }

    }
}
