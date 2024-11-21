using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
    {
        public int LivroReservaID { get; set; }
        public int Status;
        public DateOnly DtReserva { get; set; }
        public DateOnly DtDevolucao { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        [ForeignKey("Livro")]
        public int LivroId { get; set; }



    }
}