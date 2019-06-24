using AtividadeTelas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.control
{
    class FuncionarioControle : Funcionario
    {
        public FuncionarioControle()
        {
        }
        public Boolean CadastrarFuncionario(Funcionario Funcionario)
        {
            return false;
        }
        public Boolean AtualizarFuncionario(Funcionario Funcionario)
        {
            return DB.Execute("UPDATE funcionario SET nome = @Funcionario.nome, cargo = @Funcionario.cargo, dataNasc = @Funcionario.data_nasc WHERE id = @Funcionario.id");
        }
        public Boolean ExcluirFuncionario(Funcionario Funcionario)
        {
            return false;
        }

        public Array BuscarFuncionarioNome(String nome)
        {
            return null;
        }

        public Funcionario BuscarFuncionarioId(int id)
        {
            return null;
        }

        public Array ListaFuncionario()
        {
            return null;
        }

    }
}
