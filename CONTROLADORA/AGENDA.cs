using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class AGENDA
    {
        private static AGENDA instancia;
        public static AGENDA obtener_instancia()
        {
            if (instancia == null)
                instancia = new AGENDA();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private AGENDA()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_AGENDA(MODELO.Agenda AGENDA)
        {
            //CASOS_DE_USO.AGENDA.OPERACIONES_AGENDA.AGREGAR_AGENDA(oCONTEXTO, AGENDA);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_AGENDA(MODELO.Agenda AGENDA)
        {
            CASOS_DE_USO.AGENDA.OPERACIONES_AGENDA.MODIFICAR_AGENDA(oCONTEXTO, AGENDA);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_AGENDA(MODELO.Agenda AGENDA)
        {
            CASOS_DE_USO.AGENDA.OPERACIONES_AGENDA.ELIMINAR_AGENDA(oCONTEXTO, AGENDA);
            oCONTEXTO.SaveChanges();
        }
        public MODELO.Agenda OBTENER_AGENDA(string DIA)
        {
            return CASOS_DE_USO.AGENDA.GESTION_AGENDA.OBTENER_AGENDA(DIA, oCONTEXTO);
        }
        public void ELIMINAR_HORARIO(MODELO.Dia AGENDA, TimeSpan HORARIO)
        {
            CASOS_DE_USO.AGENDA.OPERACIONES_AGENDA.ELIMINAR_HORARIO(oCONTEXTO, AGENDA, HORARIO);
            oCONTEXTO.SaveChanges();
        }
        public List<MODELO.Agenda> OBTENER_AGENDAxMES(string MES)
        {
            return CASOS_DE_USO.AGENDA.GESTION_AGENDA.OBTENER_AGENDASxMES(MES, oCONTEXTO);
        }
        public List<MODELO.Agenda> OBTENER_AGENDAS()
        {
            return CASOS_DE_USO.AGENDA.GESTION_AGENDA.OBTENER_AGENDAS(oCONTEXTO);
        }
    }
}