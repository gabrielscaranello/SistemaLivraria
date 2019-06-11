using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.model
{
    class Venda
    {
        private int id;
        private int cliente_id;
        private int funcionario_id;
        private DateTime data;
        private Array livros_venda;

        protected int Id { get => id; set => id = value; }
        protected int Cliente_id { get => cliente_id; set => cliente_id = value; }
        protected int Funcionario_id { get => funcionario_id; set => funcionario_id = value; }
        protected DateTime Data { get => data; set => data = value; }
        protected Array Livros_venda { get => livros_venda; set => livros_venda = value; }

        public Venda()
        {
        }
    }
}
