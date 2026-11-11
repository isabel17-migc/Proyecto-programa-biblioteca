namespace pantalla_inicio
{
    partial class LibroPlantilla
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            LblTitulo = new Label();
            PicPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicPortada).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(34, 150);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(38, 13);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "label1";
            // 
            // PicPortada
            // 
            PicPortada.Location = new Point(0, 0);
            PicPortada.Name = "PicPortada";
            PicPortada.Size = new Size(106, 147);
            PicPortada.TabIndex = 1;
            PicPortada.TabStop = false;
            // 
            // LibroPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PicPortada);
            Controls.Add(LblTitulo);
            Name = "LibroPlantilla";
            Size = new Size(105, 166);
            ((System.ComponentModel.ISupportInitialize)PicPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private PictureBox PicPortada;
    }
}
