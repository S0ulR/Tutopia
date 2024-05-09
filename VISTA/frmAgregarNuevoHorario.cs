using CONTROLADORA;
using MODELO;
using System.Globalization;

namespace VISTA
{
    public partial class frmAgregarNuevoHorario : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmAgregarNuevoHorario instancia;
        public static frmAgregarNuevoHorario OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmAgregarNuevoHorario();
            if (instancia.IsDisposed)
                instancia = new frmAgregarNuevoHorario();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        public Dia oDIA;
        public CONTROLADORA.DIA cDIA;

        public Horario oHORARIO;
        public CONTROLADORA.HORARIO cHORARIO;

        public frmAgregarNuevoHorario()
        {
            InitializeComponent();
            cDIA = CONTROLADORA.DIA.obtener_instancia();
            cHORARIO = CONTROLADORA.HORARIO.obtener_instancia();

            COMBO_DIAS();
        }

        private void COMBO_DIAS()
        {
            // Vaciar la lista cada vez que quiero armar una nueva
            cmbDia.Items.Clear();

            // Pedir al CONTEXTO la lista de DIAS y asignarla como arreglo
            cmbDia.Items.AddRange(cDIA.OBTENER_DIAS().ToArray());
            cmbDia.Items.Insert(0, new Dia { });
            cmbDia.DisplayMember = "Nombre";
            cmbDia.ValueMember = "DiaId";
        }
        void LIMPIAR()
        {
            txtNuevoHorarioHora.Text = string.Empty;
        }
        void ARMA_GRILLA()
        {

        }
        private void btnAgendaNuevoHorarioGuardar_Click(object sender, EventArgs e)
        {
            Horario oHorario = new Horario();

            //Asigno los valores a los atributos del objeto
            oHorario.Cupo = Convert.ToInt32(txtNuevoHorarioCupos.Text);

            // Verificar si se seleccionó un elemento en el ComboBox
            if (cmbDia.SelectedItem != null)
            {
                // Obtener el objeto Dia seleccionado
                Dia diaSeleccionado = (Dia)cmbDia.SelectedItem;

                // Asignar el nombre del día al Horario
                oHorario.Dia = diaSeleccionado.Nombre;

                // Convertir el texto a TimeSpan
                TimeSpan hora;
                string horaString = txtNuevoHorarioHora.Text.Trim(); // Eliminar espacios en blanco adicionales

                // Intentar analizar la hora en varios formatos
                if (TimeSpan.TryParse(horaString, out hora))
                {
                    oHorario.Hora = hora;
                    cHORARIO.AGREGAR_HORARIO(oHorario);
                    MessageBox.Show("El nuevo horario se ha guardado exitosamente.");
                    ARMA_GRILLA();
                    LIMPIAR();

                    // Obtener el nombre del día seleccionado
                    string nombreDia = cmbDia.Text;

                    // Agregar el horario al día seleccionado
                    cDIA.AgregarHorariosAlDia(nombreDia, oHorario);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una hora válida");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un día.");
            }
        }

        private void btnNuevoHorarioSalir_Click(object sender, EventArgs e)
        {
            frmAgenda formAgenda = new frmAgenda();
            formAgenda.Show();
            this.Close();
        }
    }
}
