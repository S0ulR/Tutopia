using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Agenda
    {
        [Key]
        public int AgendaId { get; set; }
        public ICollection<Dia>? Dias { get; set; } // Relación uno a muchos con Dia
        public Mes Mes { get; set; }
        public ICollection<Turno>? Turnos { get; set; }

    }
}
