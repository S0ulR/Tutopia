using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODELO
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public byte[]? Imagen { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public DateTime Fecha_Ingreso { get; set; } = DateTime.Now;
        public DateTime? ultimoPago { get; set; }
        public string? Correo { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; } = true; // Valor por defecto es true
        public long Telefono { get; set; }
        public bool Deudor { get; set; } = false;
        public ICollection<Turno>? Turnos { get; set; }
        public Ficha? Ficha { get; set; } // Relación uno a uno con Ficha
        public ICollection<HorarioCliente>? HorarioClientes { get; set; } // Relación muchos a muchos con Horario

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
        #region "Método que calcula la edad"
        public int Calcular_Edad()
        {
            Edad = DateTime.Now.Year - Fecha_Nac.Year;
            if (DateTime.Now.Month < Fecha_Nac.Month)
                Edad -= 1;
            if (DateTime.Now.Month == Fecha_Nac.Month && DateTime.Now.Day < Fecha_Nac.Day)
                Edad -= 1;

            return Edad;

        }
        #endregion

        #region "Método para registrar un pago"
        public void RegistrarPago(DateTime fechaPago)
        {
            ultimoPago = fechaPago;
        }
        #endregion
    }
}
