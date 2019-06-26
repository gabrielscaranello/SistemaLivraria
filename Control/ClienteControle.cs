using AtividadeTelas.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.control
{
    class ClienteControle : Cliente
    {
        public ClienteControle()
        {
        }
        public MySqlCommand BuscarClienteNome(String nome)
        {
            //BancoBanco conn = new Banco();
            //MySqlCommand command = new MySqlCommand();
            //command.CommandText = "select * from livraria.cliente where nome";
            //return command;
            return null;
        }
        public Boolean CadastrarCliente(Cliente cliente)
        {
            try
            {
                DB.Execute($"insert into clientes(nome, telefone, cpf, endereco, email, data_nasc) values ('{cliente.Nome}', '{cliente.Telefone}', '{cliente.Cpf}', '{cliente.Email}','{cliente.Endereco}',  STR_TO_DATE('{cliente.DataNasc.ToString()}', '%d/%m/%Y'))");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean AtualizarCliente(Cliente cliente)
        {
<<<<<<< HEAD
            return false;
       //     return DB.Execute("update", "UPDATE cliente SET nome = @Cliente.nome, telefone = @Cliente.telefone, cpf = @Cliente.cpf, endereco = @Cliente.endereco, email = @Cliente.email, dataNasc = @Cliente.dataNasc  WHERE id = @Cliente.id");
=======
            //   return DB.Execute("update", "UPDATE cliente SET nome = @Cliente.nome, telefone = @Cliente.telefone, cpf = @Cliente.cpf, endereco = @Cliente.endereco, email = @Cliente.email, dataNasc = @Cliente.dataNasc  WHERE id = @Cliente.id");
            return false;
>>>>>>> master
        }
        public Boolean ExcluirCliente(Cliente cliente)
        {
            return false;
        }

        public Cliente BuscarClienteId(int id)
        {
            return null;
        }

        public Array ListaCliente()
        {
            return null;
        }

    }
}
