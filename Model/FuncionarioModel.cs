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
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Funcionario()
        {

        }
    }
}
