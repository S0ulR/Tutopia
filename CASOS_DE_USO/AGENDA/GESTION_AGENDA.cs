using MODELO;

namespace CASOS_DE_USO.AGENDA
{
    public class GESTION_AGENDA
    {
        public static Agenda OBTENER_AGENDA(string DIA, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oAgenda.FirstOrDefault(_ => _.Dias.ToString() == DIA);
        }
        public static List<Agenda> OBTENER_AGENDAS(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oAgenda.ToList();
        }
        public static List<Agenda> OBTENER_AGENDASxMES(string MES, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oAgenda.Where(_ => _.Mes.ToString() == MES).ToList();
        }
    }
}
