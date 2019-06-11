using AtividadeTelas.model;
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
        public Boolean CadastrarCliente(Cliente cliente)
        {
            return false;
        }
        public Boolean AtualizarCliente(Cliente cliente)
        {
            return false;
        }
        public Boolean ExcluirCliente(Cliente cliente)
        {
            return false;
        }

        public Array BuscarClienteNome(String nome)
        {
            return null;
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
