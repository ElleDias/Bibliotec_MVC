using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Nome;
        public string Escritor;
        public string Editora;
        public string Descricao;
        public string Idioma;
        public string Imagem;
        public bool Reservado;
        public bool Ativo;

    }
}