using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.model
{
    class Funcionario
    {

        private int id;
        private String nome;
        private String cargo;
        private String cpf;
        private String endereco;
        private DateTime dataNasc;

        protected int Id { get => id; set => id = value; }
        protected string Nome { get => nome; set => nome = value; }
        protected string Cargo { get => cargo; set => cargo = value; }
        protected string Cpf { get => cpf; set => cpf = value; }
        protected string Endereco { get => endereco; set => endereco = value; }
        protected DateTime DataNasc { get => dataNasc; set => dataNasc = value; }

        public Funcionario()
        {

        }
    }
}
