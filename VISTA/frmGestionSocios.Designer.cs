namespace VISTA
{
    partial class frmGestionSocios
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
            btnNuevoSocio = new Button();
            btnGestionSociosSalir = new Button();
            dgvGestionSocios = new DataGridView();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            txtClienteBuscarCliente = new TextBox();
            label5 = new Label();
            pbClienteImagen = new PictureBox();
            dtpClienteFec_Nac = new DateTimePicker();
            label9 = new Label();
            txtClienteCorreo = new TextBox();
            label8 = new Label();
            txtClienteTelefono = new TextBox();
            label7 = new Label();
            txtClienteDomicilio = new TextBox();
            label4 = new Label();
            txtClienteDNI = new TextBox();
            label3 = new Label();
            txtClienteApellido = new TextBox();
            label1 = new Label();
            txtClienteNombre = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtClienteFechaInsc = new TextBox();
            label13 = new Label();
            rbClienteDeudorNo = new RadioButton();
            rbClienteDeudorSi = new RadioButton();
            label12 = new Label();
            txtClienteProximoPago = new TextBox();
            label11 = new Label();
            txtClienteEdad = new TextBox();
            label10 = new Label();
            btnNuevoClienteFicha = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGestionSocios).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClienteImagen).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoSocio
            // 
            btnNuevoSocio.BackColor = Color.DarkOliveGreen;
            btnNuevoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoSocio.ForeColor = Color.White;
            btnNuevoSocio.Location = new Point(33, 538);
            btnNuevoSocio.Name = "btnNuevoSocio";
            btnNuevoSocio.Size = new Size(264, 42);
            btnNuevoSocio.TabIndex = 18;
            btnNuevoSocio.Text = "Agregar nuevo socio";
            btnNuevoSocio.UseVisualStyleBackColor = false;
            btnNuevoSocio.Click += btnNuevoSocio_Click;
            // 
            // btnGestionSociosSalir
            // 
            btnGestionSociosSalir.BackColor = Color.DarkOliveGreen;
            btnGestionSociosSalir.ForeColor = Color.White;
            btnGestionSociosSalir.Location = new Point(848, 538);
            btnGestionSociosSalir.Name = "btnGestionSociosSalir";
            btnGestionSociosSalir.Size = new Size(129, 42);
            btnGestionSociosSalir.TabIndex = 16;
            btnGestionSociosSalir.Text = "Salir";
            btnGestionSociosSalir.UseVisualStyleBackColor = false;
            btnGestionSociosSalir.Click += btnGestionSociosSalir_Click;
            // 
            // dgvGestionSocios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dgvGestionSocios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionSocios.BackgroundColor = Color.MediumSeaGreen;
            dgvGestionSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionSocios.Location = new Point(685, 115);
            dgvGestionSocios.Name = "dgvGestionSocios";
            dgvGestionSocios.RowTemplate.Height = 25;
            dgvGestionSocios.Size = new Size(292, 403);
            dgvGestionSocios.TabIndex = 17;
            dgvGestionSocios.CellContentClick += dgvGestionSocios_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(163, 33);
            label6.Name = "label6";
            label6.Size = new Size(391, 50);
            label6.TabIndex = 15;
            label6.Text = "GESTIÓN DE CLIENTES";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtClienteBuscarCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(685, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 100);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkOliveGreen;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(70, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(202, 31);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtClienteBuscarCliente
            // 
            txtClienteBuscarCliente.Location = new Point(70, 24);
            txtClienteBuscarCliente.Name = "txtClienteBuscarCliente";
            txtClienteBuscarCliente.Size = new Size(202, 23);
            txtClienteBuscarCliente.TabIndex = 1;
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
            // pbClienteImagen
            // 
            pbClienteImagen.BorderStyle = BorderStyle.Fixed3D;
            pbClienteImagen.Location = new Point(33, 33);
            pbClienteImagen.Name = "pbClienteImagen";
            pbClienteImagen.Size = new Size(197, 182);
            pbClienteImagen.TabIndex = 23;
            pbClienteImagen.TabStop = false;
            // 
            // dtpClienteFec_Nac
            // 
            dtpClienteFec_Nac.Location = new Point(375, 393);
            dtpClienteFec_Nac.Name = "dtpClienteFec_Nac";
            dtpClienteFec_Nac.Size = new Size(246, 23);
            dtpClienteFec_Nac.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(291, 369);
            label9.Name = "label9";
            label9.Size = new Size(158, 21);
            label9.TabIndex = 37;
            label9.Text = "Fecha de Nacimiento:";
            // 
            // txtClienteCorreo
            // 
            txtClienteCorreo.Location = new Point(375, 343);
            txtClienteCorreo.Name = "txtClienteCorreo";
            txtClienteCorreo.Size = new Size(246, 23);
            txtClienteCorreo.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(291, 341);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 36;
            label8.Text = "Correo:";
            // 
            // txtClienteTelefono
            // 
            txtClienteTelefono.Location = new Point(375, 300);
            txtClienteTelefono.Name = "txtClienteTelefono";
            txtClienteTelefono.Size = new Size(246, 23);
            txtClienteTelefono.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(291, 298);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 35;
            label7.Text = "Teléfono:";
            // 
            // txtClienteDomicilio
            // 
            txtClienteDomicilio.Location = new Point(375, 258);
            txtClienteDomicilio.Name = "txtClienteDomicilio";
            txtClienteDomicilio.Size = new Size(246, 23);
            txtClienteDomicilio.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(291, 256);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 34;
            label4.Text = "Domicilio:";
            // 
            // txtClienteDNI
            // 
            txtClienteDNI.Location = new Point(375, 217);
            txtClienteDNI.Name = "txtClienteDNI";
            txtClienteDNI.Size = new Size(246, 23);
            txtClienteDNI.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(291, 215);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 33;
            label3.Text = "DNI:";
            // 
            // txtClienteApellido
            // 
            txtClienteApellido.Location = new Point(375, 178);
            txtClienteApellido.Name = "txtClienteApellido";
            txtClienteApellido.Size = new Size(246, 23);
            txtClienteApellido.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(291, 176);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 32;
            label1.Text = "Apellido:";
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Location = new Point(375, 139);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(246, 23);
            txtClienteNombre.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 137);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 31;
            label2.Text = "Nombres:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtClienteFechaInsc);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(rbClienteDeudorNo);
            groupBox2.Controls.Add(rbClienteDeudorSi);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtClienteProximoPago);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtClienteEdad);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(pbClienteImagen);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(33, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 403);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // txtClienteFechaInsc
            // 
            txtClienteFechaInsc.Location = new Point(360, 360);
            txtClienteFechaInsc.Name = "txtClienteFechaInsc";
            txtClienteFechaInsc.Size = new Size(228, 25);
            txtClienteFechaInsc.TabIndex = 46;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(258, 364);
            label13.Name = "label13";
            label13.Size = new Size(96, 21);
            label13.TabIndex = 47;
            label13.Text = "Socio desde:";
            // 
            // rbClienteDeudorNo
            // 
            rbClienteDeudorNo.AutoSize = true;
            rbClienteDeudorNo.Location = new Point(107, 254);
            rbClienteDeudorNo.Name = "rbClienteDeudorNo";
            rbClienteDeudorNo.Size = new Size(44, 21);
            rbClienteDeudorNo.TabIndex = 45;
            rbClienteDeudorNo.TabStop = true;
            rbClienteDeudorNo.Text = "No";
            rbClienteDeudorNo.UseVisualStyleBackColor = true;
            // 
            // rbClienteDeudorSi
            // 
            rbClienteDeudorSi.AutoSize = true;
            rbClienteDeudorSi.Location = new Point(33, 255);
            rbClienteDeudorSi.Name = "rbClienteDeudorSi";
            rbClienteDeudorSi.Size = new Size(36, 21);
            rbClienteDeudorSi.TabIndex = 44;
            rbClienteDeudorSi.TabStop = true;
            rbClienteDeudorSi.Text = "Si";
            rbClienteDeudorSi.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(33, 226);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 43;
            label12.Text = "Deudor?";
            // 
            // txtClienteProximoPago
            // 
            txtClienteProximoPago.Location = new Point(33, 327);
            txtClienteProximoPago.Name = "txtClienteProximoPago";
            txtClienteProximoPago.Size = new Size(197, 25);
            txtClienteProximoPago.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(33, 293);
            label11.Name = "label11";
            label11.Size = new Size(110, 21);
            label11.TabIndex = 42;
            label11.Text = "Próximo pago:";
            // 
            // txtClienteEdad
            // 
            txtClienteEdad.Location = new Point(342, 319);
            txtClienteEdad.Name = "txtClienteEdad";
            txtClienteEdad.Size = new Size(246, 25);
            txtClienteEdad.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(258, 323);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 40;
            label10.Text = "Edad:";
            // 
            // btnNuevoClienteFicha
            // 
            btnNuevoClienteFicha.BackColor = Color.MediumSpringGreen;
            btnNuevoClienteFicha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoClienteFicha.ForeColor = Color.Black;
            btnNuevoClienteFicha.Location = new Point(375, 538);
            btnNuevoClienteFicha.Name = "btnNuevoClienteFicha";
            btnNuevoClienteFicha.Size = new Size(281, 42);
            btnNuevoClienteFicha.TabIndex = 39;
            btnNuevoClienteFicha.Text = "Ficha médica y estudios";
            btnNuevoClienteFicha.UseVisualStyleBackColor = false;
            btnNuevoClienteFicha.Click += btnNuevoClienteFicha_Click;
            // 
            // frmGestionSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1011, 603);
            Controls.Add(btnNuevoClienteFicha);
            Controls.Add(dtpClienteFec_Nac);
            Controls.Add(label9);
            Controls.Add(txtClienteCorreo);
            Controls.Add(label8);
            Controls.Add(txtClienteTelefono);
            Controls.Add(label7);
            Controls.Add(txtClienteDomicilio);
            Controls.Add(label4);
            Controls.Add(txtClienteDNI);
            Controls.Add(label3);
            Controls.Add(txtClienteApellido);
            Controls.Add(label1);
            Controls.Add(txtClienteNombre);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnNuevoSocio);
            Controls.Add(btnGestionSociosSalir);
            Controls.Add(dgvGestionSocios);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Name = "frmGestionSocios";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvGestionSocios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClienteImagen).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoSocio;
        private Button btnGestionSociosSalir;
        private DataGridView dgvGestionSocios;
        private Label label6;
        public GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox txtClienteBuscarCliente;
        private Label label5;
        private PictureBox pbClienteImagen;
        private DateTimePicker dtpClienteFec_Nac;
        private Label label9;
        private TextBox txtClienteCorreo;
        private Label label8;
        private TextBox txtClienteTelefono;
        private Label label7;
        private TextBox txtClienteDomicilio;
        private Label label4;
        private TextBox txtClienteDNI;
        private Label label3;
        private TextBox txtClienteApellido;
        private Label label1;
        private TextBox txtClienteNombre;
        private Label label2;
        private GroupBox groupBox2;
        private Label label12;
        private TextBox txtClienteProximoPago;
        private Label label11;
        private TextBox txtClienteEdad;
        private Label label10;
        private TextBox txtClienteFechaInsc;
        private Label label13;
        private RadioButton rbClienteDeudorNo;
        private RadioButton rbClienteDeudorSi;
        public Button btnNuevoClienteFicha;
    }
}