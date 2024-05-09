using MODELO;
using MODELO.CACHE;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace VISTA
{
    public partial class frmNuevoCliente : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmNuevoCliente instancia;
        public static frmNuevoCliente OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmNuevoCliente();
            if (instancia.IsDisposed)
                instancia = new frmNuevoCliente();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo

        public Cliente oCLIENTE;
        public CONTROLADORA.CLIENTE cCLIENTE;

        public frmNuevoCliente()
        {
            InitializeComponent();
            cCLIENTE = CONTROLADORA.CLIENTE.obtener_instancia();

            ARMA_GRILLA();
        }
        void LIMPIAR()
        {
            txtNuevoClienteBuscarCliente.Text = null;
            txtNuevoClienteApellido.Text = null;
            txtNuevoClienteCorreo.Text = null;
            txtNuevoClienteDNI.Text = null;
            txtNuevoClienteDomicilio.Text = null;
            txtNuevoClienteNombre.Text = null;
            txtNuevoClienteTelefono.Text = null;
            dtpNuevoClienteFec_Nac.Text = null;
            txtNuevoClienteImagen.Text = null;
        }
        private void ARMA_GRILLA()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = cCLIENTE.OBTENER_CLIENTES();

            //oculto las columnas que no quiero que se vean
            dgvCliente.Columns["ClienteId"].Visible = false;
            dgvCliente.Columns["Turnos"].Visible = false;
            dgvCliente.Columns["Ficha"].Visible = false;
            dgvCliente.Columns["HorarioClientes"].Visible = false;
            dgvCliente.Columns["Imagen"].Visible = false;
        }
        private void btnClienteBuscar_Click(object sender, EventArgs e)
        {
            if (txtNuevoClienteBuscarCliente.Text != "")
            {
                Cliente oCliente = new Cliente();
                oCliente = cCLIENTE.OBTENER_CLIENTE(txtNuevoClienteBuscarCliente.Text);
                if (oCliente != null)
                {
                    txtNuevoClienteNombre.Text = oCliente.Nombre;
                    txtNuevoClienteApellido.Text = oCliente.Apellido;
                    txtNuevoClienteCorreo.Text = oCliente.Correo;
                    txtNuevoClienteDNI.Text = oCliente.DNI.ToString();
                    txtNuevoClienteDomicilio.Text = oCliente.Domicilio;
                    txtNuevoClienteTelefono.Text = oCliente.Telefono.ToString();
                    dtpNuevoClienteFec_Nac.Text = oCliente.Fecha_Nac.ToString();
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no pertenece a un cliente activo");
                }
            }
            else MessageBox.Show("Debe ingresar un número de DNI");
        }

        private void btnNuevoClienteGuardar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            if (string.IsNullOrWhiteSpace(txtNuevoClienteCorreo.Text))
            {
                MessageBox.Show("Debe ingresar un correo electrónico");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevoClienteNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevoClienteApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido");
                return;
            }
            DateTime fecha;
            if (!DateTime.TryParse(dtpNuevoClienteFec_Nac.Text, out fecha))
            {
                MessageBox.Show("Debe seleccionar una fecha de nacimiento");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevoClienteDNI.Text))
            {
                MessageBox.Show("Debe ingresar un número de DNI");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevoClienteDomicilio.Text))
            {
                MessageBox.Show("Debe ingresar una dirección");
                return;
            }
            long tel;
            if (!long.TryParse(txtNuevoClienteTelefono.Text, out tel))
            {
                MessageBox.Show("Debe ingresar un número telefónico");
                return;
            }
            #endregion

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }
            Cliente oCliente = new Cliente();

            //Asigno los valores a los atributos del objeto
            oCliente.Nombre = txtNuevoClienteNombre.Text;
            oCliente.Apellido = txtNuevoClienteApellido.Text;
            oCliente.Fecha_Nac = Convert.ToDateTime(dtpNuevoClienteFec_Nac.Value.ToString("dd/MM/yyyy"));
            oCliente.Correo = txtNuevoClienteCorreo.Text;
            oCliente.Imagen = file;
            oCliente.DNI = txtNuevoClienteDNI.Text;
            oCliente.Domicilio = txtNuevoClienteDomicilio.Text;
            oCliente.Edad = oCliente.Calcular_Edad();
            oCliente.Telefono = tel;
            cCLIENTE.AGREGAR_CLIENTE(oCliente);
            MessageBox.Show("El cliente se ha guardado exitosamente.");
            ARMA_GRILLA();
            LIMPIAR();
        }

        private void btnNuevoClienteModificar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
            cCLIENTE.MODIFICAR_CLIENTE(oCLIENTE);
            ARMA_GRILLA();
            LIMPIAR();
        }

        private void btnNuevoClienteEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista");
                return;
            }
            oCLIENTE = (Cliente)dgvCliente.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el cliente " + oCLIENTE.Apellido + ", " + oCLIENTE.Nombre + " del Instituto?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cCLIENTE.ELIMINAR_CLIENTE(oCLIENTE);
                ARMA_GRILLA();
                LIMPIAR();
            }
        }

        private void btnNuevoClienteFicha_Click(object sender, EventArgs e)
        {
            frmFicha formFicha = new frmFicha();
            formFicha.lblFichaCliente.Text = txtNuevoClienteApellido.Text + ", " + txtNuevoClienteNombre.Text;
            formFicha.lblFichaClienteDNI.Text = txtNuevoClienteDNI.Text;
            formFicha.Show();
            this.Close();
        }

        private void btnNuevoClienteSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCliente.Rows[e.RowIndex];

                // Verificar si el valor de la celda no es nulo antes de llamar a ToString()
                string campo1 = row.Cells["Nombre"].Value?.ToString();
                string campo2 = row.Cells["Apellido"].Value?.ToString();
                string campo3 = row.Cells["DNI"].Value?.ToString();
                string campo4 = row.Cells["Domicilio"].Value?.ToString();
                long campo5 = row.Cells["Telefono"].Value != null ? Convert.ToInt64(row.Cells["Telefono"].Value) : 0; // Puedes establecer un valor predeterminado en caso de que sea nulo
                string campo6 = row.Cells["Correo"].Value?.ToString();

                // Convertir el valor de la celda "Fecha_Nac" a DateTime
                DateTime campo7 = Convert.ToDateTime(row.Cells["Fecha_Nac"].Value);

                // Asignar valores a los controles del formulario
                txtNuevoClienteNombre.Text = campo1;
                txtNuevoClienteApellido.Text = campo2;
                txtNuevoClienteDNI.Text = campo3;
                txtNuevoClienteDomicilio.Text = campo4;
                txtNuevoClienteTelefono.Text = campo5.ToString(); // Convertir a cadena para asignarlo al control TextBox
                txtNuevoClienteCorreo.Text = campo6;
                dtpNuevoClienteFec_Nac.Value = campo7; // Asignar directamente el valor de campo7 al control DateTimePicker

                // Obtener la imagen del registro seleccionado y mostrarla en un PictureBox
                byte[] imagenBytes = (byte[])row.Cells["Imagen"].Value;
                if (imagenBytes != null && imagenBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        // Asignar la imagen al PictureBox y ajustar su tamaño automáticamente
                        pbNuevoClienteImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbNuevoClienteImagen.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no hay imagen, puedes mostrar una imagen predeterminada o dejar el PictureBox vacío
                    pbNuevoClienteImagen.Image = null;
                }

                var oCliente = cCLIENTE.OBTENER_CLIENTE(campo3);
                ClienteCache.Nombre = oCliente.Nombre;
                ClienteCache.Apellido = oCliente.Apellido;
                ClienteCache.DNI = oCliente.DNI;
                ClienteCache.ClienteID = oCliente.ClienteId;
                ClienteCache.Correo = oCliente.Correo;
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

        private void btnNuevoClienteExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNuevoClienteImagen.Text = openFileDialog1.FileName;
            }
        }
    }
}