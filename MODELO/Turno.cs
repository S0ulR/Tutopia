using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODELO
{
    public enum Mes
    {
        Enero,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Septiembre,
        Octubre,
        Noviembre,
        Diciembre
    }
    public class Turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TurnoId { get; set; }
        public bool Reservado { get; set; }
        public int? ClienteId { get; set; } // Clave foránea para la relación muchos a uno con Cliente
        public Cliente? Cliente { get; set; }
        public int? HorarioId { get; set; } // Clave foránea para la relación muchos a uno con Horario
        public Horario? Horario { get; set; }
        public int? AgendaId { get; set; } // Clave foránea para la relación muchos a uno con Agenda
        public Agenda? Agenda { get; set; }
        public int? DiaId { get; set; }
        public List<Dia> Dias { get; set; }
    }

}

