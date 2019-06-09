using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.model
{
    class Venda
    {
        protected int id;
        protected int cliente_id;
        protected int funcionario_id;
        protected DateTime data;
        protected Array livros_venda;

        public Venda()
        {
        }
    }
}
