using MODELO;
using MODELO.CACHE;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmPagos : Form
    {
        //declaro la variables y métodos estáticos para aplicar el patrón singleton
        private static frmPagos instancia;
        public static frmPagos OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmPagos();
            if (instancia.IsDisposed)
                instancia = new frmPagos();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        public Cliente oCLIENTE;
        public CONTROLADORA.CLIENTE cCLIENTE;

        public frmPagos()
        {
            InitializeComponent();
            cCLIENTE = CONTROLADORA.CLIENTE.obtener_instancia();

            COMBO_CLIENTES();
        }
        // Cargar combo Clientes
        private void COMBO_CLIENTES()
        {
            // Vaciar la lista cada vez que quiero armar una nueva
            cmbPagosCliente.Items.Clear();

            // Pedir al CONTEXTO la lista de CLIENTES y asignarla como arreglo
            cmbPagosCliente.Items.AddRange(cCLIENTE.OBTENER_CLIENTES().ToArray());
            cmbPagosCliente.Items.Insert(0, new Cliente { });
            cmbPagosCliente.DisplayMember = "Apellido" + ", " + "Nombre";
            cmbPagosCliente.ValueMember = "ClienteId";
        }

        void LIMPIAR()
        {
            txtClienteBuscarCliente.Text = null;
            txtPagosFechaProximoPago.Text = null;
            txtPagosFechaUltimoPago.Text = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbPagosCliente.Items.Clear();

            var cliente = cCLIENTE.OBTENER_CLIENTE(txtClienteBuscarCliente.Text);

            cmbPagosCliente.Items.Add(cCLIENTE.OBTENER_CLIENTE(txtClienteBuscarCliente.Text));
            cmbPagosCliente.Items.Insert(0, new Cliente { });
            cmbPagosCliente.DisplayMember = "Apellido" + ", " + "Nombre";
            cmbPagosCliente.ValueMember = "ClienteId";

            if (cliente != null)
            {
                if (!string.IsNullOrEmpty(txtPagosFechaUltimoPago.Text))
                {
                    if (DateTime.TryParse(txtPagosFechaUltimoPago.Text, out DateTime ultimoPago))
                    {
                        // Calcular la fecha del mes próximo
                        DateTime proximoMes = ultimoPago.AddMonths(1);

                        // Mostrar la fecha del próximo mes en el TextBox
                        txtPagosFechaProximoPago.Text = proximoMes.ToShortDateString();
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha no válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente aùn no registra pagos.");
                }
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            // Obtener el cliente seleccionado
            Cliente cliente = (Cliente)cmbPagosCliente.SelectedItem;

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Today;

            // Establecer la fecha del último pago del cliente como la fecha actual
            cliente.ultimoPago = fechaActual;

            // Actualizar el TextBox con la fecha del último pago
            txtPagosFechaUltimoPago.Text = fechaActual.ToShortDateString();

            // Modificar el cliente en la base de datos
            cCLIENTE.MODIFICAR_CLIENTE(cliente);

            // Mostrar un mensaje de confirmación
            MessageBox.Show("El pago se ha guardado exitosamente.");

            // Limpiar los controles
            LIMPIAR();

            // Calcular y mostrar la fecha del próximo pago
            DateTime proximoPago = fechaActual.AddMonths(1);
            txtPagosFechaProximoPago.Text = proximoPago.ToShortDateString();
        }


        private void btnPagosSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Today;

            // Mostrar la fecha actual en el TextBox
            txtPagosFechaUltimoPago.Text = fechaActual.ToShortDateString();
        }
    }
}
