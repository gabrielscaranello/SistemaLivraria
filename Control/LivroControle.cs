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
                Banco conn = new Banco();
                MySqlCommand command = conn.Conn().CreateCommand();
                command.CommandText = "UPDATE cliente SET nome = @Cliente.nome, telefone = @Cliente.telefone, cpf = @Cliente.cpf, endereco = @Cliente.endereco, email = @Cliente.email, dataNasc = @Cliente.dataNasc  WHERE id = @Cliente.id";

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
