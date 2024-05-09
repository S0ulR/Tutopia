using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODELO
{
    public class Ficha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FichaId { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public string? Nota { get; set; }
        public int ClienteId { get; set; } // Clave foránea para la relación uno a uno con Cliente
        public Cliente? Cliente { get; set; }
        public List<Multimedia>? Estudios { get; set; } // Relación uno a muchos con Multimedia
        public string? Afeccion { get; set; }
        public bool? Cirugia { get; set; }
        public string? CirugiaNombre { get; set; }
        public bool? Alergia { get; set; }
        public string? AlergiaTipo { get; set; }
        public double? Altura { get; set; }
        public double? Peso { get; set; }
        public string? Sangre { get; set; }
        public string? Tipo { get; set; }
        public bool? Presion { get; set; }

    }

    public class Multimedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MultimediaId { get; set; }
        public string? NombreArchivo { get; set; }
        public byte[]? Estudio { get; set; }
        public int FichaId { get; set; } // Clave foránea para la relación uno a muchos con Ficha
        public Ficha? Ficha { get; set; }
    }
}
