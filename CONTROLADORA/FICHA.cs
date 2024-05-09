using System.Net;

namespace CONTROLADORA
{
    public class FICHA
    {
        private static FICHA? instancia;
        public static FICHA obtener_instancia()
        {
            if (instancia == null)
                instancia = new FICHA();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private FICHA()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_FICHA(MODELO.Ficha FICHA)
        {
            CASOS_DE_USO.FICHA.OPERACIONES_FICHA.AGREGAR_FICHA(oCONTEXTO, FICHA);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_FICHA(MODELO.Ficha FICHA)
        {
            CASOS_DE_USO.FICHA.OPERACIONES_FICHA.MODIFICAR_FICHA(oCONTEXTO, FICHA);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_FICHA(MODELO.Ficha FICHA)
        {
            CASOS_DE_USO.FICHA.OPERACIONES_FICHA.ELIMINAR_FICHA(oCONTEXTO, FICHA);
            oCONTEXTO.SaveChanges();
        }
        public List<MODELO.Ficha> OBTENER_FICHAS()
        {
            return CASOS_DE_USO.FICHA.GESTION_FICHA.OBTENER_FICHAS(oCONTEXTO);
        }
        public List<MODELO.Ficha> OBTENER_FICHASxDNI(string DNI)
        {
            return CASOS_DE_USO.FICHA.GESTION_FICHA.OBTENER_FICHASxDNI(DNI, oCONTEXTO);
        }
        public MODELO.Ficha OBTENER_FICHA(string DNI)
        {
            return CASOS_DE_USO.FICHA.GESTION_FICHA.OBTENER_FICHA(DNI, oCONTEXTO);
        }
        public MODELO.Ficha OBTENER_FICHAxID(int ID)
        {
            return CASOS_DE_USO.FICHA.GESTION_FICHA.OBTENER_FICHAxID(ID, oCONTEXTO);
        }
    }
}
