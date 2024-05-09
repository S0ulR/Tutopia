namespace VISTA
{
    partial class frmNuevoCliente
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnNuevoClienteEliminar = new Button();
            btnNuevoClienteModificar = new Button();
            btnNuevoClienteGuardar = new Button();
            btnNuevoClienteSalir = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnClienteBuscar = new Button();
            txtNuevoClienteBuscarCliente = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            pbNuevoClienteImagen = new PictureBox();
            btnNuevoClienteExaminar = new Button();
            txtNuevoClienteImagen = new TextBox();
            label12 = new Label();
            dtpNuevoClienteFec_Nac = new DateTimePicker();
            label9 = new Label();
            txtNuevoClienteCorreo = new TextBox();
            label8 = new Label();
            txtNuevoClienteTelefono = new TextBox();
            label7 = new Label();
            txtNuevoClienteDomicilio = new TextBox();
            label4 = new Label();
            txtNuevoClienteDNI = new TextBox();
            label3 = new Label();
            txtNuevoClienteApellido = new TextBox();
            label1 = new Label();
            txtNuevoClienteNombre = new TextBox();
            label2 = new Label();
            btnNuevoClienteFicha = new Button();
            label10 = new Label();
            label11 = new Label();
            dgvCliente = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNuevoClienteImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoClienteEliminar
            // 
            btnNuevoClienteEliminar.BackColor = Color.DarkOliveGreen;
            btnNuevoClienteEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoClienteEliminar.ForeColor = Color.White;
            btnNuevoClienteEliminar.Location = new Point(663, 817);
            btnNuevoClienteEliminar.Name = "btnNuevoClienteEliminar";
            btnNuevoClienteEliminar.Size = new Size(167, 72);
            btnNuevoClienteEliminar.TabIndex = 12;
            btnNuevoClienteEliminar.Text = "Eliminar";
            btnNuevoClienteEliminar.UseVisualStyleBackColor = false;
            btnNuevoClienteEliminar.Click += btnNuevoClienteEliminar_Click;
            // 
            // btnNuevoClienteModificar
            // 
            btnNuevoClienteModificar.BackColor = Color.DarkOliveGreen;
            btnNuevoClienteModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoClienteModificar.ForeColor = Color.White;
            btnNuevoClienteModificar.Location = new Point(477, 817);
            btnNuevoClienteModificar.Name = "btnNuevoClienteModificar";
            btnNuevoClienteModificar.Size = new Size(167, 72);
            btnNuevoClienteModificar.TabIndex = 11;
            btnNuevoClienteModificar.Text = "Modificar";
            btnNuevoClienteModificar.UseVisualStyleBackColor = false;
            btnNuevoClienteModificar.Click += btnNuevoClienteModificar_Click;
            // 
            // btnNuevoClienteGuardar
            // 
            btnNuevoClienteGuardar.BackColor = Color.DarkOliveGreen;
            btnNuevoClienteGuardar.ForeColor = Color.White;
            btnNuevoClienteGuardar.Location = new Point(9, 610);
            btnNuevoClienteGuardar.Name = "btnNuevoClienteGuardar";
            btnNuevoClienteGuardar.Size = new Size(397, 42);
            btnNuevoClienteGuardar.TabIndex = 9;
            btnNuevoClienteGuardar.Text = "Guardar";
            btnNuevoClienteGuardar.UseVisualStyleBackColor = false;
            btnNuevoClienteGuardar.Click += btnNuevoClienteGuardar_Click;
            // 
            // btnNuevoClienteSalir
            // 
            btnNuevoClienteSalir.BackColor = Color.DarkOliveGreen;
            btnNuevoClienteSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoClienteSalir.ForeColor = Color.White;
            btnNuevoClienteSalir.Location = new Point(1085, 817);
            btnNuevoClienteSalir.Name = "btnNuevoClienteSalir";
            btnNuevoClienteSalir.Size = new Size(129, 72);
            btnNuevoClienteSalir.TabIndex = 14;
            btnNuevoClienteSalir.Text = "Salir";
            btnNuevoClienteSalir.UseVisualStyleBackColor = false;
            btnNuevoClienteSalir.Click += btnNuevoClienteSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tutopia5;
            pictureBox1.Location = new Point(924, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 189);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(618, 16);
            label6.Name = "label6";
            label6.Size = new Size(182, 50);
            label6.TabIndex = 12;
            label6.Text = "AGREGAR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClienteBuscar);
            groupBox1.Controls.Add(txtNuevoClienteBuscarCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 100);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente:";
            // 
            // btnClienteBuscar
            // 
            btnClienteBuscar.BackColor = Color.DarkOliveGreen;
            btnClienteBuscar.ForeColor = Color.White;
            btnClienteBuscar.Location = new Point(9, 59);
            btnClienteBuscar.Name = "btnClienteBuscar";
            btnClienteBuscar.Size = new Size(397, 31);
            btnClienteBuscar.TabIndex = 21;
            btnClienteBuscar.Text = "Buscar";
            btnClienteBuscar.UseVisualStyleBackColor = false;
            btnClienteBuscar.Click += btnClienteBuscar_Click;
            // 
            // txtNuevoClienteBuscarCliente
            // 
            txtNuevoClienteBuscarCliente.Location = new Point(70, 24);
            txtNuevoClienteBuscarCliente.Name = "txtNuevoClienteBuscarCliente";
            txtNuevoClienteBuscarCliente.Size = new Size(336, 23);
            txtNuevoClienteBuscarCliente.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 20);
            label5.Name = "label5";
            label5.Size = new Size(55, 30);
            label5.TabIndex = 8;
            label5.Text = "DNI:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbNuevoClienteImagen);
            groupBox2.Controls.Add(btnNuevoClienteExaminar);
            groupBox2.Controls.Add(txtNuevoClienteImagen);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dtpNuevoClienteFec_Nac);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtNuevoClienteCorreo);
            groupBox2.Controls.Add(btnNuevoClienteGuardar);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtNuevoClienteTelefono);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtNuevoClienteDomicilio);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNuevoClienteDNI);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNuevoClienteApellido);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNuevoClienteNombre);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 671);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresar Cliente:";
            // 
            // pbNuevoClienteImagen
            // 
            pbNuevoClienteImagen.Location = new Point(160, 177);
            pbNuevoClienteImagen.Name = "pbNuevoClienteImagen";
            pbNuevoClienteImagen.Size = new Size(246, 210);
            pbNuevoClienteImagen.TabIndex = 27;
            pbNuevoClienteImagen.TabStop = false;
            // 
            // btnNuevoClienteExaminar
            // 
            btnNuevoClienteExaminar.BackColor = Color.DarkOliveGreen;
            btnNuevoClienteExaminar.ForeColor = Color.White;
            btnNuevoClienteExaminar.Location = new Point(268, 130);
            btnNuevoClienteExaminar.Name = "btnNuevoClienteExaminar";
            btnNuevoClienteExaminar.Size = new Size(138, 31);
            btnNuevoClienteExaminar.TabIndex = 26;
            btnNuevoClienteExaminar.Text = "Examinar...";
            btnNuevoClienteExaminar.UseVisualStyleBackColor = false;
            btnNuevoClienteExaminar.Click += btnNuevoClienteExaminar_Click;
            // 
            // txtNuevoClienteImagen
            // 
            txtNuevoClienteImagen.Location = new Point(9, 132);
            txtNuevoClienteImagen.Name = "txtNuevoClienteImagen";
            txtNuevoClienteImagen.Size = new Size(253, 29);
            txtNuevoClienteImagen.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(9, 105);
            label12.Name = "label12";
            label12.Size = new Size(65, 21);
            label12.TabIndex = 24;
            label12.Text = "Imagen:";
            // 
            // dtpNuevoClienteFec_Nac
            // 
            dtpNuevoClienteFec_Nac.Location = new Point(173, 563);
            dtpNuevoClienteFec_Nac.Name = "dtpNuevoClienteFec_Nac";
            dtpNuevoClienteFec_Nac.Size = new Size(233, 29);
            dtpNuevoClienteFec_Nac.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 569);
            label9.Name = "label9";
            label9.Size = new Size(158, 21);
            label9.TabIndex = 20;
            label9.Text = "Fecha de Nacimiento:";
            // 
            // txtNuevoClienteCorreo
            // 
            txtNuevoClienteCorreo.Location = new Point(160, 524);
            txtNuevoClienteCorreo.Name = "txtNuevoClienteCorreo";
            txtNuevoClienteCorreo.Size = new Size(246, 29);
            txtNuevoClienteCorreo.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 527);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 18;
            label8.Text = "Correo:";
            // 
            // txtNuevoClienteTelefono
            // 
            txtNuevoClienteTelefono.Location = new Point(160, 484);
            txtNuevoClienteTelefono.Name = "txtNuevoClienteTelefono";
            txtNuevoClienteTelefono.Size = new Size(246, 29);
            txtNuevoClienteTelefono.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 487);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 16;
            label7.Text = "Teléfono:";
            // 
            // txtNuevoClienteDomicilio
            // 
            txtNuevoClienteDomicilio.Location = new Point(160, 444);
            txtNuevoClienteDomicilio.Name = "txtNuevoClienteDomicilio";
            txtNuevoClienteDomicilio.Size = new Size(246, 29);
            txtNuevoClienteDomicilio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 447);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 14;
            label4.Text = "Domicilio:";
            // 
            // txtNuevoClienteDNI
            // 
            txtNuevoClienteDNI.Location = new Point(160, 404);
            txtNuevoClienteDNI.Name = "txtNuevoClienteDNI";
            txtNuevoClienteDNI.Size = new Size(246, 29);
            txtNuevoClienteDNI.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 407);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 12;
            label3.Text = "DNI:";
            // 
            // txtNuevoClienteApellido
            // 
            txtNuevoClienteApellido.Location = new Point(160, 71);
            txtNuevoClienteApellido.Name = "txtNuevoClienteApellido";
            txtNuevoClienteApellido.Size = new Size(246, 29);
            txtNuevoClienteApellido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 74);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 10;
            label1.Text = "Apellido:";
            // 
            // txtNuevoClienteNombre
            // 
            txtNuevoClienteNombre.Location = new Point(160, 32);
            txtNuevoClienteNombre.Name = "txtNuevoClienteNombre";
            txtNuevoClienteNombre.Size = new Size(246, 29);
            txtNuevoClienteNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombres:";
            // 
            // btnNuevoClienteFicha
            // 
            btnNuevoClienteFicha.BackColor = Color.MediumSpringGreen;
            btnNuevoClienteFicha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoClienteFicha.ForeColor = Color.Black;
            btnNuevoClienteFicha.Location = new Point(12, 817);
            btnNuevoClienteFicha.Name = "btnNuevoClienteFicha";
            btnNuevoClienteFicha.Size = new Size(430, 72);
            btnNuevoClienteFicha.TabIndex = 10;
            btnNuevoClienteFicha.Text = "Ficha médica y estudios";
            btnNuevoClienteFicha.UseVisualStyleBackColor = false;
            btnNuevoClienteFicha.Click += btnNuevoClienteFicha_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(629, 127);
            label10.Name = "label10";
            label10.Size = new Size(157, 50);
            label10.TabIndex = 23;
            label10.Text = "CLIENTE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(635, 70);
            label11.Name = "label11";
            label11.Size = new Size(144, 50);
            label11.TabIndex = 24;
            label11.Text = "NUEVO";
            // 
            // dgvCliente
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCliente.BackgroundColor = Color.MediumSeaGreen;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(477, 207);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(737, 592);
            dgvCliente.TabIndex = 13;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1226, 913);
            Controls.Add(dgvCliente);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnNuevoClienteFicha);
            Controls.Add(groupBox2);
            Controls.Add(btnNuevoClienteEliminar);
            Controls.Add(btnNuevoClienteModificar);
            Controls.Add(btnNuevoClienteSalir);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "frmNuevoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNuevoClienteImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevoClienteGuardar;
#pragma warning disable CS0169 // El campo 'frmNuevoCliente.dataGridView1' nunca se usa
        private DataGridView dataGridView1;
#pragma warning restore CS0169 // El campo 'frmNuevoCliente.dataGridView1' nunca se usa
#pragma warning disable CS0169 // El campo 'frmNuevoCliente.cmbAgendaClientes' nunca se usa
        private ComboBox cmbAgendaClientes;
#pragma warning restore CS0169 // El campo 'frmNuevoCliente.cmbAgendaClientes' nunca se usa
#pragma warning disable CS0169 // El campo 'frmNuevoCliente.btnAgendaBuscar' nunca se usa
        private Button btnAgendaBuscar;
#pragma warning restore CS0169 // El campo 'frmNuevoCliente.btnAgendaBuscar' nunca se usa
        private TextBox txtNuevoClienteBuscarCliente;
        private Label label5;
        private DateTimePicker dtpNuevoClienteFec_Nac;
        private Label label9;
        private TextBox txtNuevoClienteCorreo;
        private Label label8;
        private TextBox txtNuevoClienteTelefono;
        private Label label7;
        private TextBox txtNuevoClienteDomicilio;
        private Label label4;
        private TextBox txtNuevoClienteDNI;
        private Label label3;
        private TextBox txtNuevoClienteApellido;
        private Label label1;
        private TextBox txtNuevoClienteNombre;
        private Label label2;
        private Button btnClienteBuscar;
        public Button btnNuevoClienteEliminar;
        public Button btnNuevoClienteModificar;
        public Button btnNuevoClienteSalir;
        public PictureBox pictureBox1;
        public Label label6;
        public GroupBox groupBox1;
        public GroupBox groupBox2;
        public Button btnNuevoClienteFicha;
        public Label label10;
        public Label label11;
        public DataGridView dgvCliente;
        private Button btnNuevoClienteExaminar;
        private TextBox txtNuevoClienteImagen;
        private Label label12;
        private OpenFileDialog openFileDialog1;
        private PictureBox pbNuevoClienteImagen;
    }
}