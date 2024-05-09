using CONTEXTO;

namespace CASOS_DE_USO.MULTIMEDIA
{
    public class OPERACIONES_MULTIMEDIA
    {
        public static void AGREGAR_MULTIMEDIA(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Multimedia MULTIMEDIA)
        {
            TUTOPIA.oMultimedia.Add(MULTIMEDIA);
        }
        public static void MODIFICAR_MULTIMEDIA(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Multimedia MULTIMEDIA)
        {
            TUTOPIA.Entry(MULTIMEDIA).State = System.Data.Entity.EntityState.Modified;

        }
        public static void ELIMINAR_MULTIMEDIA(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Multimedia MULTIMEDIA)
        {
            TUTOPIA.oMultimedia.Remove(MULTIMEDIA);
        }
    }
}