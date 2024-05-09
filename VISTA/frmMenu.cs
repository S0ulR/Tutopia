namespace VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenuAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda formAgenda = new frmAgenda();
            formAgenda.Show();
        }

        private void btnMenuSocios_Click(object sender, EventArgs e)
        {
            frmGestionSocios formGestionSocios = new frmGestionSocios();
            formGestionSocios.Show();
        }

        private void btnMenuClase_Click(object sender, EventArgs e)
        {

        }
        private void btnMenuPago_Click(object sender, EventArgs e)
        {
            frmPagos formPagos = new frmPagos();
            formPagos.Show();
        }
        private void btnMenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
