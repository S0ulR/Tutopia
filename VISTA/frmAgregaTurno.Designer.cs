namespace VISTA
{
    partial class frmAgregaTurno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cmbAgendaClientes = new ComboBox();
            label3 = new Label();
            clbAgendaDias = new CheckedListBox();
            label4 = new Label();
            label5 = new Label();
            txtAgendaBuscarCliente = new TextBox();
            groupBox1 = new GroupBox();
            btnAgendaBuscar = new Button();
            btnAgendaSalir = new Button();
            btnAgendaGuardarHorario = new Button();
            btnAgendaModificaHorario = new Button();
            btnAgendaEliminaHorario = new Button();
            groupBox3 = new GroupBox();
            cmbAgendaHorarios = new CheckedListBox();
            btnAgendaTraerHorarios = new Button();
            dgvAgenda = new DataGridView();
            groupBox2 = new GroupBox();
            btnAgendaTurnosReservadosCliente = new Button();
            txtDNITurnosReservadosCliente = new TextBox();
            label6 = new Label();
            btnAgendaTurnosLibresMostrar = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(489, -3);
            label1.Name = "label1";
            label1.Size = new Size(166, 50);
            label1.TabIndex = 0;
            label1.Text = "AGENDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 24);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // cmbAgendaClientes
            // 
            cmbAgendaClientes.FormattingEnabled = true;
            cmbAgendaClientes.Location = new Point(110, 27);
            cmbAgendaClientes.Name = "cmbAgendaClientes";
            cmbAgendaClientes.Size = new Size(237, 29);
            cmbAgendaClientes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 52);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 3;
            label3.Text = "Días:";
            // 
            // clbAgendaDias
            // 
            clbAgendaDias.BackColor = Color.ForestGreen;
            clbAgendaDias.ForeColor = Color.White;
            clbAgendaDias.FormattingEnabled = true;
            clbAgendaDias.Location = new Point(110, 64);
            clbAgendaDias.Name = "clbAgendaDias";
            clbAgendaDias.Size = new Size(237, 148);
            clbAgendaDias.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(376, 28);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 7;
            label4.Text = "Horario:";
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
            // txtAgendaBuscarCliente
            // 
            txtAgendaBuscarCliente.Location = new Point(70, 24);
            txtAgendaBuscarCliente.Name = "txtAgendaBuscarCliente";
            txtAgendaBuscarCliente.Size = new Size(201, 29);
            txtAgendaBuscarCliente.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgendaBuscar);
            groupBox1.Controls.Add(txtAgendaBuscarCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente:";
            // 
            // btnAgendaBuscar
            // 
            btnAgendaBuscar.BackColor = Color.DarkOliveGreen;
            btnAgendaBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaBuscar.ForeColor = Color.White;
            btnAgendaBuscar.Location = new Point(70, 59);
            btnAgendaBuscar.Name = "btnAgendaBuscar";
            btnAgendaBuscar.Size = new Size(201, 31);
            btnAgendaBuscar.TabIndex = 2;
            btnAgendaBuscar.Text = "Buscar";
            btnAgendaBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgendaSalir
            // 
            btnAgendaSalir.BackColor = Color.DarkOliveGreen;
            btnAgendaSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaSalir.ForeColor = Color.White;
            btnAgendaSalir.Location = new Point(975, 681);
            btnAgendaSalir.Name = "btnAgendaSalir";
            btnAgendaSalir.Size = new Size(129, 31);
            btnAgendaSalir.TabIndex = 9;
            btnAgendaSalir.Text = "Salir";
            btnAgendaSalir.UseVisualStyleBackColor = false;
            btnAgendaSalir.Click += btnAgendaSalir_Click;
            // 
            // btnAgendaGuardarHorario
            // 
            btnAgendaGuardarHorario.BackColor = Color.DarkOliveGreen;
            btnAgendaGuardarHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaGuardarHorario.ForeColor = Color.White;
            btnAgendaGuardarHorario.Location = new Point(374, 232);
            btnAgendaGuardarHorario.Name = "btnAgendaGuardarHorario";
            btnAgendaGuardarHorario.Size = new Size(330, 40);
            btnAgendaGuardarHorario.TabIndex = 6;
            btnAgendaGuardarHorario.Text = "Reservar horario";
            btnAgendaGuardarHorario.UseVisualStyleBackColor = false;
            btnAgendaGuardarHorario.Click += btnAgendaGuardarHorario_Click;
            // 
            // btnAgendaModificaHorario
            // 
            btnAgendaModificaHorario.BackColor = Color.DarkOliveGreen;
            btnAgendaModificaHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaModificaHorario.ForeColor = Color.White;
            btnAgendaModificaHorario.Location = new Point(12, 672);
            btnAgendaModificaHorario.Name = "btnAgendaModificaHorario";
            btnAgendaModificaHorario.Size = new Size(167, 40);
            btnAgendaModificaHorario.TabIndex = 7;
            btnAgendaModificaHorario.Text = "Modificar";
            btnAgendaModificaHorario.UseVisualStyleBackColor = false;
            btnAgendaModificaHorario.Click += btnAgendaModificaHorario_Click;
            // 
            // btnAgendaEliminaHorario
            // 
            btnAgendaEliminaHorario.BackColor = Color.DarkOliveGreen;
            btnAgendaEliminaHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaEliminaHorario.ForeColor = Color.White;
            btnAgendaEliminaHorario.Location = new Point(195, 672);
            btnAgendaEliminaHorario.Name = "btnAgendaEliminaHorario";
            btnAgendaEliminaHorario.Size = new Size(167, 40);
            btnAgendaEliminaHorario.TabIndex = 8;
            btnAgendaEliminaHorario.Text = "Eliminar";
            btnAgendaEliminaHorario.UseVisualStyleBackColor = false;
            btnAgendaEliminaHorario.Click += btnAgendaEliminaHorario_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbAgendaHorarios);
            groupBox3.Controls.Add(btnAgendaTraerHorarios);
            groupBox3.Controls.Add(btnAgendaGuardarHorario);
            groupBox3.Controls.Add(cmbAgendaClientes);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(clbAgendaDias);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(377, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(727, 292);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Reservar Turno";
            // 
            // cmbAgendaHorarios
            // 
            cmbAgendaHorarios.BackColor = Color.ForestGreen;
            cmbAgendaHorarios.ForeColor = Color.White;
            cmbAgendaHorarios.FormattingEnabled = true;
            cmbAgendaHorarios.Location = new Point(467, 64);
            cmbAgendaHorarios.Name = "cmbAgendaHorarios";
            cmbAgendaHorarios.Size = new Size(237, 148);
            cmbAgendaHorarios.TabIndex = 9;
            // 
            // btnAgendaTraerHorarios
            // 
            btnAgendaTraerHorarios.BackColor = Color.DarkOliveGreen;
            btnAgendaTraerHorarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaTraerHorarios.ForeColor = Color.White;
            btnAgendaTraerHorarios.Location = new Point(19, 232);
            btnAgendaTraerHorarios.Name = "btnAgendaTraerHorarios";
            btnAgendaTraerHorarios.Size = new Size(330, 40);
            btnAgendaTraerHorarios.TabIndex = 8;
            btnAgendaTraerHorarios.Text = "Cargar horarios";
            btnAgendaTraerHorarios.UseVisualStyleBackColor = false;
            btnAgendaTraerHorarios.Click += btnAgendaTraerHorarios_Click;
            // 
            // dgvAgenda
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Green;
            dataGridViewCellStyle5.SelectionBackColor = Color.Green;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAgenda.BackgroundColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Green;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Green;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvAgenda.DefaultCellStyle = dataGridViewCellStyle7;
            dgvAgenda.Location = new Point(12, 359);
            dgvAgenda.Name = "dgvAgenda";
            dataGridViewCellStyle8.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle8.SelectionBackColor = Color.ForestGreen;
            dgvAgenda.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvAgenda.RowTemplate.DefaultCellStyle.ForeColor = Color.ForestGreen;
            dgvAgenda.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Green;
            dgvAgenda.RowTemplate.Height = 25;
            dgvAgenda.Size = new Size(1092, 300);
            dgvAgenda.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgendaTurnosReservadosCliente);
            groupBox2.Controls.Add(txtDNITurnosReservadosCliente);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 100);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Turnos reservados del Cliente:";
            // 
            // btnAgendaTurnosReservadosCliente
            // 
            btnAgendaTurnosReservadosCliente.BackColor = Color.DarkOliveGreen;
            btnAgendaTurnosReservadosCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaTurnosReservadosCliente.ForeColor = Color.White;
            btnAgendaTurnosReservadosCliente.Location = new Point(70, 63);
            btnAgendaTurnosReservadosCliente.Name = "btnAgendaTurnosReservadosCliente";
            btnAgendaTurnosReservadosCliente.Size = new Size(201, 31);
            btnAgendaTurnosReservadosCliente.TabIndex = 2;
            btnAgendaTurnosReservadosCliente.Text = "Buscar";
            btnAgendaTurnosReservadosCliente.UseVisualStyleBackColor = false;
            btnAgendaTurnosReservadosCliente.Click += btnAgendaTurnosReservadosCliente_Click;
            // 
            // txtDNITurnosReservadosCliente
            // 
            txtDNITurnosReservadosCliente.Location = new Point(70, 24);
            txtDNITurnosReservadosCliente.Name = "txtDNITurnosReservadosCliente";
            txtDNITurnosReservadosCliente.Size = new Size(201, 29);
            txtDNITurnosReservadosCliente.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 20);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 8;
            label6.Text = "DNI:";
            // 
            // btnAgendaTurnosLibresMostrar
            // 
            btnAgendaTurnosLibresMostrar.BackColor = Color.DarkOliveGreen;
            btnAgendaTurnosLibresMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaTurnosLibresMostrar.ForeColor = Color.White;
            btnAgendaTurnosLibresMostrar.Location = new Point(649, 672);
            btnAgendaTurnosLibresMostrar.Name = "btnAgendaTurnosLibresMostrar";
            btnAgendaTurnosLibresMostrar.Size = new Size(299, 40);
            btnAgendaTurnosLibresMostrar.TabIndex = 2;
            btnAgendaTurnosLibresMostrar.Text = "Mostrar turnos libres";
            btnAgendaTurnosLibresMostrar.UseVisualStyleBackColor = false;
            btnAgendaTurnosLibresMostrar.Click += btnAgendaTurnosLibresMostrar_Click;
            // 
            // frmAgregaTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1123, 724);
            Controls.Add(btnAgendaTurnosLibresMostrar);
            Controls.Add(groupBox2);
            Controls.Add(btnAgendaEliminaHorario);
            Controls.Add(btnAgendaSalir);
            Controls.Add(dgvAgenda);
            Controls.Add(btnAgendaModificaHorario);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "frmAgregaTurno";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox cmbAgendaClientes;
        private Label label3;
        private CheckedListBox clbAgendaDias;
        private Label label4;
        private Label label5;
        private TextBox txtAgendaBuscarCliente;
        private GroupBox groupBox1;
        private Button btnAgendaBuscar;
        private Button btnAgendaSalir;
        private Button btnAgendaGuardarHorario;
        private Button btnAgendaModificaHorario;
        private Button btnAgendaEliminaHorario;
        private GroupBox groupBox3;
        private DataGridView dgvAgenda;
        private GroupBox groupBox2;
        private Button btnAgendaTurnosReservadosCliente;
        private TextBox txtDNITurnosReservadosCliente;
        private Label label6;
        private Button btnAgendaTurnosLibresMostrar;
        private Button btnAgendaTraerHorarios;
        private CheckedListBox cmbAgendaHorarios;
    }
}