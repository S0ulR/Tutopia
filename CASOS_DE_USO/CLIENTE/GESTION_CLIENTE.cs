namespace CASOS_DE_USO.CLIENTE
{
    public class GESTION_CLIENTE
    {
        public static MODELO.Cliente OBTENER_CLIENTE(string DNI, CONTEXTO.TUTOPIA TUTOPIA)
        {
            try
            {
                var cliente = TUTOPIA.oCliente.FirstOrDefault(c => c.DNI == DNI);
                if (cliente == null)
                {
                    throw new Exception("Cliente no encontrado para el DNI: " + DNI);
                }
                return cliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el cliente: " + ex.Message);
                return null;
            }
        }

        public static List<MODELO.Cliente> OBTENER_CLIENTES(CONTEXTO.TUTOPIA TUTOPIA)
        {
            return TUTOPIA.oCliente.ToList();
        }
    }
}
