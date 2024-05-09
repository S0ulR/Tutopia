namespace VISTA
{
    partial class frmNuevoDia
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
            txtNuevoDiaNombre = new TextBox();
            label10 = new Label();
            btnNuevoDiaGuardar = new Button();
            label1 = new Label();
            dgvDia = new DataGridView();
            btnNuevoDiaEliminar = new Button();
            btnGestionDiaSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDia).BeginInit();
            SuspendLayout();
            // 
            // txtNuevoDiaNombre
            // 
            txtNuevoDiaNombre.Location = new Point(157, 76);
            txtNuevoDiaNombre.Name = "txtNuevoDiaNombre";
            txtNuevoDiaNombre.Size = new Size(234, 23);
            txtNuevoDiaNombre.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(39, 78);
            label10.Name = "label10";
            label10.Size = new Size(96, 21);
            label10.TabIndex = 21;
            label10.Text = "Nombre día:";
            // 
            // btnNuevoDiaGuardar
            // 
            btnNuevoDiaGuardar.BackColor = Color.DarkOliveGreen;
            btnNuevoDiaGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoDiaGuardar.ForeColor = Color.White;
            btnNuevoDiaGuardar.Location = new Point(39, 117);
            btnNuevoDiaGuardar.Name = "btnNuevoDiaGuardar";
            btnNuevoDiaGuardar.Size = new Size(352, 34);
            btnNuevoDiaGuardar.TabIndex = 20;
            btnNuevoDiaGuardar.Text = "Guardar";
            btnNuevoDiaGuardar.UseVisualStyleBackColor = false;
            btnNuevoDiaGuardar.Click += btnNuevoDiaGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 23;
            label1.Text = "Gestión de días";
            // 
            // dgvDia
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dgvDia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDia.BackgroundColor = Color.MediumSeaGreen;
            dgvDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDia.Location = new Point(39, 167);
            dgvDia.Name = "dgvDia";
            dgvDia.RowTemplate.Height = 25;
            dgvDia.Size = new Size(352, 192);
            dgvDia.TabIndex = 24;
            // 
            // btnNuevoDiaEliminar
            // 
            btnNuevoDiaEliminar.BackColor = Color.DarkOliveGreen;
            btnNuevoDiaEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoDiaEliminar.ForeColor = Color.White;
            btnNuevoDiaEliminar.Location = new Point(39, 383);
            btnNuevoDiaEliminar.Name = "btnNuevoDiaEliminar";
            btnNuevoDiaEliminar.Size = new Size(131, 46);
            btnNuevoDiaEliminar.TabIndex = 25;
            btnNuevoDiaEliminar.Text = "Eliminar";
            btnNuevoDiaEliminar.UseVisualStyleBackColor = false;
            btnNuevoDiaEliminar.Click += btnNuevoDiaEliminar_Click;
            // 
            // btnGestionDiaSalir
            // 
            btnGestionDiaSalir.BackColor = Color.DarkOliveGreen;
            btnGestionDiaSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionDiaSalir.ForeColor = Color.White;
            btnGestionDiaSalir.Location = new Point(260, 383);
            btnGestionDiaSalir.Name = "btnGestionDiaSalir";
            btnGestionDiaSalir.Size = new Size(131, 46);
            btnGestionDiaSalir.TabIndex = 26;
            btnGestionDiaSalir.Text = "Salir";
            btnGestionDiaSalir.UseVisualStyleBackColor = false;
            btnGestionDiaSalir.Click += btnGestionDiaSalir_Click;
            // 
            // frmNuevoDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(428, 450);
            Controls.Add(btnGestionDiaSalir);
            Controls.Add(btnNuevoDiaEliminar);
            Controls.Add(dgvDia);
            Controls.Add(label1);
            Controls.Add(txtNuevoDiaNombre);
            Controls.Add(label10);
            Controls.Add(btnNuevoDiaGuardar);
            Name = "frmNuevoDia";
            ((System.ComponentModel.ISupportInitialize)dgvDia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevoDiaNombre;
        private Label label10;
        private Button btnNuevoDiaGuardar;
        private Label label1;
        private DataGridView dgvDia;
        private Button btnNuevoDiaEliminar;
        private Button btnGestionDiaSalir;
    }
}