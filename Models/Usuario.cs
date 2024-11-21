using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nome;
        public string Email;
        public string Senha;
        public string Contato;
        public bool Status;
        public bool Admin;
        public DateOnly Dtnacimento;

        [ForeignKey("Curso")]
        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}