﻿using AtividadeTelas.model;
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
            Banco conn = new Banco();
            MySqlCommand command = conn.Conn().CreateCommand();
            command.CommandText = "select * from livraria.cliente where nome";
            return command;
        }
        public Boolean CadastrarCliente(Cliente cliente)
        {
            return false;
        }
        public Boolean AtualizarCliente(Cliente cliente)
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
