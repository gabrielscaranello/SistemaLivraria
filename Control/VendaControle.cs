using AtividadeTelas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.control
{
    class VendaControle : Venda
    {
        public VendaControle()
        {
        }
        public Boolean CadastrarVenda(Venda Venda)
        {
            return false;
        }
        public Boolean AtualizarVenda(Venda Venda)
        {
            return false;
        }
        public Boolean ExcluirVenda(Venda Venda)
        {
            return false;
        }

        public Array BuscarVendaNome(String nome)
        {
            return null;
        }

        public Venda BuscarVendaId(int id)
        {
            return null;
        }

        public Array ListaVenda()
        {
<<<<<<< HEAD
            return 0;
=======
            return null;

>>>>>>> master
        }

    }
}
