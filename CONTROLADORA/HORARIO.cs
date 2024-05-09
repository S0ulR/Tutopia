using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class HORARIO
    {
        private static HORARIO instancia;
        public static HORARIO obtener_instancia()
        {
            if (instancia == null)
                instancia = new HORARIO();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private HORARIO()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_HORARIO(MODELO.Horario HORARIO)
        {
            CASOS_DE_USO.HORARIO.OPERACIONES_HORARIO.AGREGAR_HORARIO(oCONTEXTO, HORARIO);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_HORARIO(MODELO.Horario HORARIO)
        {
            CASOS_DE_USO.HORARIO.OPERACIONES_HORARIO.MODIFICAR_HORARIO(oCONTEXTO, HORARIO);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_HORARIO(MODELO.Horario HORARIO)
        {
            CASOS_DE_USO.HORARIO.OPERACIONES_HORARIO.ELIMINAR_HORARIO(oCONTEXTO, HORARIO);
            oCONTEXTO.SaveChanges();
        }
        public MODELO.Horario OBTENER_HORARIO(int ID)
        {
            return CASOS_DE_USO.HORARIO.GESTION_HORARIO.OBTENER_HORARIO(ID, oCONTEXTO);
        }
        public List<MODELO.Horario> OBTENER_HORARIOS()
        {
            return CASOS_DE_USO.HORARIO.GESTION_HORARIO.OBTENER_HORARIOS(oCONTEXTO);
        }
        public List<MODELO.Horario> OBTENER_HORARIOxDIA(string DIA)
        {
            return CASOS_DE_USO.HORARIO.GESTION_HORARIO.OBTENER_HORARIOSxDIA(DIA, oCONTEXTO);
        }
        public List<MODELO.Horario> OBTENER_HORARIOS_LIBRES()
        {
            return CASOS_DE_USO.HORARIO.GESTION_HORARIO.OBTENER_HORARIOS_LIBRES(oCONTEXTO);
        }
    }
}
