
using MODELO;
using MODELO.CACHE;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace VISTA
{
    public partial class frmEstudios : Form
    {
        #region "Variables y métodos estáticos para aplicar el patrón singleton"
        private static frmEstudios instancia;
        public static frmEstudios OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new frmEstudios();
            if (instancia.IsDisposed)
                instancia = new frmEstudios();

            return instancia;
        }

        //declaro las variables temporales para crear los objetos del modelo
        public Cliente oCLIENTE;
        public CONTROLADORA.CLIENTE cCLIENTE;

        public Ficha oFICHA;
        public CONTROLADORA.FICHA cFICHA;

        public Multimedia oMULTIMEDIA;
        public CONTROLADORA.MULTIMEDIA cMULTIMEDIA;

        public frmEstudios()
        {
            InitializeComponent();
            cCLIENTE = CONTROLADORA.CLIENTE.obtener_instancia();
            cFICHA = CONTROLADORA.FICHA.obtener_instancia();
            cMULTIMEDIA = CONTROLADORA.MULTIMEDIA.obtener_instancia();
            // Manejar el clic en la imagen
            pbVistaPrevia.Click += (sender, e) => MostrarImagenCompleta();

            ARMA_GRILLA();
        }
        #endregion

        #region "Métodos para limpiar/llenar los Grid"
        void LIMPIAR()
        {
            txtFichaArchivo.Text = null;
            txtFichaNombreEstudio.Text = null;
            pbVistaPrevia.Image = null;
        }
        private void ARMA_GRILLA()
        {
            // Verifica si hay alguna fila seleccionada en dgvFichas
            if (FichaCache.FichaID != null)
            {
                // Obtiene el valor de FichaId de la fila seleccionada
                int fichaId = FichaCache.FichaID;
                dgvEstudios.DataSource = null;
                dgvEstudios.DataSource = cMULTIMEDIA.OBTENER_MULTIMEDIAxID(fichaId);
                dgvEstudios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // Oculta las columnas MultimediaId y FichaId en dgvEstudios
                //dgvEstudios.Columns["MultimediaId"].Visible = false;
                //dgvEstudios.Columns["FichaId"].Visible = false;
            }
            else
            {
                MessageBox.Show("No hay una ficha activa");
            }
        }

        #endregion

        #region Método para agrandar la imagen con un click"
        private void MostrarImagenCompleta()
        {
            // Intentar convertir la cadena a un entero
            if (FichaCache.FichaID != null)
            {
                int ID = FichaCache.FichaID;
                var fichaActual = cFICHA.OBTENER_FICHAxID(ID);

                if (fichaActual != null && fichaActual.Estudios != null && fichaActual.Estudios.Any())
                {
                    byte[] primerEstudio = fichaActual.Estudios.First().Estudio;

                    frmImagenAmpliada imagenForm = new frmImagenAmpliada();
                    imagenForm.MostrarImagen(primerEstudio);
                    imagenForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Error al intentar ampliar el estudio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnFichaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente();
            frmNuevoCliente.Show();
        }

        private void btnFichaExaminar_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFichaArchivo.Text = openFileDialog1.FileName;
            }
        }

        private void btnFichaGuardaEstudio_Click_1(object sender, EventArgs e)
        {
            if (txtFichaArchivo.Text.Trim() == "" || txtFichaNombreEstudio.Text.Trim() == "")
            {
                MessageBox.Show("Nombre y Archivo son obligatorios. ");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            oFICHA = cFICHA.OBTENER_FICHAxID(FichaCache.FichaID);

            Multimedia oMultimedia = new Multimedia();
            oMultimedia.NombreArchivo = txtFichaNombreEstudio.Text;
            oMultimedia.Estudio = file;
            oMultimedia.Ficha = oFICHA;
            cMULTIMEDIA.AGREGAR_MULTIMEDIA(oMultimedia);
            MessageBox.Show("El estudio se ha guardado exitosamente.");

            ARMA_GRILLA();
            LIMPIAR();
        }

        private void btnFichaModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvEstudios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un estudio de la lista.");
                return;
            }
            oMULTIMEDIA = (Multimedia)dgvEstudios.CurrentRow.DataBoundItem;
            cMULTIMEDIA.MODIFICAR_MULTIMEDIA(oMULTIMEDIA);
            MessageBox.Show("El estudio se ha modificado exitosamente.");
            ARMA_GRILLA();
            LIMPIAR();
        }

        private void btnFichaEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvEstudios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un estudio de la lista.");
                return;
            }
            oMULTIMEDIA = (Multimedia)dgvEstudios.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el estudio?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                cMULTIMEDIA.ELIMINAR_MULTIMEDIA(oMULTIMEDIA);
                MessageBox.Show("El estudio se ha eliminado correctamente.");
                ARMA_GRILLA();
                LIMPIAR();
            }
        }

        private void btnFichaVerEstudio_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEstudios.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un estudio de la lista.");
                    return;
                }

                int ID = Convert.ToInt32(dgvEstudios.CurrentRow.Cells["MultimediaId"].Value);

                var oImage = cMULTIMEDIA.OBTENER_MULTIMEDIA(ID);

                if (oImage != null && oImage.Estudio != null)
                {
                    using (MemoryStream ms = new MemoryStream(oImage.Estudio))
                    {
                        Bitmap bmp = new Bitmap(ms);
                        pbVistaPrevia.Image = bmp;
                        // Configurar el PictureBox para que la imagen se ajuste al tamaño del control
                        pbVistaPrevia.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la imagen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void pbVistaPrevia_Click_1(object sender, EventArgs e)
        {
            MostrarImagenCompleta();
            this.Close();
        }

        private void btnEstudioSalir_Click(object sender, EventArgs e)
        {
            frmFicha formFicha = new frmFicha();
            formFicha.Show();
            this.Close();
        }

        private void btnEstudioLimpiar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cMULTIMEDIA.OBTENER_MULTIMEDIAxID(FichaCache.FichaID);
            
        }
    }
}