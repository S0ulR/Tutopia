namespace VISTA
{
    partial class frmImagenAmpliada
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
            pbImagenAmpliada = new PictureBox();
            btnImagenAmpliadaSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagenAmpliada).BeginInit();
            SuspendLayout();
            // 
            // pbImagenAmpliada
            // 
            pbImagenAmpliada.Location = new Point(9, 7);
            pbImagenAmpliada.Name = "pbImagenAmpliada";
            pbImagenAmpliada.Size = new Size(1092, 729);
            pbImagenAmpliada.TabIndex = 0;
            pbImagenAmpliada.TabStop = false;
            // 
            // btnImagenAmpliadaSalir
            // 
            btnImagenAmpliadaSalir.BackColor = Color.DarkOliveGreen;
            btnImagenAmpliadaSalir.ForeColor = Color.White;
            btnImagenAmpliadaSalir.Location = new Point(972, 742);
            btnImagenAmpliadaSalir.Name = "btnImagenAmpliadaSalir";
            btnImagenAmpliadaSalir.Size = new Size(129, 31);
            btnImagenAmpliadaSalir.TabIndex = 17;
            btnImagenAmpliadaSalir.Text = "Salir";
            btnImagenAmpliadaSalir.UseVisualStyleBackColor = false;
            btnImagenAmpliadaSalir.Click += btnImagenAmpliadaSalir_Click;
            // 
            // frmImagenAmpliada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1105, 775);
            Controls.Add(btnImagenAmpliadaSalir);
            Controls.Add(pbImagenAmpliada);
            Name = "frmImagenAmpliada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmImagenAmpliada";
            ((System.ComponentModel.ISupportInitialize)pbImagenAmpliada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImagenAmpliada;
        private Button btnImagenAmpliadaSalir;
    }
}