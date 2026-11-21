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
            btnRegresar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)ImagenLibroPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroPaginasNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCalificacionEstrellas).BeginInit();
            SuspendLayout();
            // 
            // ImagenLibroPictureBox
            // 
            ImagenLibroPictureBox.BackColor = Color.White;
            ImagenLibroPictureBox.Location = new Point(23, 25);
            ImagenLibroPictureBox.Name = "ImagenLibroPictureBox";
            ImagenLibroPictureBox.Size = new Size(294, 445);
            ImagenLibroPictureBox.TabIndex = 0;
            ImagenLibroPictureBox.TabStop = false;
            ImagenLibroPictureBox.Click += ImagenLibroPictureBox_Click;
            // 
            // NombreDelLibroLabel
            // 
            NombreDelLibroLabel.AutoSize = true;
            NombreDelLibroLabel.BackColor = Color.Transparent;
            NombreDelLibroLabel.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreDelLibroLabel.Location = new Point(334, 25);
            NombreDelLibroLabel.Name = "NombreDelLibroLabel";
            NombreDelLibroLabel.Size = new Size(212, 33);
            NombreDelLibroLabel.TabIndex = 1;
            NombreDelLibroLabel.Text = "Nombre del Libro:";
            // 
            // NombrarLibroTextBox
            // 
            NombrarLibroTextBox.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombrarLibroTextBox.Location = new Point(334, 67);
            NombrarLibroTextBox.Multiline = true;
            NombrarLibroTextBox.Name = "NombrarLibroTextBox";
            NombrarLibroTextBox.Size = new Size(454, 32);
            NombrarLibroTextBox.TabIndex = 2;
            NombrarLibroTextBox.TextChanged += NombrarLibroTextBox_TextChanged;
            // 
            // SubirImagenLibroBoton
            // 
            SubirImagenLibroBoton.BackColor = Color.Lavender;
            SubirImagenLibroBoton.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubirImagenLibroBoton.Location = new Point(91, 476);
            SubirImagenLibroBoton.Name = "SubirImagenLibroBoton";
            SubirImagenLibroBoton.Size = new Size(176, 35);
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
            RegistrarNuevoAutorLabel.Location = new Point(334, 124);
            RegistrarNuevoAutorLabel.Name = "RegistrarNuevoAutorLabel";
            RegistrarNuevoAutorLabel.Size = new Size(223, 29);
            RegistrarNuevoAutorLabel.TabIndex = 4;
            RegistrarNuevoAutorLabel.Text = "Registrar Nuevo Autor";
            // 
            // SeleccionarAutorLabel
            // 
            SeleccionarAutorLabel.AutoSize = true;
            SeleccionarAutorLabel.BackColor = Color.Transparent;
            SeleccionarAutorLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SeleccionarAutorLabel.Location = new Point(334, 197);
            SeleccionarAutorLabel.Name = "SeleccionarAutorLabel";
            SeleccionarAutorLabel.Size = new Size(178, 29);
            SeleccionarAutorLabel.TabIndex = 5;
            SeleccionarAutorLabel.Text = "Seleccionar Autor";
            // 
            // RegistrarAutorTextBox
            // 
            RegistrarAutorTextBox.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrarAutorTextBox.Location = new Point(334, 156);
            RegistrarAutorTextBox.Name = "RegistrarAutorTextBox";
            RegistrarAutorTextBox.Size = new Size(305, 26);
            RegistrarAutorTextBox.TabIndex = 6;
            RegistrarAutorTextBox.TextChanged += RegistrarAutorTextBox_TextChanged;
            RegistrarAutorTextBox.KeyDown += RegistrarAutorTextBox_KeyDown;
            // 
            // SeleccionarAutorComboBox
            // 
            SeleccionarAutorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SeleccionarAutorComboBox.FormattingEnabled = true;
            SeleccionarAutorComboBox.Location = new Point(334, 229);
            SeleccionarAutorComboBox.Name = "SeleccionarAutorComboBox";
            SeleccionarAutorComboBox.Size = new Size(305, 28);
            SeleccionarAutorComboBox.TabIndex = 7;
            SeleccionarAutorComboBox.SelectedIndexChanged += SeleccionarAutorComboBox_SelectedIndexChanged;
            // 
            // NumeroPaginasLabel
            // 
            NumeroPaginasLabel.AutoSize = true;
            NumeroPaginasLabel.BackColor = Color.Transparent;
            NumeroPaginasLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumeroPaginasLabel.Location = new Point(334, 273);
            NumeroPaginasLabel.Name = "NumeroPaginasLabel";
            NumeroPaginasLabel.Size = new Size(194, 29);
            NumeroPaginasLabel.TabIndex = 8;
            NumeroPaginasLabel.Text = "Numero de paginas";
            // 
            // NumeroPaginasNumericUpDown
            // 
            NumeroPaginasNumericUpDown.Location = new Point(334, 305);
            NumeroPaginasNumericUpDown.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            NumeroPaginasNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumeroPaginasNumericUpDown.Name = "NumeroPaginasNumericUpDown";
            NumeroPaginasNumericUpDown.Size = new Size(194, 27);
            NumeroPaginasNumericUpDown.TabIndex = 9;
            NumeroPaginasNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // GeneroLiterarioLabel
            // 
            GeneroLiterarioLabel.AutoSize = true;
            GeneroLiterarioLabel.BackColor = Color.Transparent;
            GeneroLiterarioLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GeneroLiterarioLabel.Location = new Point(334, 345);
            GeneroLiterarioLabel.Name = "GeneroLiterarioLabel";
            GeneroLiterarioLabel.Size = new Size(167, 29);
            GeneroLiterarioLabel.TabIndex = 10;
            GeneroLiterarioLabel.Text = "Genero Literario";
            // 
            // GeneroLiterarioComboBox
            // 
            GeneroLiterarioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GeneroLiterarioComboBox.FormattingEnabled = true;
            GeneroLiterarioComboBox.Location = new Point(334, 377);
            GeneroLiterarioComboBox.Name = "GeneroLiterarioComboBox";
            GeneroLiterarioComboBox.Size = new Size(305, 28);
            GeneroLiterarioComboBox.TabIndex = 11;
            GeneroLiterarioComboBox.SelectedIndexChanged += GeneroLiterarioComboBox_SelectedIndexChanged;
            // 
            // CalificacionLabel
            // 
            CalificacionLabel.AutoSize = true;
            CalificacionLabel.BackColor = Color.Transparent;
            CalificacionLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalificacionLabel.Location = new Point(334, 417);
            CalificacionLabel.Name = "CalificacionLabel";
            CalificacionLabel.Size = new Size(123, 29);
            CalificacionLabel.TabIndex = 12;
            CalificacionLabel.Text = "Calificacion";
            // 
            // ComentarioTextBox
            // 
            ComentarioTextBox.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComentarioTextBox.Location = new Point(11, 643);
            ComentarioTextBox.Multiline = true;
            ComentarioTextBox.Name = "ComentarioTextBox";
            ComentarioTextBox.Size = new Size(777, 176);
            ComentarioTextBox.TabIndex = 13;
            ComentarioTextBox.KeyDown += ComentarioTextBox_KeyDown;
            // 
            // ComentarioLabel
            // 
            ComentarioLabel.AutoSize = true;
            ComentarioLabel.BackColor = Color.Transparent;
            ComentarioLabel.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComentarioLabel.Location = new Point(283, 593);
            ComentarioLabel.Name = "ComentarioLabel";
            ComentarioLabel.Size = new Size(244, 33);
            ComentarioLabel.TabIndex = 14;
            ComentarioLabel.Text = "Comentario ó Reseña";
            // 
            // FechaInicioDateTimePicker
            // 
            FechaInicioDateTimePicker.Location = new Point(91, 552);
            FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            FechaInicioDateTimePicker.Size = new Size(273, 27);
            FechaInicioDateTimePicker.TabIndex = 15;
            // 
            // FechaDeFinalizacionDateTimePicker
            // 
            FechaDeFinalizacionDateTimePicker.Location = new Point(418, 552);
            FechaDeFinalizacionDateTimePicker.Name = "FechaDeFinalizacionDateTimePicker";
            FechaDeFinalizacionDateTimePicker.Size = new Size(285, 27);
            FechaDeFinalizacionDateTimePicker.TabIndex = 16;
            // 
            // FechaDeInicioLabel
            // 
            FechaDeInicioLabel.AutoSize = true;
            FechaDeInicioLabel.BackColor = Color.Transparent;
            FechaDeInicioLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaDeInicioLabel.Location = new Point(155, 520);
            FechaDeInicioLabel.Name = "FechaDeInicioLabel";
            FechaDeInicioLabel.Size = new Size(153, 29);
            FechaDeInicioLabel.TabIndex = 17;
            FechaDeInicioLabel.Text = "Fecha de Inicio";
            FechaDeInicioLabel.Click += label8_Click;
            // 
            // FechaFinalLabel
            // 
            FechaFinalLabel.AutoSize = true;
            FechaFinalLabel.BackColor = Color.Transparent;
            FechaFinalLabel.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaFinalLabel.Location = new Point(449, 520);
            FechaFinalLabel.Name = "FechaFinalLabel";
            FechaFinalLabel.Size = new Size(214, 29);
            FechaFinalLabel.TabIndex = 18;
            FechaFinalLabel.Text = "Fecha de Finalizacion";
            FechaFinalLabel.Click += label9_Click;
            // 
            // GuardarInformacionLibroBoton
            // 
            GuardarInformacionLibroBoton.BackColor = Color.Lavender;
            GuardarInformacionLibroBoton.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuardarInformacionLibroBoton.Location = new Point(283, 832);
            GuardarInformacionLibroBoton.Name = "GuardarInformacionLibroBoton";
            GuardarInformacionLibroBoton.Size = new Size(235, 59);
            GuardarInformacionLibroBoton.TabIndex = 19;
            GuardarInformacionLibroBoton.Text = "Guardar Libro";
            GuardarInformacionLibroBoton.UseVisualStyleBackColor = false;
            GuardarInformacionLibroBoton.Click += GuardarInformacionLibroBoton_Click;
            // 
            // numUpDownCalificacionEstrellas
            // 
            numUpDownCalificacionEstrellas.Location = new Point(331, 452);
            numUpDownCalificacionEstrellas.Margin = new Padding(3, 4, 3, 4);
            numUpDownCalificacionEstrellas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDownCalificacionEstrellas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownCalificacionEstrellas.Name = "numUpDownCalificacionEstrellas";
            numUpDownCalificacionEstrellas.Size = new Size(33, 27);
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
            lblEstrellas.Location = new Point(362, 448);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(127, 37);
            lblEstrellas.TabIndex = 21;
            lblEstrellas.Text = "★★★★★";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(703, 16);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(86, 31);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(646, 155);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AddLibro1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 905);
            Controls.Add(btnAgregar);
            Controls.Add(btnRegresar);
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
        private Button btnRegresar;
        private Button btnAgregar;
    }
}
