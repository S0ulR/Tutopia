namespace CASOS_DE_USO.CLIENTE
{
    public class OPERACIONES_CLIENTE
    {
        public static void AGREGAR_CLIENTE(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Cliente CLIENTE)
        {
            TUTOPIA.oCliente.Add(CLIENTE);
        }
        public static void ELIMINAR_CLIENTE(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Cliente CLIENTE)
        {
            TUTOPIA.oCliente.Remove(CLIENTE);
        }
        public static void MODIFICAR_CLIENTE(CONTEXTO.TUTOPIA TUTOPIA, MODELO.Cliente CLIENTE)
        {
            TUTOPIA.Entry(CLIENTE).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
