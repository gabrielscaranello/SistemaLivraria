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

        public int Id { get => id; set => id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public int Funcionario_id { get => funcionario_id; set => funcionario_id = value; }
        public DateTime Data { get => data; set => data = value; }
        public Array Livros_venda { get => livros_venda; set => livros_venda = value; }

        public Venda()
        {
        }
    }
}
