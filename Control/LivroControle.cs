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
            return false;
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
