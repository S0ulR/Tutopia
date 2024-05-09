using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.CACHE
{
    public static class ClienteCache
    {
        public static int ClienteID { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string DNI { get; set; }
        public static string Correo { get; set; }
        public static bool Deudor { get; set; }
    }
}
