namespace Apartado_de_Libros_proyecto_progra_III
{
    partial class AddLibro1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLibro1));
            ImagenLibroPictureBox = new PictureBox();
            NombreDelLibroLabel = new Label();
            NombrarLibroTextBox = new TextBox();
            SubirImagenLibroBoton = new Button();
            RegistrarNuevoAutorLabel = new Label();
            SeleccionarAutorLabel = new Label();
            RegistrarAutorTextBox = new TextBox();
            SeleccionarAutorComboBox = new ComboBox();
            NumeroPaginasLabel = new Label();
            NumeroPaginasNumericUpDown = new NumericUpDown();
            GeneroLiterarioLabel = new Label();
            GeneroLiterarioComboBox = new ComboBox();
            CalificacionLabel = new Label();
            ComentarioTextBox = new TextBox();
            ComentarioLabel = new Label();
            FechaInicioDateTimePicker = new DateTimePicker();
            FechaDeFinalizacionDateTimePicker = new DateTimePicker();
            FechaDeInicioLabel = new Label();
            FechaFinalLabel = new Label();
            GuardarInformacionLibroBoton = new Button();
            numUpDownCalificacionEstrellas = new NumericUpDown();
            lblEstrellas = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenLibroPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroPaginasNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCalificacionEstrellas).BeginInit();
            SuspendLayout();
            // 
            // ImagenLibroPictureBox
            // 
            ImagenLibroPictureBox.BackColor = Color.White;
            ImagenLibroPictureBox.Location = new Point(20, 19);
            ImagenLibroPictureBox.Margin = new Padding(3, 2, 3, 2);
            ImagenLibroPictureBox.Name = "ImagenLibroPictureBox";
            ImagenLibroPictureBox.Size = new Size(257, 334);
            ImagenLibroPictureBox.TabIndex = 0;
            ImagenLibroPictureBox.TabStop = false;
            ImagenLibroPictureBox.Click += ImagenLibroPictureBox_Click;
            // 
            // NombreDelLibroLabel
            // 
            NombreDelLibroLabel.AutoSize = true;
            NombreDelLibroLabel.BackColor = Color.Transparent;
            NombreDelLibroLabel.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreDelLibroLabel.Location = new Point(292, 19);
            NombreDelLibroLabel.Name = "NombreDelLibroLabel";
            NombreDelLibroLabel.Size = new Size(176, 28);
            NombreDelLibroLabel.TabIndex = 1;
            NombreDelLibroLabel.Text = "Nombre del Libro:";
            // 
            // NombrarLibroTextBox
            // 
            NombrarLibroTextBox.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombrarLibroTextBox.Location = new Point(292, 50);
            NombrarLibroTextBox.Margin = new Padding(3, 2, 3, 2);
            NombrarLibroTextBox.Multiline = true;
            NombrarLibroTextBox.Name = "NombrarLibroTextBox";
            NombrarLibroTextBox.Size = new Size(398, 25);
            NombrarLibroTextBox.TabIndex = 2;
            // 
            // SubirImagenLibroBoton
            // 
            SubirImagenLibroBoton.BackColor = Color.Lavender;
            SubirImagenLibroBoton.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubirImagenLibroBoton.Location = new Point(80, 357);
            SubirImagenLibroBoton.Margin = new Padding(3, 2, 3, 2);
            SubirImagenLibroBoton.Name = "SubirImagenLibroBoton";
            SubirImagenLibroBoton.Size = new Size(154, 26);
            SubirImagenLibroBoton.TabIndex = 3;
            SubirImagenLibroBoton.Text = "Subir imagen del libro";
            SubirImagenLibroBoton.UseVisualStyleBackColor = false;
            SubirImagenLibroBoton.Click += SubirImagenLibroBoton_Click;
            // 
            // RegistrarNuevoAutorLabel
            // 
            RegistrarNuevoAutorLabel.AutoSize = true;
            RegistrarNuevoAutorLabel.BackColor = Color.Transparent;
            RegistrarNuevoAutorLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrarNuevoAutorLabel.Location = new Point(292, 93);
            RegistrarNuevoAutorLabel.Name = "RegistrarNuevoAutorLabel";
            RegistrarNuevoAutorLabel.Size = new Size(177, 23);
            RegistrarNuevoAutorLabel.TabIndex = 4;
            RegistrarNuevoAutorLabel.Text = "Registrar Nuevo Autor";
            // 
            // SeleccionarAutorLabel
            // 
            SeleccionarAutorLabel.AutoSize = true;
            SeleccionarAutorLabel.BackColor = Color.Transparent;
            SeleccionarAutorLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SeleccionarAutorLabel.Location = new Point(292, 148);
            SeleccionarAutorLabel.Name = "SeleccionarAutorLabel";
            SeleccionarAutorLabel.Size = new Size(142, 23);
            SeleccionarAutorLabel.TabIndex = 5;
            SeleccionarAutorLabel.Text = "Seleccionar Autor";
            // 
            // RegistrarAutorTextBox
            // 
            RegistrarAutorTextBox.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrarAutorTextBox.Location = new Point(292, 117);
            RegistrarAutorTextBox.Margin = new Padding(3, 2, 3, 2);
            RegistrarAutorTextBox.Name = "RegistrarAutorTextBox";
            RegistrarAutorTextBox.Size = new Size(267, 22);
            RegistrarAutorTextBox.TabIndex = 6;
            RegistrarAutorTextBox.TextChanged += RegistrarAutorTextBox_TextChanged;
            RegistrarAutorTextBox.KeyDown += RegistrarAutorTextBox_KeyDown;
            // 
            // SeleccionarAutorComboBox
            // 
            SeleccionarAutorComboBox.FormattingEnabled = true;
            SeleccionarAutorComboBox.Location = new Point(292, 172);
            SeleccionarAutorComboBox.Margin = new Padding(3, 2, 3, 2);
            SeleccionarAutorComboBox.Name = "SeleccionarAutorComboBox";
            SeleccionarAutorComboBox.Size = new Size(267, 23);
            SeleccionarAutorComboBox.TabIndex = 7;
            SeleccionarAutorComboBox.SelectedIndexChanged += SeleccionarAutorComboBox_SelectedIndexChanged;
            // 
            // NumeroPaginasLabel
            // 
            NumeroPaginasLabel.AutoSize = true;
            NumeroPaginasLabel.BackColor = Color.Transparent;
            NumeroPaginasLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumeroPaginasLabel.Location = new Point(292, 205);
            NumeroPaginasLabel.Name = "NumeroPaginasLabel";
            NumeroPaginasLabel.Size = new Size(154, 23);
            NumeroPaginasLabel.TabIndex = 8;
            NumeroPaginasLabel.Text = "Numero de paginas";
            // 
            // NumeroPaginasNumericUpDown
            // 
            NumeroPaginasNumericUpDown.Location = new Point(292, 229);
            NumeroPaginasNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            NumeroPaginasNumericUpDown.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            NumeroPaginasNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumeroPaginasNumericUpDown.Name = "NumeroPaginasNumericUpDown";
            NumeroPaginasNumericUpDown.Size = new Size(170, 23);
            NumeroPaginasNumericUpDown.TabIndex = 9;
            NumeroPaginasNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // GeneroLiterarioLabel
            // 
            GeneroLiterarioLabel.AutoSize = true;
            GeneroLiterarioLabel.BackColor = Color.Transparent;
            GeneroLiterarioLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GeneroLiterarioLabel.Location = new Point(292, 259);
            GeneroLiterarioLabel.Name = "GeneroLiterarioLabel";
            GeneroLiterarioLabel.Size = new Size(133, 23);
            GeneroLiterarioLabel.TabIndex = 10;
            GeneroLiterarioLabel.Text = "Genero Literario";
            // 
            // GeneroLiterarioComboBox
            // 
            GeneroLiterarioComboBox.FormattingEnabled = true;
            GeneroLiterarioComboBox.Location = new Point(292, 283);
            GeneroLiterarioComboBox.Margin = new Padding(3, 2, 3, 2);
            GeneroLiterarioComboBox.Name = "GeneroLiterarioComboBox";
            GeneroLiterarioComboBox.Size = new Size(267, 23);
            GeneroLiterarioComboBox.TabIndex = 11;
            GeneroLiterarioComboBox.SelectedIndexChanged += GeneroLiterarioComboBox_SelectedIndexChanged;
            // 
            // CalificacionLabel
            // 
            CalificacionLabel.AutoSize = true;
            CalificacionLabel.BackColor = Color.Transparent;
            CalificacionLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalificacionLabel.Location = new Point(292, 313);
            CalificacionLabel.Name = "CalificacionLabel";
            CalificacionLabel.Size = new Size(99, 23);
            CalificacionLabel.TabIndex = 12;
            CalificacionLabel.Text = "Calificacion";
            // 
            // ComentarioTextBox
            // 
            ComentarioTextBox.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComentarioTextBox.Location = new Point(10, 482);
            ComentarioTextBox.Margin = new Padding(3, 2, 3, 2);
            ComentarioTextBox.Multiline = true;
            ComentarioTextBox.Name = "ComentarioTextBox";
            ComentarioTextBox.Size = new Size(680, 178);
            ComentarioTextBox.TabIndex = 13;
            ComentarioTextBox.KeyDown += ComentarioTextBox_KeyDown;
            // 
            // ComentarioLabel
            // 
            ComentarioLabel.AutoSize = true;
            ComentarioLabel.BackColor = Color.Transparent;
            ComentarioLabel.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComentarioLabel.Location = new Point(248, 445);
            ComentarioLabel.Name = "ComentarioLabel";
            ComentarioLabel.Size = new Size(200, 28);
            ComentarioLabel.TabIndex = 14;
            ComentarioLabel.Text = "Comentario ó Reseña";
            // 
            // FechaInicioDateTimePicker
            // 
            FechaInicioDateTimePicker.Location = new Point(80, 414);
            FechaInicioDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            FechaInicioDateTimePicker.Size = new Size(239, 23);
            FechaInicioDateTimePicker.TabIndex = 15;
            // 
            // FechaDeFinalizacionDateTimePicker
            // 
            FechaDeFinalizacionDateTimePicker.Location = new Point(366, 414);
            FechaDeFinalizacionDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaDeFinalizacionDateTimePicker.Name = "FechaDeFinalizacionDateTimePicker";
            FechaDeFinalizacionDateTimePicker.Size = new Size(250, 23);
            FechaDeFinalizacionDateTimePicker.TabIndex = 16;
            // 
            // FechaDeInicioLabel
            // 
            FechaDeInicioLabel.AutoSize = true;
            FechaDeInicioLabel.BackColor = Color.Transparent;
            FechaDeInicioLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaDeInicioLabel.Location = new Point(136, 390);
            FechaDeInicioLabel.Name = "FechaDeInicioLabel";
            FechaDeInicioLabel.Size = new Size(124, 23);
            FechaDeInicioLabel.TabIndex = 17;
            FechaDeInicioLabel.Text = "Fecha de Inicio";
            FechaDeInicioLabel.Click += label8_Click;
            // 
            // FechaFinalLabel
            // 
            FechaFinalLabel.AutoSize = true;
            FechaFinalLabel.BackColor = Color.Transparent;
            FechaFinalLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaFinalLabel.Location = new Point(393, 390);
            FechaFinalLabel.Name = "FechaFinalLabel";
            FechaFinalLabel.Size = new Size(173, 23);
            FechaFinalLabel.TabIndex = 18;
            FechaFinalLabel.Text = "Fecha de Finalizacion";
            FechaFinalLabel.Click += label9_Click;
            // 
            // GuardarInformacionLibroBoton
            // 
            GuardarInformacionLibroBoton.BackColor = Color.Lavender;
            GuardarInformacionLibroBoton.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuardarInformacionLibroBoton.Location = new Point(256, 670);
            GuardarInformacionLibroBoton.Margin = new Padding(3, 2, 3, 2);
            GuardarInformacionLibroBoton.Name = "GuardarInformacionLibroBoton";
            GuardarInformacionLibroBoton.Size = new Size(206, 44);
            GuardarInformacionLibroBoton.TabIndex = 19;
            GuardarInformacionLibroBoton.Text = "Guardar Libro";
            GuardarInformacionLibroBoton.UseVisualStyleBackColor = false;
            GuardarInformacionLibroBoton.Click += GuardarInformacionLibroBoton_Click;
            // 
            // numUpDownCalificacionEstrellas
            // 
            numUpDownCalificacionEstrellas.Location = new Point(290, 339);
            numUpDownCalificacionEstrellas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDownCalificacionEstrellas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownCalificacionEstrellas.Name = "numUpDownCalificacionEstrellas";
            numUpDownCalificacionEstrellas.Size = new Size(29, 23);
            numUpDownCalificacionEstrellas.TabIndex = 20;
            numUpDownCalificacionEstrellas.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDownCalificacionEstrellas.ValueChanged += numCalificacion_ValueChanged;
            // 
            // lblEstrellas
            // 
            lblEstrellas.AutoSize = true;
            lblEstrellas.BackColor = Color.Transparent;
            lblEstrellas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstrellas.ForeColor = Color.FromArgb(128, 128, 255);
            lblEstrellas.Location = new Point(317, 336);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(103, 30);
            lblEstrellas.TabIndex = 21;
            lblEstrellas.Text = "★★★★★";
            // 
            // AddLibro1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 373);
            Controls.Add(lblEstrellas);
            Controls.Add(numUpDownCalificacionEstrellas);
            Controls.Add(GuardarInformacionLibroBoton);
            Controls.Add(FechaFinalLabel);
            Controls.Add(FechaDeInicioLabel);
            Controls.Add(FechaDeFinalizacionDateTimePicker);
            Controls.Add(FechaInicioDateTimePicker);
            Controls.Add(ComentarioLabel);
            Controls.Add(ComentarioTextBox);
            Controls.Add(CalificacionLabel);
            Controls.Add(GeneroLiterarioComboBox);
            Controls.Add(GeneroLiterarioLabel);
            Controls.Add(NumeroPaginasNumericUpDown);
            Controls.Add(NumeroPaginasLabel);
            Controls.Add(SeleccionarAutorComboBox);
            Controls.Add(RegistrarAutorTextBox);
            Controls.Add(SeleccionarAutorLabel);
            Controls.Add(RegistrarNuevoAutorLabel);
            Controls.Add(SubirImagenLibroBoton);
            Controls.Add(NombrarLibroTextBox);
            Controls.Add(NombreDelLibroLabel);
            Controls.Add(ImagenLibroPictureBox);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddLibro1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The BookWorm Society";
            Load += AddLibroForm1_Load;
            ((System.ComponentModel.ISupportInitialize)ImagenLibroPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumeroPaginasNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCalificacionEstrellas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImagenLibroPictureBox;
        private Label NombreDelLibroLabel;
        private TextBox NombrarLibroTextBox;
        private Button SubirImagenLibroBoton;
        private Label RegistrarNuevoAutorLabel;
        private Label SeleccionarAutorLabel;
        private TextBox RegistrarAutorTextBox;
        private ComboBox SeleccionarAutorComboBox;
        private Label NumeroPaginasLabel;
        private NumericUpDown NumeroPaginasNumericUpDown;
        private Label GeneroLiterarioLabel;
        private ComboBox GeneroLiterarioComboBox;
        private Label CalificacionLabel;
        private TextBox ComentarioTextBox;
        private Label ComentarioLabel;
        private DateTimePicker FechaInicioDateTimePicker;
        private DateTimePicker FechaDeFinalizacionDateTimePicker;
        private Label FechaDeInicioLabel;
        private Label FechaFinalLabel;
        private Button GuardarInformacionLibroBoton;
        private NumericUpDown numUpDownCalificacionEstrellas;
        private Label lblEstrellas;
    }
}
