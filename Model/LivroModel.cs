using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTelas.model
{
    class Livro
    {
        private int id;
        private String titulo;
        private String autor;
        private int estoque;
        private int ano;
        private String editora;
        private String genero;
        private String isbn;
        private float preco;

        protected int Id { get => id; set => id = value; }
        protected string Titulo { get => titulo; set => titulo = value; }
        protected string Autor { get => autor; set => autor = value; }
        protected int Estoque { get => estoque; set => estoque = value; }
        protected int Ano { get => ano; set => ano = value; }
        protected string Editora { get => editora; set => editora = value; }
        protected string Genero { get => genero; set => genero = value; }
        protected string Isbn { get => isbn; set => isbn = value; }
        protected float Preco { get => preco; set => preco = value; }

        public Livro()
        {

        }
    }
}
