namespace VISTA
{
    partial class frmEstudios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            btnEstudioLimpiar = new Button();
            label19 = new Label();
            label18 = new Label();
            btnFichaVerEstudio = new Button();
            pbVistaPrevia = new PictureBox();
            btnFichaModificar = new Button();
            btnFichaEliminar = new Button();
            btnEstudioSalir = new Button();
            groupBox1 = new GroupBox();
            btnFichaGuardaEstudio = new Button();
            btnFichaExaminar = new Button();
            txtFichaArchivo = new TextBox();
            label4 = new Label();
            txtFichaNombreEstudio = new TextBox();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            dgvEstudios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVistaPrevia).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudios).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tutopia5;
            pictureBox2.Location = new Point(1006, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 189);
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // btnEstudioLimpiar
            // 
            btnEstudioLimpiar.BackColor = Color.DarkOliveGreen;
            btnEstudioLimpiar.ForeColor = Color.White;
            btnEstudioLimpiar.Location = new Point(787, 566);
            btnEstudioLimpiar.Name = "btnEstudioLimpiar";
            btnEstudioLimpiar.Size = new Size(129, 31);
            btnEstudioLimpiar.TabIndex = 67;
            btnEstudioLimpiar.Text = "Limpiar";
            btnEstudioLimpiar.UseVisualStyleBackColor = false;
            btnEstudioLimpiar.Click += btnEstudioLimpiar_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(835, 161);
            label19.Name = "label19";
            label19.Size = new Size(165, 40);
            label19.TabIndex = 66;
            label19.Text = "Vista previa";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(668, 12);
            label18.Name = "label18";
            label18.Size = new Size(123, 40);
            label18.TabIndex = 65;
            label18.Text = "Estudios";
            // 
            // btnFichaVerEstudio
            // 
            btnFichaVerEstudio.BackColor = Color.DarkOliveGreen;
            btnFichaVerEstudio.ForeColor = Color.White;
            btnFichaVerEstudio.Location = new Point(622, 320);
            btnFichaVerEstudio.Name = "btnFichaVerEstudio";
            btnFichaVerEstudio.Size = new Size(159, 31);
            btnFichaVerEstudio.TabIndex = 64;
            btnFichaVerEstudio.Text = "Ver Estudio";
            btnFichaVerEstudio.UseVisualStyleBackColor = false;
            btnFichaVerEstudio.Click += btnFichaVerEstudio_Click_1;
            // 
            // pbVistaPrevia
            // 
            pbVistaPrevia.Location = new Point(787, 207);
            pbVistaPrevia.Name = "pbVistaPrevia";
            pbVistaPrevia.Size = new Size(509, 344);
            pbVistaPrevia.TabIndex = 62;
            pbVistaPrevia.TabStop = false;
            pbVistaPrevia.Click += pbVistaPrevia_Click_1;
            // 
            // btnFichaModificar
            // 
            btnFichaModificar.BackColor = Color.DarkOliveGreen;
            btnFichaModificar.ForeColor = Color.White;
            btnFichaModificar.Location = new Point(12, 566);
            btnFichaModificar.Name = "btnFichaModificar";
            btnFichaModificar.Size = new Size(149, 31);
            btnFichaModificar.TabIndex = 59;
            btnFichaModificar.Text = "Modificar";
            btnFichaModificar.UseVisualStyleBackColor = false;
            btnFichaModificar.Click += btnFichaModificar_Click_1;
            // 
            // btnFichaEliminar
            // 
            btnFichaEliminar.BackColor = Color.DarkOliveGreen;
            btnFichaEliminar.ForeColor = Color.White;
            btnFichaEliminar.Location = new Point(188, 566);
            btnFichaEliminar.Name = "btnFichaEliminar";
            btnFichaEliminar.Size = new Size(149, 31);
            btnFichaEliminar.TabIndex = 58;
            btnFichaEliminar.Text = "Eliminar";
            btnFichaEliminar.UseVisualStyleBackColor = false;
            btnFichaEliminar.Click += btnFichaEliminar_Click_1;
            // 
            // btnEstudioSalir
            // 
            btnEstudioSalir.BackColor = Color.DarkOliveGreen;
            btnEstudioSalir.ForeColor = Color.White;
            btnEstudioSalir.Location = new Point(1167, 566);
            btnEstudioSalir.Name = "btnEstudioSalir";
            btnEstudioSalir.Size = new Size(129, 31);
            btnEstudioSalir.TabIndex = 60;
            btnEstudioSalir.Text = "Salir";
            btnEstudioSalir.UseVisualStyleBackColor = false;
            btnEstudioSalir.Click += btnEstudioSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFichaGuardaEstudio);
            groupBox1.Controls.Add(btnFichaExaminar);
            groupBox1.Controls.Add(txtFichaArchivo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFichaNombreEstudio);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 189);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar estudio:";
            // 
            // btnFichaGuardaEstudio
            // 
            btnFichaGuardaEstudio.BackColor = Color.DarkOliveGreen;
            btnFichaGuardaEstudio.ForeColor = Color.White;
            btnFichaGuardaEstudio.Location = new Point(6, 133);
            btnFichaGuardaEstudio.Name = "btnFichaGuardaEstudio";
            btnFichaGuardaEstudio.Size = new Size(445, 31);
            btnFichaGuardaEstudio.TabIndex = 2;
            btnFichaGuardaEstudio.Text = "Guardar";
            btnFichaGuardaEstudio.UseVisualStyleBackColor = false;
            btnFichaGuardaEstudio.Click += btnFichaGuardaEstudio_Click_1;
            // 
            // btnFichaExaminar
            // 
            btnFichaExaminar.BackColor = Color.DarkOliveGreen;
            btnFichaExaminar.ForeColor = Color.White;
            btnFichaExaminar.Location = new Point(336, 81);
            btnFichaExaminar.Name = "btnFichaExaminar";
            btnFichaExaminar.Size = new Size(116, 31);
            btnFichaExaminar.TabIndex = 23;
            btnFichaExaminar.Text = "Examinar...";
            btnFichaExaminar.UseVisualStyleBackColor = false;
            btnFichaExaminar.Click += btnFichaExaminar_Click_1;
            // 
            // txtFichaArchivo
            // 
            txtFichaArchivo.Location = new Point(79, 83);
            txtFichaArchivo.Name = "txtFichaArchivo";
            txtFichaArchivo.Size = new Size(253, 29);
            txtFichaArchivo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 91);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 9;
            label4.Text = "Archivo:";
            // 
            // txtFichaNombreEstudio
            // 
            txtFichaNombreEstudio.Location = new Point(164, 28);
            txtFichaNombreEstudio.Name = "txtFichaNombreEstudio";
            txtFichaNombreEstudio.Size = new Size(288, 29);
            txtFichaNombreEstudio.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(7, 36);
            label5.Name = "label5";
            label5.Size = new Size(151, 21);
            label5.TabIndex = 8;
            label5.Text = "Nombre del estudio:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(485, 145);
            button1.Name = "button1";
            button1.Size = new Size(131, 56);
            button1.TabIndex = 24;
            button1.Text = "Cargar estudios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvEstudios
            // 
            dgvEstudios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudios.Location = new Point(12, 207);
            dgvEstudios.Name = "dgvEstudios";
            dgvEstudios.RowTemplate.Height = 25;
            dgvEstudios.Size = new Size(467, 344);
            dgvEstudios.TabIndex = 70;
            // 
            // frmEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1329, 610);
            Controls.Add(dgvEstudios);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnEstudioLimpiar);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(btnFichaVerEstudio);
            Controls.Add(pbVistaPrevia);
            Controls.Add(btnFichaModificar);
            Controls.Add(btnFichaEliminar);
            Controls.Add(btnEstudioSalir);
            Name = "frmEstudios";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVistaPrevia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnEstudioLimpiar;
        private Label label19;
        private Label label18;
        private Button btnFichaVerEstudio;
        private PictureBox pbVistaPrevia;
        private Button btnFichaModificar;
        private Button btnFichaEliminar;
        private Button btnEstudioSalir;
        private GroupBox groupBox1;
        private Button btnFichaGuardaEstudio;
        private Button btnFichaExaminar;
        private TextBox txtFichaArchivo;
        private Label label4;
        private TextBox txtFichaNombreEstudio;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private DataGridView dgvEstudios;
    }
}