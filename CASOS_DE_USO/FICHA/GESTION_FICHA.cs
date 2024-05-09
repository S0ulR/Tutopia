namespace CASOS_DE_USO.FICHA
{
    public class GESTION_FICHA
    {
        public static MODELO.Ficha OBTENER_FICHA(string DNI, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oFicha.FirstOrDefault(_ => _.Cliente.DNI == DNI);
        }
        public static MODELO.Ficha OBTENER_FICHAxID(int ID, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oFicha.FirstOrDefault(_ => _.FichaId == ID);
        }
        public static List<MODELO.Ficha> OBTENER_FICHAS(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oFicha.ToList();
        }
        public static List<MODELO.Ficha> OBTENER_FICHASxDNI(string DNI, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oFicha.Where(_ => _.Cliente.DNI == DNI).ToList();
        }
    }
}
