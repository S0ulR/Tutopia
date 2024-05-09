namespace CONTROLADORA
{
    public class CLIENTE
    {
        private static CLIENTE instancia;
        public static CLIENTE obtener_instancia()
        {
            if (instancia == null)
                instancia = new CLIENTE();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private CLIENTE()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_CLIENTE(MODELO.Cliente CLIENTE)
        {
            CASOS_DE_USO.CLIENTE.OPERACIONES_CLIENTE.AGREGAR_CLIENTE(oCONTEXTO, CLIENTE);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_CLIENTE(MODELO.Cliente CLIENTE)
        {
            CASOS_DE_USO.CLIENTE.OPERACIONES_CLIENTE.MODIFICAR_CLIENTE(oCONTEXTO, CLIENTE);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_CLIENTE(MODELO.Cliente CLIENTE)
        {
            CASOS_DE_USO.CLIENTE.OPERACIONES_CLIENTE.ELIMINAR_CLIENTE(oCONTEXTO, CLIENTE);
            oCONTEXTO.SaveChanges();
        }
        public List<MODELO.Cliente> OBTENER_CLIENTES()
        {
            return CASOS_DE_USO.CLIENTE.GESTION_CLIENTE.OBTENER_CLIENTES(oCONTEXTO);
        }
        public MODELO.Cliente OBTENER_CLIENTE(string DNI)
        {
            return CASOS_DE_USO.CLIENTE.GESTION_CLIENTE.OBTENER_CLIENTE(DNI, oCONTEXTO);
        }

    }
}