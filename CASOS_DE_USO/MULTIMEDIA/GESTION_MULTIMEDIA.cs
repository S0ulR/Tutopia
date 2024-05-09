using CONTEXTO;

namespace CASOS_DE_USO.MULTIMEDIA
{
    public class GESTION_MULTIMEDIA
    {
        public static List<MODELO.Multimedia> OBTENER_MULTIMEDIAxID(int ID, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oMultimedia.Where(_ => _.Ficha.FichaId == ID).ToList();
        }
        public static MODELO.Multimedia OBTENER_MULTIMEDIA(int ID, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oMultimedia.FirstOrDefault(_ => _.MultimediaId == ID);
        }
        public static List<MODELO.Multimedia> OBTENER_MULTIMEDIAS(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oMultimedia.ToList();
        }
    }
}