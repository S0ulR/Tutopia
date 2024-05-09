using CONTEXTO;
using MODELO;
using System.Linq;

namespace CASOS_DE_USO.HORARIO
{
    public class OPERACIONES_HORARIO
    {
        public static void AGREGAR_HORARIO(TUTOPIA TUTOPIA, Horario HORARIO)
        {
            TUTOPIA.oHorario.Add(HORARIO);
        }

        public static void ELIMINAR_HORARIO(TUTOPIA TUTOPIA, Horario HORARIO)
        {
            TUTOPIA.oHorario.Remove(HORARIO);
        }

        public static void MODIFICAR_HORARIO(TUTOPIA TUTOPIA, Horario HORARIO)
        {
            TUTOPIA.Entry(HORARIO).State = System.Data.Entity.EntityState.Modified;
        }

    }
}

