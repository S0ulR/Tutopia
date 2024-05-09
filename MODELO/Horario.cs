using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Horario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HorarioId { get; set; }
        public TimeSpan Hora { get; set; }
        public int Cupo { get; set; }
        public string Dia {  get; set; }
        public ICollection<HorarioCliente>? HorarioClientes { get; set; } // Relación muchos a muchos con Cliente
        public override string ToString()
        {
            return Dia;
        }
    }
    public class HorarioCliente
    {
        [Key]
        [Column(Order = 0)]
        public int HorarioId { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ClienteId { get; set; }
        public Horario? Horario { get; set; } // Clave foránea para la relación muchos a muchos con Horario
        public Cliente? Cliente { get; set; } // Clave foránea para la relación muchos a muchos con Cliente

    }
}
