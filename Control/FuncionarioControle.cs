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
        public Boolean CadastrarFuncionario(Funcionario funcionario)
        {

            try
            {
                DB.Execute($"insert into funcionarios (nome, cargo, cpf, endereco, data_nasc) values ('{funcionario.Nome}', '{funcionario.Cargo}', '{funcionario.Cpf}', '{funcionario.Endereco}',  STR_TO_DATE('{funcionario.DataNasc.ToString()}', '%d/%m/%Y'))");

                return true;
            }
            catch
            {
                return false;
            }
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
