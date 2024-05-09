using CONTROLADORA;
using MODELO;
using MODELO.CACHE;

namespace VISTA
{
    public partial class frmNuevoDia : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmNuevoDia instancia;
        public static frmNuevoDia OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmNuevoDia();
            if (instancia.IsDisposed)
                instancia = new frmNuevoDia();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo

        public Dia oDIA;
        public CONTROLADORA.DIA cDIA;

        public frmNuevoDia()
        {
            InitializeComponent();
            cDIA = CONTROLADORA.DIA.obtener_instancia();

            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvDia.DataSource = null;
            dgvDia.DataSource = cDIA.OBTENER_DIAS();

            // Ocultar las columnas que no quieres que se vea
            dgvDia.Columns["DiaId"].Visible = false;
            dgvDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LIMPIAR()
        {
            txtNuevoDiaNombre.Text = null;
        }
        private void btnNuevoDiaGuardar_Click(object sender, EventArgs e)
        {
            Dia oDia = new Dia();

            //Asigno los valores a los atributos del objeto
            oDia.Nombre = txtNuevoDiaNombre.Text;
            cDIA.AGREGAR_DIA(oDia);
            MessageBox.Show("El día se ha guardado exitosamente.");
            ARMA_GRILLA();
            LIMPIAR();
        }

        private void btnNuevoDiaEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDia.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un día de la lista");
                return;
            }
            oDIA = (Dia)dgvDia.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el día " + oDIA.Nombre + " del Instituto?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cDIA.ELIMINAR_DIA(oDIA);
                ARMA_GRILLA();
                LIMPIAR();
            }
        }

        private void btnGestionDiaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}