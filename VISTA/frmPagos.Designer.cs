namespace VISTA
{
    partial class frmPagos
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
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            txtClienteBuscarCliente = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnRegistrarPago = new Button();
            cmbPagosCliente = new ComboBox();
            txtPagosFechaUltimoPago = new TextBox();
            txtPagosFechaProximoPago = new TextBox();
            btnPagosSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tutopia5;
            pictureBox2.Location = new Point(498, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 189);
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtClienteBuscarCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 113);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkOliveGreen;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(70, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(351, 38);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtClienteBuscarCliente
            // 
            txtClienteBuscarCliente.Location = new Point(70, 24);
            txtClienteBuscarCliente.Name = "txtClienteBuscarCliente";
            txtClienteBuscarCliente.Size = new Size(351, 23);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(243, 21);
            label6.Name = "label6";
            label6.Size = new Size(350, 50);
            label6.TabIndex = 71;
            label6.Text = "GESTIÓN DE PAGOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 220);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 74;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 261);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 76;
            label1.Text = "Fecha de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 300);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 78;
            label3.Text = "Próximo pago:";
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.BackColor = Color.LightSeaGreen;
            btnRegistrarPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarPago.ForeColor = Color.White;
            btnRegistrarPago.Location = new Point(35, 345);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(440, 43);
            btnRegistrarPago.TabIndex = 79;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // cmbPagosCliente
            // 
            cmbPagosCliente.FormattingEnabled = true;
            cmbPagosCliente.Location = new Point(180, 218);
            cmbPagosCliente.Name = "cmbPagosCliente";
            cmbPagosCliente.Size = new Size(295, 23);
            cmbPagosCliente.TabIndex = 80;
            // 
            // txtPagosFechaUltimoPago
            // 
            txtPagosFechaUltimoPago.Location = new Point(180, 259);
            txtPagosFechaUltimoPago.Name = "txtPagosFechaUltimoPago";
            txtPagosFechaUltimoPago.Size = new Size(295, 23);
            txtPagosFechaUltimoPago.TabIndex = 81;
            // 
            // txtPagosFechaProximoPago
            // 
            txtPagosFechaProximoPago.Location = new Point(180, 298);
            txtPagosFechaProximoPago.Name = "txtPagosFechaProximoPago";
            txtPagosFechaProximoPago.Size = new Size(295, 23);
            txtPagosFechaProximoPago.TabIndex = 82;
            // 
            // btnPagosSalir
            // 
            btnPagosSalir.BackColor = Color.DarkOliveGreen;
            btnPagosSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagosSalir.ForeColor = Color.White;
            btnPagosSalir.Location = new Point(587, 345);
            btnPagosSalir.Name = "btnPagosSalir";
            btnPagosSalir.Size = new Size(201, 43);
            btnPagosSalir.TabIndex = 83;
            btnPagosSalir.Text = "Salir";
            btnPagosSalir.UseVisualStyleBackColor = false;
            btnPagosSalir.Click += btnPagosSalir_Click;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 400);
            Controls.Add(btnPagosSalir);
            Controls.Add(txtPagosFechaProximoPago);
            Controls.Add(txtPagosFechaUltimoPago);
            Controls.Add(cmbPagosCliente);
            Controls.Add(btnRegistrarPago);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Name = "frmPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmPagos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnEstudioSalir;
        public GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox txtClienteBuscarCliente;
        private Label label5;
        private Label label6;
        private TextBox txtClienteNombre;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Button btnRegistrarPago;
        private ComboBox cmbPagosCliente;
        private TextBox txtPagosFechaUltimoPago;
        private TextBox txtPagosFechaProximoPago;
        private Button btnPagosSalir;
    }
}