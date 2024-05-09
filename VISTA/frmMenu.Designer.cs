namespace VISTA
{
    partial class frmMenu
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnMenuAgenda = new FontAwesome.Sharp.IconButton();
            btnMenuSocios = new FontAwesome.Sharp.IconButton();
            btnMenuSalir = new FontAwesome.Sharp.IconButton();
            btnMenuPago = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 202);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.tutopia5;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 202);
            panel2.TabIndex = 1;
            // 
            // btnMenuAgenda
            // 
            btnMenuAgenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuAgenda.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnMenuAgenda.IconColor = Color.ForestGreen;
            btnMenuAgenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuAgenda.Location = new Point(0, 201);
            btnMenuAgenda.Name = "btnMenuAgenda";
            btnMenuAgenda.Size = new Size(301, 84);
            btnMenuAgenda.TabIndex = 1;
            btnMenuAgenda.Text = "Agenda de Turnos";
            btnMenuAgenda.UseVisualStyleBackColor = true;
            btnMenuAgenda.Click += btnMenuAgenda_Click;
            // 
            // btnMenuSocios
            // 
            btnMenuSocios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuSocios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnMenuSocios.IconColor = Color.ForestGreen;
            btnMenuSocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuSocios.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSocios.Location = new Point(0, 285);
            btnMenuSocios.Name = "btnMenuSocios";
            btnMenuSocios.Size = new Size(301, 84);
            btnMenuSocios.TabIndex = 2;
            btnMenuSocios.Text = "Gestión de Socios";
            btnMenuSocios.UseVisualStyleBackColor = true;
            btnMenuSocios.Click += btnMenuSocios_Click;
            // 
            // btnMenuSalir
            // 
            btnMenuSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuSalir.IconChar = FontAwesome.Sharp.IconChar.CircleStop;
            btnMenuSalir.IconColor = Color.ForestGreen;
            btnMenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSalir.Location = new Point(0, 673);
            btnMenuSalir.Name = "btnMenuSalir";
            btnMenuSalir.Size = new Size(301, 84);
            btnMenuSalir.TabIndex = 4;
            btnMenuSalir.Text = "Salir";
            btnMenuSalir.UseVisualStyleBackColor = true;
            btnMenuSalir.Click += btnMenuSalir_Click;
            // 
            // btnMenuPago
            // 
            btnMenuPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPago.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnMenuPago.IconColor = Color.ForestGreen;
            btnMenuPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuPago.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuPago.Location = new Point(0, 369);
            btnMenuPago.Name = "btnMenuPago";
            btnMenuPago.Size = new Size(301, 84);
            btnMenuPago.TabIndex = 5;
            btnMenuPago.Text = "Pagos";
            btnMenuPago.UseVisualStyleBackColor = true;
            btnMenuPago.Click += btnMenuPago_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1216, 757);
            Controls.Add(btnMenuPago);
            Controls.Add(btnMenuSalir);
            Controls.Add(btnMenuSocios);
            Controls.Add(btnMenuAgenda);
            Controls.Add(panel1);
            ForeColor = Color.ForestGreen;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnMenuAgenda;
        private FontAwesome.Sharp.IconButton btnMenuSocios;
        private FontAwesome.Sharp.IconButton btnMenuSalir;
        private FontAwesome.Sharp.IconButton btnMenuPago;
    }
}