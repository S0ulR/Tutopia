using CONTEXTO;
using MODELO;

namespace CASOS_DE_USO.DIA
{
    public class OPERACIONES_DIA
    {
        public static void AGREGAR_DIA(TUTOPIA TUTOPIA, Dia DIA)
        {
            TUTOPIA.oDia.Add(DIA);
        }

        public static void ELIMINAR_DIA(TUTOPIA TUTOPIA, Dia DIA)
        {
            TUTOPIA.oDia.Remove(DIA);
        }
        public static void MODIFICAR_DIA(TUTOPIA TUTOPIA, Dia DIA)
        {
            TUTOPIA.Entry(DIA).State = System.Data.Entity.EntityState.Modified;
        }
        public static void AgregarHorarioAlDia(TUTOPIA TUTOPIA, string NombreDia, Horario nuevoHorario)
        {
            // Obtener el día al que se agregará el horario
            Dia dia = TUTOPIA.oDia.FirstOrDefault(d => d.Nombre == NombreDia);

            if (dia != null)
            {
                // Verificar si la lista de horarios del día está inicializada
                if (dia.Horarios == null)
                {
                    // Si no está inicializada, inicialízala
                    dia.Horarios = new List<Horario>();
                }

                // Agregar el nuevo horario a la lista de horarios del día
                dia.Horarios.Add(nuevoHorario);
            }
            else
            {
                Console.WriteLine("No se encontró ningún día con el nombre especificado.");
            }
        }
    }
}
