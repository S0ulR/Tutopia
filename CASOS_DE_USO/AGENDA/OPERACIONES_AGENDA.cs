using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.AGENDA
{
    public  class OPERACIONES_AGENDA
    {
        public static void AgregarHorarioAgenda(CONTEXTO.TUTOPIA TUTOPIA, Dia dia, TimeSpan horario, Mes? mes = null, int? año = null)
        {
            if (mes != null && año != null)
            {
                AgregarHorarioMesAño(TUTOPIA, dia, horario, mes.Value, año.Value);
            }
            else if (mes != null && año == null)
            {
                AgregarHorarioMesAño(TUTOPIA, dia, horario, mes.Value, DateTime.Now.Year);
            }
            else if (año != null && mes == null)
            {
                foreach (Mes m in Enum.GetValues(typeof(Mes)))
                {
                    AgregarHorarioMesAño(TUTOPIA, dia, horario, m, año.Value);
                }
            }
            else
            {
                throw new ArgumentException("Debe especificar al menos un mes o un año.");
            }
        }

        private static void AgregarHorarioMesAño(CONTEXTO.TUTOPIA TUTOPIA, Dia dia, TimeSpan horario, Mes mes, int año)
        {

        }
        public static void MODIFICAR_AGENDA(CONTEXTO.TUTOPIA TUTOPIA, Agenda AGENDA)
        {
            TUTOPIA.Entry(AGENDA).State = System.Data.Entity.EntityState.Modified;

        }
        public static void ELIMINAR_AGENDA(CONTEXTO.TUTOPIA TUTOPIA, Agenda AGENDA)
        {
            TUTOPIA.oAgenda.Remove(AGENDA);
        }
        public static void ELIMINAR_HORARIO(CONTEXTO.TUTOPIA TUTOPIA, Dia DIA, TimeSpan HORARIO)
        {
            // Busca el turno que coincida con la AgendaId y Horario
            var turno = DIA.Horarios.FirstOrDefault(x => x.HorarioId == DIA.DiaId && x.Hora == HORARIO);

            if (turno == null)
            {
                // No se encontró el turno, no hay nada que eliminar
                return;
            }
            else
            {
                // Eliminar el turno de la lista
                DIA.Horarios.Remove(turno);
            }
        }

    }
}
