using CONTEXTO;

namespace CASOS_DE_USO.FICHA
{
    public class OPERACIONES_FICHA
    {
        public static void AGREGAR_FICHA(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Ficha FICHA)
        {
            TUTOPIA.oFicha.Add(FICHA);
        }

        public static void ELIMINAR_FICHA(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Ficha FICHA)
        {
            TUTOPIA.oFicha.Remove(FICHA);
        }
        public static void MODIFICAR_FICHA(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Ficha FICHA)
        {
            TUTOPIA.Entry(FICHA).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
