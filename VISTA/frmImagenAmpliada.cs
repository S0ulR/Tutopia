namespace VISTA
{
    public partial class frmImagenAmpliada : Form
    {
        public frmImagenAmpliada()
        {
            InitializeComponent();
        }
        public void MostrarImagen(byte[] imagenBytes)
        {
            // Convierte el array de bytes a una imagen
            Image imagen = ByteArrayToImage(imagenBytes);

            if (imagen != null)
            {
                // Muestra la imagen en el PictureBox
                pbImagenAmpliada.Image = imagen;
            }
            else
            {
                MessageBox.Show("Error al cargar la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            // Convierte un array de bytes en una imagen
            try
            {
                Image imagen;
                using (var ms = new System.IO.MemoryStream(byteArray))
                {
                    imagen = Image.FromStream(ms);
                }
                return imagen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir el array de bytes a imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void btnImagenAmpliadaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEstudios formEstudios = new frmEstudios();
            formEstudios.Show();
        }
    }
}
