using AtividadeTelas.model;
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
            return false;
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
