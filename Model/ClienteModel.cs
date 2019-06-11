using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.model
{
    class Cliente
    {
        private int id;
        private String nome;
        private String telefone;
        private String cpf;
        private String endereco;
        private String email;
        private DateTime dataNasc;

        protected int Id { get => id; set => id = value; }
        protected string Nome { get => nome; set => nome = value; }
        protected string Telefone { get => telefone; set => telefone = value; }
        protected string Cpf { get => cpf; set => cpf = value; }
        protected string Endereco { get => endereco; set => endereco = value; }
        protected string Email { get => email; set => email = value; }
        protected DateTime DataNasc { get => dataNasc; set => dataNasc = value; }

        public Cliente()
        {

        }
    }
}
