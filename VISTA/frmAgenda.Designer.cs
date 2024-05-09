namespace VISTA
{
    partial class frmAgenda
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
            btnAgendaSalir = new Button();
            dgvAgenda = new DataGridView();
            label6 = new Label();
            btnAgendaNuevoTurno = new Button();
            mcAgenda = new MonthCalendar();
            btnAgendaAgregarDia = new Button();
            cbAgendaLunes = new CheckBox();
            cbAgendaMartes = new CheckBox();
            cbAgendaMiercoles = new CheckBox();
            cbAgendaJueves = new CheckBox();
            cbAgendaViernes = new CheckBox();
            groupBox1 = new GroupBox();
            cbAgendaSabado = new CheckBox();
            btnAgendaAgregarHorario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgendaSalir
            // 
            btnAgendaSalir.BackColor = Color.DarkOliveGreen;
            btnAgendaSalir.ForeColor = Color.White;
            btnAgendaSalir.Location = new Point(1134, 555);
            btnAgendaSalir.Name = "btnAgendaSalir";
            btnAgendaSalir.Size = new Size(129, 31);
            btnAgendaSalir.TabIndex = 4;
            btnAgendaSalir.Text = "Salir";
            btnAgendaSalir.UseVisualStyleBackColor = false;
            btnAgendaSalir.Click += btnAgendaSalir_Click;
            // 
            // dgvAgenda
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgenda.BackgroundColor = Color.MediumSeaGreen;
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(319, 96);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.RowTemplate.Height = 25;
            dgvAgenda.Size = new Size(944, 410);
            dgvAgenda.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(683, 9);
            label6.Name = "label6";
            label6.Size = new Size(166, 50);
            label6.TabIndex = 11;
            label6.Text = "AGENDA";
            // 
            // btnAgendaNuevoTurno
            // 
            btnAgendaNuevoTurno.BackColor = Color.DarkOliveGreen;
            btnAgendaNuevoTurno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaNuevoTurno.ForeColor = Color.White;
            btnAgendaNuevoTurno.Location = new Point(319, 530);
            btnAgendaNuevoTurno.Name = "btnAgendaNuevoTurno";
            btnAgendaNuevoTurno.Size = new Size(248, 56);
            btnAgendaNuevoTurno.TabIndex = 2;
            btnAgendaNuevoTurno.Text = "Agendar nuevo horario";
            btnAgendaNuevoTurno.UseVisualStyleBackColor = false;
            btnAgendaNuevoTurno.Click += btnAgendaNuevoTurno_Click;
            // 
            // mcAgenda
            // 
            mcAgenda.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            mcAgenda.Location = new Point(27, 96);
            mcAgenda.Name = "mcAgenda";
            mcAgenda.TabIndex = 1;
            mcAgenda.TrailingForeColor = SystemColors.GradientActiveCaption;
            // 
            // btnAgendaAgregarDia
            // 
            btnAgendaAgregarDia.BackColor = Color.DarkOliveGreen;
            btnAgendaAgregarDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaAgregarDia.ForeColor = Color.White;
            btnAgendaAgregarDia.Location = new Point(27, 497);
            btnAgendaAgregarDia.Name = "btnAgendaAgregarDia";
            btnAgendaAgregarDia.Size = new Size(248, 41);
            btnAgendaAgregarDia.TabIndex = 12;
            btnAgendaAgregarDia.Text = "Agregar día";
            btnAgendaAgregarDia.UseVisualStyleBackColor = false;
            btnAgendaAgregarDia.Click += btnAgendaAgregarDia_Click;
            // 
            // cbAgendaLunes
            // 
            cbAgendaLunes.AutoSize = true;
            cbAgendaLunes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgendaLunes.ForeColor = Color.White;
            cbAgendaLunes.Location = new Point(83, 28);
            cbAgendaLunes.Name = "cbAgendaLunes";
            cbAgendaLunes.Size = new Size(70, 25);
            cbAgendaLunes.TabIndex = 61;
            cbAgendaLunes.Text = "Lunes";
            cbAgendaLunes.UseVisualStyleBackColor = true;
            cbAgendaLunes.CheckedChanged += cbAgendaLunes_CheckedChanged;
            // 
            // cbAgendaMartes
            // 
            cbAgendaMartes.AutoSize = true;
            cbAgendaMartes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgendaMartes.ForeColor = Color.White;
            cbAgendaMartes.Location = new Point(83, 59);
            cbAgendaMartes.Name = "cbAgendaMartes";
            cbAgendaMartes.Size = new Size(77, 25);
            cbAgendaMartes.TabIndex = 62;
            cbAgendaMartes.Text = "Martes";
            cbAgendaMartes.UseVisualStyleBackColor = true;
            cbAgendaMartes.CheckedChanged += cbAgendaMartes_CheckedChanged;
            // 
            // cbAgendaMiercoles
            // 
            cbAgendaMiercoles.AutoSize = true;
            cbAgendaMiercoles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgendaMiercoles.ForeColor = Color.White;
            cbAgendaMiercoles.Location = new Point(83, 90);
            cbAgendaMiercoles.Name = "cbAgendaMiercoles";
            cbAgendaMiercoles.Size = new Size(96, 25);
            cbAgendaMiercoles.TabIndex = 63;
            cbAgendaMiercoles.Text = "Miércoles";
            cbAgendaMiercoles.UseVisualStyleBackColor = true;
            cbAgendaMiercoles.CheckedChanged += cbAgendaMiercoles_CheckedChanged;
            // 
            // cbAgendaJueves
            // 
            cbAgendaJueves.AutoSize = true;
            cbAgendaJueves.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgendaJueves.ForeColor = Color.White;
            cbAgendaJueves.Location = new Point(83, 121);
            cbAgendaJueves.Name = "cbAgendaJueves";
            cbAgendaJueves.Size = new Size(75, 25);
            cbAgendaJueves.TabIndex = 64;
            cbAgendaJueves.Text = "Jueves";
            cbAgendaJueves.UseVisualStyleBackColor = true;
            cbAgendaJueves.CheckedChanged += cbAgendaJueves_CheckedChanged;
            // 
            // cbAgendaViernes
            // 
            cbAgendaViernes.AutoSize = true;
            cbAgendaViernes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgendaViernes.ForeColor = Color.White;
            cbAgendaViernes.Location = new Point(83, 152);
            cbAgendaViernes.Name = "cbAgendaViernes";
            cbAgendaViernes.Size = new Size(81, 25);
            cbAgendaViernes.TabIndex = 65;
            cbAgendaViernes.Text = "Viernes";
            cbAgendaViernes.UseVisualStyleBackColor = true;
            cbAgendaViernes.CheckedChanged += cbAgendaViernes_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAgendaSabado);
            groupBox1.Controls.Add(cbAgendaViernes);
            groupBox1.Controls.Add(cbAgendaMartes);
            groupBox1.Controls.Add(cbAgendaJueves);
            groupBox1.Controls.Add(cbAgendaLunes);
            groupBox1.Controls.Add(cbAgendaMiercoles);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 212);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar por día";
            // 
            // cbAgendaSabado
            // 
            cbAgendaSabado.AutoSize = true;
            cbAgendaSabado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAgendaSabado.ForeColor = Color.White;
            cbAgendaSabado.Location = new Point(83, 183);
            cbAgendaSabado.Name = "cbAgendaSabado";
            cbAgendaSabado.Size = new Size(81, 25);
            cbAgendaSabado.TabIndex = 66;
            cbAgendaSabado.Text = "Sábado";
            cbAgendaSabado.UseVisualStyleBackColor = true;
            cbAgendaSabado.CheckedChanged += cbAgendaSabado_CheckedChanged;
            // 
            // btnAgendaAgregarHorario
            // 
            btnAgendaAgregarHorario.BackColor = Color.DarkOliveGreen;
            btnAgendaAgregarHorario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendaAgregarHorario.ForeColor = Color.White;
            btnAgendaAgregarHorario.Location = new Point(27, 544);
            btnAgendaAgregarHorario.Name = "btnAgendaAgregarHorario";
            btnAgendaAgregarHorario.Size = new Size(248, 41);
            btnAgendaAgregarHorario.TabIndex = 67;
            btnAgendaAgregarHorario.Text = "Agregar Horario";
            btnAgendaAgregarHorario.UseVisualStyleBackColor = false;
            btnAgendaAgregarHorario.Click += btnAgendaAgregarHorario_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1279, 602);
            Controls.Add(btnAgendaAgregarHorario);
            Controls.Add(btnAgendaAgregarDia);
            Controls.Add(mcAgenda);
            Controls.Add(btnAgendaNuevoTurno);
            Controls.Add(btnAgendaSalir);
            Controls.Add(dgvAgenda);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgendaSalir;
        private DataGridView dgvAgenda;
        private Label label6;
        private Button btnAgendaNuevoTurno;
        public MonthCalendar mcAgenda;
        private Button btnAgendaAgregarDia;
        private CheckBox cbAgendaLunes;
        private CheckBox cbAgendaMartes;
        private CheckBox cbAgendaMiercoles;
        private CheckBox cbAgendaJueves;
        private CheckBox cbAgendaViernes;
        private GroupBox groupBox1;
        private CheckBox cbAgendaSabado;
        private Button btnAgendaAgregarHorario;
    }
}