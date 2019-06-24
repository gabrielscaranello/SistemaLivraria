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

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public float Preco { get => preco; set => preco = value; }

        public Livro()
        {

        }
    }
}
