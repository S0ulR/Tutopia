using MODELO;

namespace CASOS_DE_USO.DIA
{
    public class GESTION_DIA
    {
        public static List<Dia> OBTENER_DIAS(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oDia.ToList();
        }
        public static Dia OBTENER_DIA(string DIA, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oDia.FirstOrDefault(t => t.Nombre == DIA);
        }
    }
}
