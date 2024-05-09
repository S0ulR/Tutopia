using MODELO;

namespace CONTROLADORA
{
    public class TURNO
    {
        private static TURNO instancia;
        public static TURNO obtener_instancia()
        {
            if (instancia == null)
                instancia = new TURNO();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private TURNO()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_TURNO(MODELO.Turno TURNO)
        {
            CASOS_DE_USO.TURNO.OPERACIONES_TURNO.AGREGAR_TURNO(oCONTEXTO, TURNO);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_TURNO(MODELO.Turno TURNO)
        {
            CASOS_DE_USO.TURNO.OPERACIONES_TURNO.MODIFICAR_TURNO(oCONTEXTO, TURNO);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_TURNO(MODELO.Turno TURNO)
        {
            CASOS_DE_USO.TURNO.OPERACIONES_TURNO.ELIMINAR_TURNO(oCONTEXTO, TURNO);
            oCONTEXTO.SaveChanges();
        }
        public List<MODELO.Turno> OBTENER_TURNOS()
        {
            return CASOS_DE_USO.TURNO.GESTION_TURNO.OBTENER_TURNOS(oCONTEXTO);
        }
        public List<MODELO.Turno> OBTENER_AGENDAxDIAOCUPADO(int ID)
        {
            return CASOS_DE_USO.TURNO.GESTION_TURNO.OBTENER_AGENDAxDIAOCUPADO(ID, oCONTEXTO);
        }
        public List<MODELO.Turno> OBTENER_AGENDAxDIALIBRE(string DIA)
        {
            return CASOS_DE_USO.TURNO.GESTION_TURNO.OBTENER_AGENDAxDIALIBRE(DIA, oCONTEXTO);
        }

    }
}