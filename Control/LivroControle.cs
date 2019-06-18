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
            try
            {
                Banco.Execute("update", "UPDATE livro SET titulo = @Livro.titulo, @Livro.autor, @Livro.qtd_estoque, @Livro.ano, @Livro.editora" +
                    "@Livro.genero, @Livro.isbn, @Livro.valor_unitario WHERE id = @Livro.id");

                return true;
            }
            catch
            {
                return false;
            }
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
