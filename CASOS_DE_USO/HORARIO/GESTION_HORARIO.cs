using CONTEXTO;
using MODELO;


namespace CASOS_DE_USO.HORARIO
{
    public class GESTION_HORARIO
    {
        public static Horario OBTENER_HORARIO(int ID, CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oHorario.FirstOrDefault(_ => _.HorarioId == ID);
        }
        public static List<Horario> OBTENER_HORARIOS(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oHorario.ToList();
        }
        public static List<Horario> OBTENER_HORARIOSxDIA(string DIA, CONTEXTO.TUTOPIA TUTOPIA)
        {
            // Obtener los horarios para el día seleccionado y que tengan cupo disponible
            return TUTOPIA.oHorario.Where(h => h.Dia == DIA && h.Cupo > 0).ToList();
        }

        public static List<Horario> OBTENER_HORARIOS_LIBRES(CONTEXTO.TUTOPIA TUTOPIA)
        {
            // Obtener los horarios con cupo disponible
            var horariosLibres = TUTOPIA.oHorario.Where(_ => _.Cupo > 0 && _.Cupo != null);

            // Ordenar los horarios por día de la semana (de Lunes a Viernes)
            var horariosOrdenados = horariosLibres.OrderBy(h => h.Dia);

            return horariosOrdenados.ToList();
        }
    }
}
