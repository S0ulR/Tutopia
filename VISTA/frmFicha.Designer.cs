namespace VISTA
{
    partial class frmFicha
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnFichaModificar = new Button();
            btnFichaEliminar = new Button();
            btnFichaSalir = new Button();
            dgvFichas = new DataGridView();
            pictureBox1 = new PictureBox();
            lblFichaCliente = new Label();
            label6 = new Label();
            label1 = new Label();
            btnFichaGuardar = new Button();
            txtFichaAfecciones = new TextBox();
            txtFichaNotas = new TextBox();
            label3 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtFichaTipoSangre = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtFichaAlergia = new TextBox();
            txtFichaPeso = new TextBox();
            txtFichaAltura = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label15 = new Label();
            txtFichaCirugiaCuales = new TextBox();
            rbFichaFactorPositivo = new RadioButton();
            rbFichaFactorNegativo = new RadioButton();
            label16 = new Label();
            label17 = new Label();
            groupBox2 = new GroupBox();
            btnCargaFichasxDNI = new Button();
            cbPresionNo = new CheckBox();
            cbPresionSi = new CheckBox();
            cbAlergicoNo = new CheckBox();
            cbAlergicoSi = new CheckBox();
            lblFichaClienteDNI = new Label();
            btnFichaVerEstudios = new Button();
            rbFichaCirugiaSi = new CheckBox();
            rbFichaCirugiaNo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvFichas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnFichaModificar
            // 
            btnFichaModificar.BackColor = Color.DarkOliveGreen;
            btnFichaModificar.ForeColor = Color.White;
            btnFichaModificar.Location = new Point(12, 730);
            btnFichaModificar.Name = "btnFichaModificar";
            btnFichaModificar.Size = new Size(149, 47);
            btnFichaModificar.TabIndex = 15;
            btnFichaModificar.Text = "Modificar";
            btnFichaModificar.UseVisualStyleBackColor = false;
            btnFichaModificar.Click += btnFichaModificar_Click;
            // 
            // btnFichaEliminar
            // 
            btnFichaEliminar.BackColor = Color.DarkOliveGreen;
            btnFichaEliminar.ForeColor = Color.White;
            btnFichaEliminar.Location = new Point(198, 730);
            btnFichaEliminar.Name = "btnFichaEliminar";
            btnFichaEliminar.Size = new Size(149, 47);
            btnFichaEliminar.TabIndex = 14;
            btnFichaEliminar.Text = "Eliminar";
            btnFichaEliminar.UseVisualStyleBackColor = false;
            btnFichaEliminar.Click += btnFichaEliminar_Click;
            // 
            // btnFichaSalir
            // 
            btnFichaSalir.BackColor = Color.DarkOliveGreen;
            btnFichaSalir.ForeColor = Color.White;
            btnFichaSalir.Location = new Point(1268, 730);
            btnFichaSalir.Name = "btnFichaSalir";
            btnFichaSalir.Size = new Size(129, 47);
            btnFichaSalir.TabIndex = 16;
            btnFichaSalir.Text = "Salir";
            btnFichaSalir.UseVisualStyleBackColor = false;
            btnFichaSalir.Click += btnFichaSalir_Click;
            // 
            // dgvFichas
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dgvFichas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFichas.BackgroundColor = Color.MediumSeaGreen;
            dgvFichas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFichas.Location = new Point(12, 396);
            dgvFichas.Name = "dgvFichas";
            dgvFichas.RowTemplate.Height = 25;
            dgvFichas.Size = new Size(1385, 328);
            dgvFichas.TabIndex = 17;
            dgvFichas.CellContentClick += dgvFichas_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tutopia5;
            pictureBox1.Location = new Point(1107, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 189);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lblFichaCliente
            // 
            lblFichaCliente.AutoSize = true;
            lblFichaCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFichaCliente.ForeColor = Color.White;
            lblFichaCliente.Location = new Point(6, 19);
            lblFichaCliente.Name = "lblFichaCliente";
            lblFichaCliente.Size = new Size(82, 30);
            lblFichaCliente.TabIndex = 13;
            lblFichaCliente.Text = "Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(506, -7);
            label6.Name = "label6";
            label6.Size = new Size(235, 50);
            label6.TabIndex = 12;
            label6.Text = "Ficha Médica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 20;
            label1.Text = "Afecciones:";
            // 
            // btnFichaGuardar
            // 
            btnFichaGuardar.BackColor = Color.DarkOliveGreen;
            btnFichaGuardar.ForeColor = Color.White;
            btnFichaGuardar.Location = new Point(6, 294);
            btnFichaGuardar.Name = "btnFichaGuardar";
            btnFichaGuardar.Size = new Size(329, 46);
            btnFichaGuardar.TabIndex = 9;
            btnFichaGuardar.Text = "Guardar ficha";
            btnFichaGuardar.UseVisualStyleBackColor = false;
            btnFichaGuardar.Click += btnFichaGuardar_Click_1;
            // 
            // txtFichaAfecciones
            // 
            txtFichaAfecciones.Location = new Point(111, 88);
            txtFichaAfecciones.Name = "txtFichaAfecciones";
            txtFichaAfecciones.Size = new Size(240, 23);
            txtFichaAfecciones.TabIndex = 9;
            // 
            // txtFichaNotas
            // 
            txtFichaNotas.Location = new Point(6, 103);
            txtFichaNotas.Multiline = true;
            txtFichaNotas.Name = "txtFichaNotas";
            txtFichaNotas.Size = new Size(327, 182);
            txtFichaNotas.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 22;
            label3.Text = "Notas:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(741, 58);
            label14.Name = "label14";
            label14.Size = new Size(91, 21);
            label14.TabIndex = 27;
            label14.Text = "Alérgico/a?:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(741, 213);
            label13.Name = "label13";
            label13.Size = new Size(80, 21);
            label13.TabIndex = 35;
            label13.Text = "Factor RH:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(741, 161);
            label12.Name = "label12";
            label12.Size = new Size(115, 21);
            label12.TabIndex = 34;
            label12.Text = "Tipo de sangre:";
            // 
            // txtFichaTipoSangre
            // 
            txtFichaTipoSangre.Location = new Point(888, 153);
            txtFichaTipoSangre.Name = "txtFichaTipoSangre";
            txtFichaTipoSangre.Size = new Size(157, 29);
            txtFichaTipoSangre.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(371, 225);
            label11.Name = "label11";
            label11.Size = new Size(45, 21);
            label11.TabIndex = 33;
            label11.Text = "Peso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(371, 265);
            label10.Name = "label10";
            label10.Size = new Size(55, 21);
            label10.TabIndex = 31;
            label10.Text = "Altura:";
            // 
            // txtFichaAlergia
            // 
            txtFichaAlergia.Location = new Point(825, 99);
            txtFichaAlergia.Name = "txtFichaAlergia";
            txtFichaAlergia.Size = new Size(220, 29);
            txtFichaAlergia.TabIndex = 36;
            // 
            // txtFichaPeso
            // 
            txtFichaPeso.Location = new Point(432, 217);
            txtFichaPeso.Name = "txtFichaPeso";
            txtFichaPeso.Size = new Size(223, 29);
            txtFichaPeso.TabIndex = 37;
            // 
            // txtFichaAltura
            // 
            txtFichaAltura.Location = new Point(432, 257);
            txtFichaAltura.Name = "txtFichaAltura";
            txtFichaAltura.Size = new Size(223, 29);
            txtFichaAltura.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(371, 92);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 39;
            label7.Text = "Cuáles:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(661, 227);
            label8.Name = "label8";
            label8.Size = new Size(38, 21);
            label8.TabIndex = 40;
            label8.Text = "Kgs.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(661, 267);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 41;
            label9.Text = "Cms.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(371, 55);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 42;
            label15.Text = "Cirugías?:";
            // 
            // txtFichaCirugiaCuales
            // 
            txtFichaCirugiaCuales.Location = new Point(371, 116);
            txtFichaCirugiaCuales.Multiline = true;
            txtFichaCirugiaCuales.Name = "txtFichaCirugiaCuales";
            txtFichaCirugiaCuales.Size = new Size(329, 92);
            txtFichaCirugiaCuales.TabIndex = 43;
            // 
            // rbFichaFactorPositivo
            // 
            rbFichaFactorPositivo.AutoSize = true;
            rbFichaFactorPositivo.ForeColor = Color.White;
            rbFichaFactorPositivo.Location = new Point(852, 211);
            rbFichaFactorPositivo.Name = "rbFichaFactorPositivo";
            rbFichaFactorPositivo.Size = new Size(82, 25);
            rbFichaFactorPositivo.TabIndex = 44;
            rbFichaFactorPositivo.TabStop = true;
            rbFichaFactorPositivo.Text = "Positivo";
            rbFichaFactorPositivo.UseVisualStyleBackColor = true;
            // 
            // rbFichaFactorNegativo
            // 
            rbFichaFactorNegativo.AutoSize = true;
            rbFichaFactorNegativo.ForeColor = Color.White;
            rbFichaFactorNegativo.Location = new Point(954, 211);
            rbFichaFactorNegativo.Name = "rbFichaFactorNegativo";
            rbFichaFactorNegativo.Size = new Size(91, 25);
            rbFichaFactorNegativo.TabIndex = 45;
            rbFichaFactorNegativo.TabStop = true;
            rbFichaFactorNegativo.Text = "Negativo";
            rbFichaFactorNegativo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(741, 102);
            label16.Name = "label16";
            label16.Size = new Size(74, 21);
            label16.TabIndex = 48;
            label16.Text = "Alergia a:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(741, 261);
            label17.Name = "label17";
            label17.Size = new Size(72, 21);
            label17.TabIndex = 49;
            label17.Text = "Presión?:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFichaCirugiaNo);
            groupBox2.Controls.Add(rbFichaCirugiaSi);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txtFichaAltura);
            groupBox2.Controls.Add(txtFichaPeso);
            groupBox2.Controls.Add(btnCargaFichasxDNI);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cbPresionNo);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(rbFichaFactorPositivo);
            groupBox2.Controls.Add(rbFichaFactorNegativo);
            groupBox2.Controls.Add(txtFichaAlergia);
            groupBox2.Controls.Add(cbPresionSi);
            groupBox2.Controls.Add(cbAlergicoNo);
            groupBox2.Controls.Add(cbAlergicoSi);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(lblFichaClienteDNI);
            groupBox2.Controls.Add(txtFichaCirugiaCuales);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtFichaTipoSangre);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtFichaNotas);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(lblFichaCliente);
            groupBox2.Controls.Add(btnFichaGuardar);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1072, 355);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cargar ficha médica";
            // 
            // btnCargaFichasxDNI
            // 
            btnCargaFichasxDNI.BackColor = Color.DarkOliveGreen;
            btnCargaFichasxDNI.ForeColor = Color.White;
            btnCargaFichasxDNI.Location = new Point(741, 294);
            btnCargaFichasxDNI.Name = "btnCargaFichasxDNI";
            btnCargaFichasxDNI.Size = new Size(304, 46);
            btnCargaFichasxDNI.TabIndex = 56;
            btnCargaFichasxDNI.Text = "Carga fichas del paciente";
            btnCargaFichasxDNI.UseVisualStyleBackColor = false;
            btnCargaFichasxDNI.Click += btnCargaFichasxDNI_Click;
            // 
            // cbPresionNo
            // 
            cbPresionNo.AutoSize = true;
            cbPresionNo.Location = new Point(954, 260);
            cbPresionNo.Name = "cbPresionNo";
            cbPresionNo.Size = new Size(50, 25);
            cbPresionNo.TabIndex = 61;
            cbPresionNo.Text = "No";
            cbPresionNo.UseVisualStyleBackColor = true;
            // 
            // cbPresionSi
            // 
            cbPresionSi.AutoSize = true;
            cbPresionSi.Location = new Point(852, 260);
            cbPresionSi.Name = "cbPresionSi";
            cbPresionSi.Size = new Size(42, 25);
            cbPresionSi.TabIndex = 60;
            cbPresionSi.Text = "Sí";
            cbPresionSi.UseVisualStyleBackColor = true;
            // 
            // cbAlergicoNo
            // 
            cbAlergicoNo.AutoSize = true;
            cbAlergicoNo.Location = new Point(954, 57);
            cbAlergicoNo.Name = "cbAlergicoNo";
            cbAlergicoNo.Size = new Size(50, 25);
            cbAlergicoNo.TabIndex = 59;
            cbAlergicoNo.Text = "No";
            cbAlergicoNo.UseVisualStyleBackColor = true;
            // 
            // cbAlergicoSi
            // 
            cbAlergicoSi.AutoSize = true;
            cbAlergicoSi.Location = new Point(852, 57);
            cbAlergicoSi.Name = "cbAlergicoSi";
            cbAlergicoSi.Size = new Size(42, 25);
            cbAlergicoSi.TabIndex = 58;
            cbAlergicoSi.Text = "Sí";
            cbAlergicoSi.UseVisualStyleBackColor = true;
            // 
            // lblFichaClienteDNI
            // 
            lblFichaClienteDNI.AutoSize = true;
            lblFichaClienteDNI.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFichaClienteDNI.ForeColor = Color.White;
            lblFichaClienteDNI.Location = new Point(349, 19);
            lblFichaClienteDNI.Name = "lblFichaClienteDNI";
            lblFichaClienteDNI.Size = new Size(61, 30);
            lblFichaClienteDNI.TabIndex = 57;
            lblFichaClienteDNI.Text = "DNI: ";
            // 
            // btnFichaVerEstudios
            // 
            btnFichaVerEstudios.BackColor = Color.Yellow;
            btnFichaVerEstudios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFichaVerEstudios.ForeColor = Color.IndianRed;
            btnFichaVerEstudios.Location = new Point(1107, 324);
            btnFichaVerEstudios.Name = "btnFichaVerEstudios";
            btnFichaVerEstudios.Size = new Size(290, 61);
            btnFichaVerEstudios.TabIndex = 62;
            btnFichaVerEstudios.Text = "Ver estudios";
            btnFichaVerEstudios.UseVisualStyleBackColor = false;
            btnFichaVerEstudios.Click += btnFichaVerEstudios_Click;
            // 
            // rbFichaCirugiaSi
            // 
            rbFichaCirugiaSi.AutoSize = true;
            rbFichaCirugiaSi.Location = new Point(470, 55);
            rbFichaCirugiaSi.Name = "rbFichaCirugiaSi";
            rbFichaCirugiaSi.Size = new Size(42, 25);
            rbFichaCirugiaSi.TabIndex = 62;
            rbFichaCirugiaSi.Text = "Sí";
            rbFichaCirugiaSi.UseVisualStyleBackColor = true;
            // 
            // rbFichaCirugiaNo
            // 
            rbFichaCirugiaNo.AutoSize = true;
            rbFichaCirugiaNo.Location = new Point(548, 55);
            rbFichaCirugiaNo.Name = "rbFichaCirugiaNo";
            rbFichaCirugiaNo.Size = new Size(50, 25);
            rbFichaCirugiaNo.TabIndex = 63;
            rbFichaCirugiaNo.Text = "No";
            rbFichaCirugiaNo.UseVisualStyleBackColor = true;
            // 
            // frmFicha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1409, 789);
            Controls.Add(btnFichaVerEstudios);
            Controls.Add(txtFichaAfecciones);
            Controls.Add(btnFichaModificar);
            Controls.Add(btnFichaEliminar);
            Controls.Add(btnFichaSalir);
            Controls.Add(dgvFichas);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Name = "frmFicha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rmFicha";
            ((System.ComponentModel.ISupportInitialize)dgvFichas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFichaModificar;
        private Button btnFichaEliminar;
        private Button btnFichaSalir;
        private DataGridView dgvFichas;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private Button btnFichaGuardar;
        private TextBox txtFichaAfecciones;
        private TextBox txtFichaNotas;
        private Label label3;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txtFichaTipoSangre;
        private Label label11;
        private Label label10;
        private TextBox txtFichaAlergia;
        private TextBox txtFichaPeso;
        private TextBox txtFichaAltura;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label15;
        private TextBox txtFichaCirugiaCuales;
        private RadioButton rbFichaFactorPositivo;
        private RadioButton rbFichaFactorNegativo;
        private Label label16;
        private Label label17;
        private GroupBox groupBox2;
        public Label lblFichaCliente;
        public Label lblFichaClienteDNI;
        private CheckBox cbPresionNo;
        private CheckBox cbPresionSi;
        private CheckBox cbAlergicoNo;
        private CheckBox cbAlergicoSi;
        private Button btnCargaFichasxDNI;
        private Button btnFichaVerEstudios;
        private CheckBox rbFichaCirugiaNo;
        private CheckBox rbFichaCirugiaSi;
    }
}