using MODELO;
using MODELO.CACHE;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmGestionSocios : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmGestionSocios instancia;
        public static frmGestionSocios OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmGestionSocios();
            if (instancia.IsDisposed)
                instancia = new frmGestionSocios();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo

        public Turno oTURNO;
        public CONTROLADORA.TURNO cTURNO;

        public Cliente oCLIENTE;
        public CONTROLADORA.CLIENTE cCLIENTE;

        public frmGestionSocios()
        {
            InitializeComponent();
            cTURNO = CONTROLADORA.TURNO.obtener_instancia();
            cCLIENTE = CONTROLADORA.CLIENTE.obtener_instancia();

            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvGestionSocios.DataSource = null;
            dgvGestionSocios.DataSource = cCLIENTE.OBTENER_CLIENTES();

            // Ocultar las columnas que no quieres que se vean
            dgvGestionSocios.Columns["ClienteId"].Visible = false;
            dgvGestionSocios.Columns["DNI"].Visible = false;
            dgvGestionSocios.Columns["Domicilio"].Visible = false;
            dgvGestionSocios.Columns["Imagen"].Visible = false;
            dgvGestionSocios.Columns["Fecha_Nac"].Visible = false;
            dgvGestionSocios.Columns["Fecha_Ingreso"].Visible = false;
            dgvGestionSocios.Columns["ultimoPago"].Visible = false;
            dgvGestionSocios.Columns["Correo"].Visible = false;
            dgvGestionSocios.Columns["Edad"].Visible = false;
            dgvGestionSocios.Columns["Activo"].Visible = false;
            dgvGestionSocios.Columns["Telefono"].Visible = false;
            dgvGestionSocios.Columns["Deudor"].Visible = false;
            dgvGestionSocios.Columns["Turnos"].Visible = false;
            dgvGestionSocios.Columns["Ficha"].Visible = false;
            dgvGestionSocios.Columns["HorarioClientes"].Visible = false;
            dgvGestionSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LIMPIAR()
        {
            txtClienteApellido.Text = null;
            txtClienteBuscarCliente.Text = null;
            txtClienteCorreo.Text = null;
            txtClienteDNI.Text = null;
            txtClienteDomicilio.Text = null;
            txtClienteFechaInsc.Text = null;
            txtClienteNombre.Text = null;
            txtClienteProximoPago.Text = null;
            txtClienteTelefono.Text = null;
            rbClienteDeudorNo.Checked = true;
            rbClienteDeudorSi.Checked = false;
            pbClienteImagen.Image = null;
        }

        private void dgvGestionSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LIMPIAR();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGestionSocios.Rows[e.RowIndex];

                // Obtener los datos del DataGridView
                string campo1 = row.Cells["Nombre"].Value?.ToString();
                string campo2 = row.Cells["Apellido"].Value?.ToString();
                string campo3 = row.Cells["DNI"].Value?.ToString();
                string campo4 = row.Cells["Domicilio"].Value?.ToString();
                long campo5 = row.Cells["Telefono"].Value != null ? Convert.ToInt64(row.Cells["Telefono"].Value) : 0;
                string campo6 = row.Cells["Correo"].Value?.ToString();
                DateTime campo7 = Convert.ToDateTime(row.Cells["Fecha_Nac"].Value);
                int campo8 = row.Cells["Edad"].Value != null ? Convert.ToInt32(row.Cells["Edad"].Value) : 0;
                DateTime campo9 = Convert.ToDateTime(row.Cells["Fecha_Ingreso"].Value);
                DateTime? campo10 = row.Cells["ultimoPago"].Value != null ? Convert.ToDateTime(row.Cells["ultimoPago"].Value) : (DateTime?)null;

                // Asignar valores a los controles del formulario
                txtClienteNombre.Text = campo1;
                txtClienteApellido.Text = campo2;
                txtClienteDNI.Text = campo3;
                txtClienteDomicilio.Text = campo4;
                txtClienteTelefono.Text = campo5.ToString();
                txtClienteCorreo.Text = campo6;
                dtpClienteFec_Nac.Value = campo7;
                txtClienteEdad.Text = campo8.ToString();
                txtClienteFechaInsc.Text = campo9.ToShortDateString();

                // Calcular la fecha del próximo pago
                DateTime? proximoPago = CalcularProximoPago(campo10);
                if (proximoPago.HasValue)
                {
                    txtClienteProximoPago.Text = proximoPago.Value.ToShortDateString();
                }
                else
                {
                    txtClienteProximoPago.Text = "No hay fecha de último pago";
                }

                // Obtener la imagen del registro seleccionado y mostrarla en un PictureBox
                byte[] imagenBytes = (byte[])row.Cells["Imagen"].Value;
                if (imagenBytes != null && imagenBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        // Asignar la imagen al PictureBox y ajustar su tamaño automáticamente
                        pbClienteImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbClienteImagen.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no hay imagen, puedes mostrar una imagen predeterminada o dejar el PictureBox vacío
                    pbClienteImagen.Image = null;
                }
            }
        }

        private DateTime? CalcularProximoPago(DateTime? ultimoPago)
        {
            if (ultimoPago.HasValue)
            {
                // Obtener el primer día del mes siguiente al último pago
                DateTime proximoPago = ultimoPago.Value.AddMonths(1);
                proximoPago = new DateTime(proximoPago.Year, proximoPago.Month, 1);
                return proximoPago;
            }
            else
            {
                // Si no hay fecha de último pago, retorna null
                return null;
            }
        }


        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            frmNuevoCliente formNuevoCliente = new frmNuevoCliente();
            formNuevoCliente.Show();
        }

        private void btnGestionSociosSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClienteBuscarCliente.Text))
            {
                LIMPIAR();
                Cliente oCliente = cCLIENTE.OBTENER_CLIENTE(txtClienteBuscarCliente.Text);
                if (oCliente != null)
                {
                    txtClienteNombre.Text = oCliente.Nombre;
                    txtClienteApellido.Text = oCliente.Apellido;
                    txtClienteCorreo.Text = oCliente.Correo;
                    txtClienteDNI.Text = oCliente.DNI;
                    txtClienteDomicilio.Text = oCliente.Domicilio;
                    txtClienteTelefono.Text = oCliente.Telefono.ToString();
                    dtpClienteFec_Nac.Value = oCliente.Fecha_Nac; // Asignar la fecha de nacimiento al DateTimePicker
                    pbClienteImagen.Image = ByteArrayToImage(oCliente.Imagen); // Cargar la imagen en el PictureBox
                    txtClienteFechaInsc.Text = oCliente.Fecha_Ingreso.ToString();
                    txtClienteEdad.Text = oCliente.Edad.ToString();

                    if (oCliente.Deudor == true)
                    {
                        rbClienteDeudorSi.Checked = true;
                        rbClienteDeudorNo.Checked = false;
                        MessageBox.Show("El cliente " + oCliente.Apellido + ", " + oCliente.Nombre + " debe la cuota");
                    }
                    else
                    {
                        rbClienteDeudorSi.Checked = false;
                        rbClienteDeudorNo.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no pertenece a un cliente activo");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de DNI");
            }
        }

        // Método para convertir un array de bytes a una imagen
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
            }
            else
            {
                return null;
            }
        }

        private void btnNuevoClienteFicha_Click(object sender, EventArgs e)
        {
            frmFicha formFicha = new frmFicha();
            if(string.IsNullOrWhiteSpace(txtClienteDNI.Text))
            {
                formFicha.Show();
            }
            else
            {
                Cliente oCLIENTE = cCLIENTE.OBTENER_CLIENTE(txtClienteDNI.Text);
                formFicha.lblFichaCliente.Text = oCLIENTE.Apellido + ", " + oCLIENTE.Nombre;
                formFicha.lblFichaClienteDNI.Text = oCLIENTE.DNI.ToString();
                formFicha.Show();
            }

        }
    }
}
