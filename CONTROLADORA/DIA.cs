using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class DIA
    {
        private static DIA instancia;
        public static DIA obtener_instancia()
        {
            if (instancia == null)
                instancia = new DIA();
            return instancia;
        }

        CONTEXTO.TUTOPIA oCONTEXTO;
        private DIA()
        {
            oCONTEXTO = CONTEXTO.TUTOPIA.obtener_instancia();
        }
        public void AGREGAR_DIA(MODELO.Dia DIA)
        {
            CASOS_DE_USO.DIA.OPERACIONES_DIA.AGREGAR_DIA(oCONTEXTO, DIA);
            // la función SaveChanges del contexto guarda los datos en la base de datos.
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_DIA(MODELO.Dia DIA)
        {
            CASOS_DE_USO.DIA.OPERACIONES_DIA.MODIFICAR_DIA(oCONTEXTO, DIA);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_DIA(MODELO.Dia DIA)
        {
            CASOS_DE_USO.DIA.OPERACIONES_DIA.ELIMINAR_DIA(oCONTEXTO, DIA);
            oCONTEXTO.SaveChanges();
        }
        public MODELO.Dia OBTENER_DIA(string DIA)
        {
            return CASOS_DE_USO.DIA.GESTION_DIA.OBTENER_DIA(DIA, oCONTEXTO);
        }
        public List<MODELO.Dia> OBTENER_DIAS()
        {
            return CASOS_DE_USO.DIA.GESTION_DIA.OBTENER_DIAS(oCONTEXTO);
        }
        public void AgregarHorariosAlDia(string NombreDia, Horario Hora)
        {
            CASOS_DE_USO.DIA.OPERACIONES_DIA.AgregarHorarioAlDia(oCONTEXTO, NombreDia, Hora);
            oCONTEXTO.SaveChanges();
        }
    }
}