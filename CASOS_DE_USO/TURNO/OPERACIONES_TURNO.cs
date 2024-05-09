using CONTEXTO;
using MODELO;
using System.Linq;

namespace CASOS_DE_USO.TURNO
{
    public class OPERACIONES_TURNO
    {
        public static void AGREGAR_TURNO(TUTOPIA TUTOPIA, Turno TURNO)
        {
            TUTOPIA.oTurno.Add(TURNO);
        }

        public static void ELIMINAR_TURNO(TUTOPIA TUTOPIA, Turno TURNO)
        {
            TUTOPIA.oTurno.Remove(TURNO);
        }

        public static void MODIFICAR_TURNO(TUTOPIA TUTOPIA, Turno TURNO)
        {
            TUTOPIA.Entry(TURNO).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
