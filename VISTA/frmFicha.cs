using MODELO;
using MODELO.CACHE;

namespace VISTA
{
    public partial class frmFicha : Form
    {
        #region "Variables y métodos estáticos para aplicar el patrón singleton"
        private static frmFicha instancia;
        public static frmFicha OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmFicha();
            if (instancia.IsDisposed)
                instancia = new frmFicha();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        public Cliente oCLIENTE;
        public CONTROLADORA.CLIENTE cCLIENTE;

        public Ficha oFICHA;
        public CONTROLADORA.FICHA cFICHA;

        public Multimedia oMULTIMEDIA;
        public CONTROLADORA.MULTIMEDIA cMULTIMEDIA;

        public frmFicha()
        {
            InitializeComponent();
            cCLIENTE = CONTROLADORA.CLIENTE.obtener_instancia();
            cFICHA = CONTROLADORA.FICHA.obtener_instancia();
            cMULTIMEDIA = CONTROLADORA.MULTIMEDIA.obtener_instancia();

            ARMA_GRILLA_DETALLES();
        }
        #endregion

        #region "Métodos para limpiar/llenar los Grid"
        void LIMPIAR()
        {
            txtFichaAfecciones.Text = null;
            txtFichaAlergia.Text = null;
            txtFichaAltura.Text = null;
            txtFichaCirugiaCuales.Text = null;
            txtFichaNotas.Text = null;
            txtFichaPeso.Text = null;
            txtFichaTipoSangre.Text = null;
            cbAlergicoSi.Checked = false;
            cbAlergicoNo.Checked = false;
            rbFichaCirugiaNo.Checked = true;
            cbPresionSi.Checked = false;
            cbPresionNo.Checked = false;
            rbFichaFactorPositivo.Checked = true;
        }
        private void ARMA_GRILLA_DETALLES()
        {
            dgvFichas.DataSource = null;
            dgvFichas.DataSource = cFICHA.OBTENER_FICHAS();

            dgvFichas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region "ABM´s de Ficha"
        private void btnFichaGuardar_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            if (string.IsNullOrWhiteSpace(txtFichaAfecciones.Text))
            {
                MessageBox.Show("Debe ingresar un diagnóstico o afección.");
                return;
            }
            #endregion

            Ficha oFicha = new Ficha();
            // Asigno los valores a los atributos del objeto
            string DNI = lblFichaClienteDNI.Text;
            oCLIENTE = cCLIENTE.OBTENER_CLIENTE(DNI);
            oFicha.ClienteId = oCLIENTE.ClienteId; // Asignar el ClienteId en lugar del objeto Cliente
            oFicha.Afeccion = txtFichaAfecciones.Text;
            oFicha.Nota = txtFichaNotas.Text;
            if (rbFichaCirugiaSi.Checked == true)
            {
                oFicha.Cirugia = true;
                oFicha.CirugiaNombre = txtFichaCirugiaCuales.Text;
            }
            else { oFicha.Cirugia = false; }
            if (cbAlergicoSi.Checked == true)
            {
                oFicha.Alergia = true;
                oFicha.AlergiaTipo = txtFichaAlergia.Text;
            }
            else { oFicha.Alergia = false; }
            oFicha.Peso = Convert.ToDouble(txtFichaPeso.Text);
            oFicha.Altura = Convert.ToDouble(txtFichaAltura.Text);
            oFicha.Sangre = txtFichaTipoSangre.Text;
            if (rbFichaFactorPositivo.Checked == true)
            {
                oFicha.Tipo = "Positivo";
            }
            else { oFicha.Tipo = "Negativo"; }
            if (cbPresionSi.Checked == true)
            {
                oFicha.Presion = true;
            }
            else { oFicha.Presion = false; }
            cFICHA.AGREGAR_FICHA(oFicha);
            MessageBox.Show("La ficha del paciente " + oCLIENTE.Nombre + " " + oCLIENTE.Apellido + " se ha guardado exitosamente.");

            ARMA_GRILLA_DETALLES();
            LIMPIAR();
        }


        private void btnFichaModificar_Click(object sender, EventArgs e)
        {
            if (dgvFichas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ficha de la lista.");
                return;
            }
            oFICHA = (Ficha)dgvFichas.CurrentRow.DataBoundItem;
            cFICHA.MODIFICAR_FICHA(oFICHA);
            MessageBox.Show("La ficha se ha modificado exitosamente.");
            ARMA_GRILLA_DETALLES();
            LIMPIAR();
        }

        private void btnFichaEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFichas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una ficha de la lista.");
                return;
            }
            oFICHA = (Ficha)dgvFichas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la ficha " + oFICHA.Afeccion + " del Cliente" + oFICHA.Cliente.Apellido + ", " + oFICHA.Cliente.Nombre + "?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cFICHA.ELIMINAR_FICHA(oFICHA);
                MessageBox.Show("La ficha se ha eliminado correctamente.");
                ARMA_GRILLA_DETALLES();
                LIMPIAR();
            }
        }
        #endregion

        #region "Método para obtener los datos de la celda elegida en el Grid"
        private void dgvFichas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFichas.Rows[e.RowIndex];

            // Obtener los datos del registro seleccionado
            string campo1 = row.Cells["Afeccion"].Value != null ? row.Cells["Afeccion"].Value.ToString() : string.Empty;
            string campo2 = row.Cells["Nota"].Value != null ? row.Cells["Nota"].Value.ToString() : string.Empty;
            bool campo3 = row.Cells["Cirugia"].Value != null && Convert.ToBoolean(row.Cells["Cirugia"].Value);
            string campo4 = row.Cells["CirugiaNombre"].Value != null ? row.Cells["CirugiaNombre"].Value.ToString() : string.Empty;
            bool campo5 = row.Cells["Alergia"].Value != null && Convert.ToBoolean(row.Cells["Alergia"].Value);
            string campo6 = row.Cells["AlergiaTipo"].Value != null ? row.Cells["AlergiaTipo"].Value.ToString() : string.Empty;
            double campo7 = row.Cells["Altura"].Value != null ? Convert.ToDouble(row.Cells["Altura"].Value) : 0.0;
            double campo8 = row.Cells["Peso"].Value != null ? Convert.ToDouble(row.Cells["Peso"].Value) : 0.0;
            string campo9 = row.Cells["Sangre"].Value != null ? row.Cells["Sangre"].Value.ToString() : string.Empty;
            string campo10 = row.Cells["Tipo"].Value != null ? row.Cells["Tipo"].Value.ToString() : string.Empty;
            bool campo11 = row.Cells["Presion"].Value != null && Convert.ToBoolean(row.Cells["Presion"].Value);

            txtFichaAfecciones.Text = campo1;
            txtFichaNotas.Text = campo2;
            rbFichaCirugiaSi.Checked = campo3;
            rbFichaCirugiaNo.Checked = !campo3;
            txtFichaCirugiaCuales.Text = campo4;
            cbAlergicoSi.Checked = campo5;
            cbAlergicoNo.Checked = !campo5;
            txtFichaAlergia.Text = campo6;
            txtFichaAltura.Text = campo7.ToString();
            txtFichaPeso.Text = campo8.ToString();
            txtFichaTipoSangre.Text = campo9;
            rbFichaFactorPositivo.Checked = campo10 == "Positivo";
            rbFichaFactorNegativo.Checked = campo10 != "Positivo";
            cbPresionSi.Checked = campo11;
            cbPresionNo.Checked = !campo11;

            var oFicha = cFICHA.OBTENER_FICHA(lblFichaClienteDNI.Text);
            FichaCache.FichaID = oFicha.FichaId;
            FichaCache.Afeccion = oFicha?.Afeccion;
        }
        #endregion


        private void btnFichaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente();
            frmNuevoCliente.Show();
        }

        private void btnCargaFichasxDNI_Click(object sender, EventArgs e)
        {
            dgvFichas.DataSource = null;
            dgvFichas.DataSource = cFICHA.OBTENER_FICHASxDNI(ClienteCache.DNI);

            dgvFichas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFichaVerEstudios_Click(object sender, EventArgs e)
        {
            frmEstudios formEstudios = new frmEstudios();
            formEstudios.Show();
            this.Close();
        }

    }
}