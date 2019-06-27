using AtividadeTelas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.control
{
    class VendaControle : ModeloVenda
    {
        public VendaControle()
        {
        }
        public Boolean CadastrarVenda(ModeloVenda Venda)
        {
            return false;
        }
        public Boolean AtualizarVenda(ModeloVenda Venda)
        {
            return DB.Execute("UPDATE vendas SET id_venda = @Venda.id_venda, id_cliente = @Venda.id_cliente, id_vendedor = @Venda.id_vendedor, data_venda = @Venda.data_venda, valor_total = @Venda.valor_total");
        }
        public Boolean ExcluirVenda(ModeloVenda Venda)
        {
            return false;
        }

        public Array BuscarVendaNome(String nome)
        {
            return null;
        }

        public ModeloVenda BuscarVendaId(int id)
        {
            return null;
        }

        public Array ListaVenda()
        {
            return null;

        }

    }
}
