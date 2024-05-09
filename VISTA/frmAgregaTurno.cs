using MODELO;
using MODELO.CACHE;
using System.Diagnostics;
using System.Globalization;

namespace VISTA
{
    public partial class frmAgregaTurno : Form
    {
        // Declaración de variables y métodos estáticos
        private static frmAgregaTurno instancia;
        public static frmAgregaTurno OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmAgregaTurno();
            if (instancia.IsDisposed)
                instancia = new frmAgregaTurno();

            return instancia;
        }

        // Variables temporales para crear los objetos del modelo
        private CONTROLADORA.TURNO cTURNO;
        private MODELO.Turno oTURNO;

        public MODELO.Cliente oCLIENTE;
        public CONTROLADORA.CLIENTE cCLIENTE;

        public MODELO.Dia oDIA;
        public CONTROLADORA.DIA cDIA;

        public MODELO.Horario oHORARIO;
        public CONTROLADORA.HORARIO cHORARIO;



        public frmAgregaTurno()
        {
            InitializeComponent();
            cTURNO = CONTROLADORA.TURNO.obtener_instancia();
            cCLIENTE = CONTROLADORA.CLIENTE.obtener_instancia();
            cDIA = CONTROLADORA.DIA.obtener_instancia();
            cHORARIO = CONTROLADORA.HORARIO.obtener_instancia();

            COMBO_CLIENTES();
            CargarDiasSemana();
        }

        void LIMPIAR()
        {
            txtAgendaBuscarCliente.Text = null;
        }


        private void CargarDiasSemana()
        {
            // Vaciar la lista cada vez que quiero armar una nueva
            clbAgendaDias.Items.Clear();

            // Pedir al CONTEXTO la lista de DIA y asignarla como arreglo
            clbAgendaDias.Items.AddRange(cDIA.OBTENER_DIAS().ToArray());
            clbAgendaDias.DisplayMember = "Nombre";
            clbAgendaDias.ValueMember = "DiaId";
        }

        private void COMBO_CLIENTES()
        {
            // Vaciar la lista cada vez que quiero armar una nueva
            cmbAgendaClientes.Items.Clear();

            // Pedir al CONTEXTO la lista de CLIENTES y asignarla como arreglo
            cmbAgendaClientes.Items.AddRange(cCLIENTE.OBTENER_CLIENTES().ToArray());
            cmbAgendaClientes.DisplayMember = "Apellido, Nombre";
            cmbAgendaClientes.ValueMember = "ClienteId";
        }
        private void btnAgendaBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAgendaBuscarCliente.Text))
            {
                string DNI = txtAgendaBuscarCliente.Text;
                var cliente = cCLIENTE.OBTENER_CLIENTE(DNI);
                if (cliente != null)
                {
                    // Vaciar la lista cada vez que quiero armar una nueva
                    cmbAgendaClientes.Items.Clear();

                    // Pedir al CONTEXTO la lista de CLIENTES y asignarla como arreglo
                    cmbAgendaClientes.Items.Add(cliente);
                    cmbAgendaClientes.SelectedItem = cliente;
                    cmbAgendaClientes.DisplayMember = "Apellido" + ", " + "Nombre";
                    cmbAgendaClientes.ValueMember = "ClienteId";
                }
                else
                {
                    MessageBox.Show("No existe un cliente con el DNI ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un DNI para buscar.");
            }

        }

        private void btnAgendaGuardarHorario_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            // Validar ComboBox
            if (cmbAgendaClientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            if (cmbAgendaHorarios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un horario");
                return;
            }
            // Validar CheckedListBox
            if (clbAgendaDias.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un día");
                return;
            }
            #endregion

            Turno oTurno = new Turno();

            // Asignar el Cliente seleccionado al Turno
            oTurno.Cliente = (Cliente)cmbAgendaClientes.SelectedItem;
            // Crear una lista para almacenar los días seleccionados
            List<Dia> diasSeleccionados = new List<Dia>();
            // Iterar sobre los elementos marcados en el CheckedListBox y agregarlos a la lista
            foreach (var item in clbAgendaDias.CheckedItems)
            {
                diasSeleccionados.Add((Dia)item);
            }
            // Asignar la lista de días seleccionados al Turno
            oTurno.Dias = diasSeleccionados;
            // Asignar el Horario seleccionado al Turno
            oTurno.Horario = (Horario)cmbAgendaHorarios.SelectedItem;
            oTurno.Reservado = true;

            // Llamar al método para agregar el turno con los datos completos
            cTURNO.AGREGAR_TURNO(oTurno);

            // Actualizar la propiedad Cupo del horario correspondiente
            Horario horarioSeleccionado = (Horario)cmbAgendaHorarios.SelectedItem;
            horarioSeleccionado.Cupo--;

            if (horarioSeleccionado.Cupo == 0)
            {
                MessageBox.Show("No quedan cupos disponibles para el horario seleccionado");
            }
            else
            {
                MessageBox.Show("El turno se ha asignado exitosamente.");
            }

            LIMPIAR();
        }


        private void btnAgendaModificaHorario_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista");
                return;
            }
            oTURNO = (Turno)dgvAgenda.CurrentRow.DataBoundItem;
            cTURNO.MODIFICAR_TURNO(oTURNO);
            LIMPIAR();
        }

        private void btnAgendaEliminaHorario_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista");
                return;
            }
            oTURNO = (Turno)dgvAgenda.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el turno " + oTURNO.Horario.Hora + " de la base de datos?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cTURNO.ELIMINAR_TURNO(oTURNO);
                LIMPIAR();
            }
        }
        private void btnAgendaTurnosReservadosCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDNITurnosReservadosCliente.Text))
            {
                string DNI = txtDNITurnosReservadosCliente.Text;
                var cliente = cCLIENTE.OBTENER_CLIENTE(DNI);
                if (cliente != null)
                {
                    int ID = cliente.ClienteId;
                    dgvAgenda.DataSource = null;
                    dgvAgenda.DataSource = cTURNO.OBTENER_AGENDAxDIAOCUPADO(ID);
                    // Ocultar la columna que no quiero que se vea

                    dgvAgenda.Columns["HorarioId"].Visible = false;

                    dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No existe un cliente con el DNI ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un DNI para buscar.");
            }
        }

        private void btnAgendaTurnosLibresMostrar_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = cHORARIO.OBTENER_HORARIOS_LIBRES();
            // Ocultar la columna que no quiero que se vea
            dgvAgenda.Columns["HorarioId"].Visible = false;
            dgvAgenda.Columns["HorarioClientes"].Visible = false;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAgendaTraerHorarios_Click(object sender, EventArgs e)
        {
            // Limpiar el ComboBox antes de agregar los nuevos horarios
            cmbAgendaHorarios.Items.Clear();

            // Verificar si se ha seleccionado al menos un día en el CheckedListBox
            if (clbAgendaDias.CheckedItems.Count > 0)
            {
                // Crear una lista para almacenar los horarios disponibles
                List<Horario> horariosDisponibles = new List<Horario>();

                // Iterar sobre los elementos marcados en el CheckedListBox
                foreach (var item in clbAgendaDias.CheckedItems)
                {
                    string diaSeleccionado = item.ToString();

                    // Obtener los horarios para el día seleccionado
                    var horariosDia = cHORARIO.OBTENER_HORARIOxDIA(diaSeleccionado);

                    // Agregar los horarios al listado de horarios disponibles
                    horariosDisponibles.AddRange(horariosDia);
                }

                // Agrega los horarios al ComboBox
                cmbAgendaHorarios.Items.AddRange(horariosDisponibles.ToArray());
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un día en la agenda.");
            }

            cmbAgendaHorarios.DisplayMember = "Hora";
            cmbAgendaHorarios.ValueMember = "HorarioId";
        }
        private void btnAgendaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

