namespace CONTROLADORA
{
    public class MULTIMEDIA
    {
        private static MULTIMEDIA instancia;
        public static MULTIMEDIA obtener_instancia()
        {
            if (instancia == null)
                instancia = new MULTIMEDIA();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private MULTIMEDIA()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_MULTIMEDIA(MODELO.Multimedia MULTIMEDIA)
        {
            CASOS_DE_USO.MULTIMEDIA.OPERACIONES_MULTIMEDIA.AGREGAR_MULTIMEDIA(oCONTEXTO, MULTIMEDIA);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_MULTIMEDIA(MODELO.Multimedia MULTIMEDIA)
        {
            CASOS_DE_USO.MULTIMEDIA.OPERACIONES_MULTIMEDIA.MODIFICAR_MULTIMEDIA(oCONTEXTO, MULTIMEDIA);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_MULTIMEDIA(MODELO.Multimedia MULTIMEDIA)
        {
            CASOS_DE_USO.MULTIMEDIA.OPERACIONES_MULTIMEDIA.ELIMINAR_MULTIMEDIA(oCONTEXTO, MULTIMEDIA);
            oCONTEXTO.SaveChanges();
        }
        public List<MODELO.Multimedia> OBTENER_MULTIMEDIAxID(int ID)
        {
            return CASOS_DE_USO.MULTIMEDIA.GESTION_MULTIMEDIA.OBTENER_MULTIMEDIAxID(ID, oCONTEXTO);
        }
        public MODELO.Multimedia OBTENER_MULTIMEDIA(int ID)
        {
            return CASOS_DE_USO.MULTIMEDIA.GESTION_MULTIMEDIA.OBTENER_MULTIMEDIA(ID, oCONTEXTO);
        }
        public List<MODELO.Multimedia> OBTENER_MULTIMEDIAS()
        {
            return CASOS_DE_USO.MULTIMEDIA.GESTION_MULTIMEDIA.OBTENER_MULTIMEDIAS(oCONTEXTO);
        }

    }
}