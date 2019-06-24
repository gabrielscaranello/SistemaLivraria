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

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }

        public Cliente()
        {

        }
    }
}
