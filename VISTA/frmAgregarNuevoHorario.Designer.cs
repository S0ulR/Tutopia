namespace VISTA
{
    partial class frmAgregarNuevoHorario
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
            groupBox2 = new GroupBox();
            txtNuevoHorarioCupos = new TextBox();
            label10 = new Label();
            cmbDia = new ComboBox();
            label8 = new Label();
            btnAgendaNuevoHorarioGuardar = new Button();
            txtNuevoHorarioHora = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnNuevoHorarioSalir = new Button();
            dgvHorarios = new DataGridView();
            btnNuevoHorarioModificar = new Button();
            btnNuevoHorarioEiminar = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNuevoHorarioCupos);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cmbDia);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnAgendaNuevoHorarioGuardar);
            groupBox2.Controls.Add(txtNuevoHorarioHora);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(37, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 150);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar nuevo horario:";
            // 
            // txtNuevoHorarioCupos
            // 
            txtNuevoHorarioCupos.Location = new Point(128, 97);
            txtNuevoHorarioCupos.Name = "txtNuevoHorarioCupos";
            txtNuevoHorarioCupos.Size = new Size(320, 29);
            txtNuevoHorarioCupos.TabIndex = 19;
            txtNuevoHorarioCupos.Text = "4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(26, 102);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 18;
            label10.Text = "Cupos:";
            // 
            // cmbDia
            // 
            cmbDia.FormattingEnabled = true;
            cmbDia.Location = new Point(128, 47);
            cmbDia.Name = "cmbDia";
            cmbDia.Size = new Size(320, 29);
            cmbDia.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 47);
            label8.Name = "label8";
            label8.Size = new Size(36, 21);
            label8.TabIndex = 10;
            label8.Text = "Día:";
            // 
            // btnAgendaNuevoHorarioGuardar
            // 
            btnAgendaNuevoHorarioGuardar.BackColor = Color.DarkOliveGreen;
            btnAgendaNuevoHorarioGuardar.ForeColor = Color.White;
            btnAgendaNuevoHorarioGuardar.Location = new Point(595, 87);
            btnAgendaNuevoHorarioGuardar.Name = "btnAgendaNuevoHorarioGuardar";
            btnAgendaNuevoHorarioGuardar.Size = new Size(327, 46);
            btnAgendaNuevoHorarioGuardar.TabIndex = 13;
            btnAgendaNuevoHorarioGuardar.Text = "Grabar nuevo horario";
            btnAgendaNuevoHorarioGuardar.UseVisualStyleBackColor = false;
            btnAgendaNuevoHorarioGuardar.Click += btnAgendaNuevoHorarioGuardar_Click;
            // 
            // txtNuevoHorarioHora
            // 
            txtNuevoHorarioHora.Location = new Point(595, 47);
            txtNuevoHorarioHora.Multiline = true;
            txtNuevoHorarioHora.Name = "txtNuevoHorarioHora";
            txtNuevoHorarioHora.PlaceholderText = "hh:mm";
            txtNuevoHorarioHora.Size = new Size(320, 29);
            txtNuevoHorarioHora.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(500, 50);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 8;
            label6.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(364, 20);
            label2.Name = "label2";
            label2.Size = new Size(426, 50);
            label2.TabIndex = 13;
            label2.Text = "Agregar nuevos horarios";
            // 
            // btnNuevoHorarioSalir
            // 
            btnNuevoHorarioSalir.BackColor = Color.DarkOliveGreen;
            btnNuevoHorarioSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoHorarioSalir.ForeColor = Color.White;
            btnNuevoHorarioSalir.Location = new Point(828, 550);
            btnNuevoHorarioSalir.Name = "btnNuevoHorarioSalir";
            btnNuevoHorarioSalir.Size = new Size(213, 41);
            btnNuevoHorarioSalir.TabIndex = 18;
            btnNuevoHorarioSalir.Text = "Salir";
            btnNuevoHorarioSalir.UseVisualStyleBackColor = false;
            btnNuevoHorarioSalir.Click += btnNuevoHorarioSalir_Click;
            // 
            // dgvHorarios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dgvHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHorarios.BackgroundColor = Color.MediumSeaGreen;
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarios.Location = new Point(37, 252);
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.RowTemplate.Height = 25;
            dgvHorarios.Size = new Size(1004, 277);
            dgvHorarios.TabIndex = 19;
            // 
            // btnNuevoHorarioModificar
            // 
            btnNuevoHorarioModificar.BackColor = Color.DarkOliveGreen;
            btnNuevoHorarioModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoHorarioModificar.ForeColor = Color.White;
            btnNuevoHorarioModificar.Location = new Point(37, 550);
            btnNuevoHorarioModificar.Name = "btnNuevoHorarioModificar";
            btnNuevoHorarioModificar.Size = new Size(213, 41);
            btnNuevoHorarioModificar.TabIndex = 20;
            btnNuevoHorarioModificar.Text = "Modificar";
            btnNuevoHorarioModificar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoHorarioEiminar
            // 
            btnNuevoHorarioEiminar.BackColor = Color.DarkOliveGreen;
            btnNuevoHorarioEiminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoHorarioEiminar.ForeColor = Color.White;
            btnNuevoHorarioEiminar.Location = new Point(289, 550);
            btnNuevoHorarioEiminar.Name = "btnNuevoHorarioEiminar";
            btnNuevoHorarioEiminar.Size = new Size(213, 41);
            btnNuevoHorarioEiminar.TabIndex = 21;
            btnNuevoHorarioEiminar.Text = "Eliminar";
            btnNuevoHorarioEiminar.UseVisualStyleBackColor = false;
            // 
            // frmAgregarNuevoHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1069, 603);
            Controls.Add(btnNuevoHorarioEiminar);
            Controls.Add(btnNuevoHorarioModificar);
            Controls.Add(dgvHorarios);
            Controls.Add(btnNuevoHorarioSalir);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Name = "frmAgregarNuevoHorario";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cmbDia;
        private Label label8;
        private Button btnAgendaNuevoHorarioGuardar;
        private TextBox txtNuevoHorarioHora;
        private Label label6;
        private Label label2;
        private Button btnNuevoHorarioSalir;
        private TextBox txtNuevoHorarioCupos;
        private Label label10;
        private DataGridView dgvHorarios;
        private Button btnNuevoHorarioModificar;
        private Button btnNuevoHorarioEiminar;
    }
}