using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Dia
    {
        [Key]
        public int DiaId { get; set; }
        public string? Nombre { get; set; }
        public ICollection<Horario>? Horarios { get; set; } // Relación uno a muchos con Horario
        public override string ToString()
        {
            return Nombre;
        }
    }
}
