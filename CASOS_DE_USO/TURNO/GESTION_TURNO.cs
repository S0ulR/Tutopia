using MODELO;

namespace CASOS_DE_USO.TURNO
{
    public class GESTION_TURNO
    {
        public static List<Turno> OBTENER_TURNOS(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oTurno.ToList();
        }
        public static List<Turno> OBTENER_AGENDAxDIAOCUPADO(int ID, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oTurno.Where(t => t.ClienteId == ID).ToList();
        }

        public static List<Turno> OBTENER_AGENDAxDIALIBRE(string DIA, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oTurno.Where(t => t.Dias.Any(d => d.Nombre == DIA) && !t.Reservado).ToList();
        }
    }
}
