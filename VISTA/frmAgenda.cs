using MODELO;
using MODELO.CACHE;

namespace VISTA
{
    public partial class frmAgenda : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmAgenda instancia;
        public static frmAgenda OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmAgenda();
            if (instancia.IsDisposed)
                instancia = new frmAgenda();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo

        public Turno oTURNO;
        public CONTROLADORA.TURNO cTURNO;

        public Horario oHORARIO;
        public CONTROLADORA.HORARIO cHORARIO;

        public frmAgenda()
        {
            InitializeComponent();
            cTURNO = CONTROLADORA.TURNO.obtener_instancia();
            cHORARIO = CONTROLADORA.HORARIO.obtener_instancia();

            ARMA_GRILLA();
        }
        private void btnGestionTurnosTodos_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cTURNO.OBTENER_TURNOS();

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["ClienteId"].Visible = false;
            dgvAgenda.Columns["TurnoId"].Visible = false;
            dgvAgenda.Columns["Reservado"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgendaNuevoTurno_Click(object sender, EventArgs e)
        {
            frmAgregaTurno formAgregaTurno = new frmAgregaTurno();
            formAgregaTurno.Show();
        }

        private void btnAgendaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgendaAgregarDia_Click(object sender, EventArgs e)
        {
            frmNuevoDia formNuevoDia = new frmNuevoDia();
            formNuevoDia.Show();
            this.Close();
        }

        private void btnAgendaAgregarHorario_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoHorario formAgregarHorario = new frmAgregarNuevoHorario();
            formAgregarHorario.Show();
            this.Close();
        }

        private void cbAgendaLunes_CheckedChanged(object sender, EventArgs e)
        {
            string diaSeleccionado = "Lunes";
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbAgendaMartes_CheckedChanged(object sender, EventArgs e)
        {
            string diaSeleccionado = "Martes";
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbAgendaMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            string diaSeleccionado = "Miércoles";
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbAgendaJueves_CheckedChanged(object sender, EventArgs e)
        {
            string diaSeleccionado = "Jueves";
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbAgendaViernes_CheckedChanged(object sender, EventArgs e)
        {
            string diaSeleccionado = "Viernes";
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbAgendaSabado_CheckedChanged(object sender, EventArgs e)
        {
            string diaSeleccionado = "Sábado";
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

            // Ocultar las columnas que no quieres que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
