namespace pantalla_inicio
{
    partial class edicionLibro
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
            PicPortada1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtReseña = new TextBox();
            label8 = new Label();
            label10 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            cbxGenero = new ComboBox();
            SubirImagenLibroBoton = new Button();
            nudPaginas = new NumericUpDown();
            nudCalificacion = new NumericUpDown();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            cbxAutor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PicPortada1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCalificacion).BeginInit();
            SuspendLayout();
            // 
            // PicPortada1
            // 
            PicPortada1.BackColor = Color.Transparent;
            PicPortada1.BackgroundImage = Properties.Resources.portadaDefault;
            PicPortada1.BackgroundImageLayout = ImageLayout.Zoom;
            PicPortada1.Location = new Point(23, 16);
            PicPortada1.Name = "PicPortada1";
            PicPortada1.Size = new Size(200, 300);
            PicPortada1.TabIndex = 0;
            PicPortada1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 70);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 2;
            label1.Text = "Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(569, 70);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(569, 135);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Fecha de fin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(238, 203);
            label5.Name = "label5";
            label5.Size = new Size(159, 19);
            label5.TabIndex = 6;
            label5.Text = "Numero de paginas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Thistle;
            label6.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(238, 135);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 7;
            label6.Text = "Calificación:";
            // 
            // TxtReseña
            // 
            TxtReseña.Location = new Point(23, 349);
            TxtReseña.Multiline = true;
            TxtReseña.Name = "TxtReseña";
            TxtReseña.Size = new Size(765, 175);
            TxtReseña.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Thistle;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 331);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 10;
            label8.Text = "Reseña:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Thistle;
            label10.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(569, 202);
            label10.Name = "label10";
            label10.Size = new Size(70, 19);
            label10.TabIndex = 15;
            label10.Text = "Genero:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.Location = new Point(713, 12);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(632, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(699, 65);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(89, 23);
            dtpInicio.TabIndex = 21;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(699, 131);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(89, 23);
            dtpFin.TabIndex = 22;
            // 
            // cbxGenero
            // 
            cbxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Location = new Point(699, 198);
            cbxGenero.Margin = new Padding(3, 2, 3, 2);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(89, 23);
            cbxGenero.TabIndex = 23;
            // 
            // SubirImagenLibroBoton
            // 
            SubirImagenLibroBoton.BackColor = Color.Lavender;
            SubirImagenLibroBoton.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubirImagenLibroBoton.Location = new Point(23, 16);
            SubirImagenLibroBoton.Margin = new Padding(3, 2, 3, 2);
            SubirImagenLibroBoton.Name = "SubirImagenLibroBoton";
            SubirImagenLibroBoton.Size = new Size(67, 44);
            SubirImagenLibroBoton.TabIndex = 24;
            SubirImagenLibroBoton.Text = "Cambiar Imagen";
            SubirImagenLibroBoton.UseVisualStyleBackColor = false;
            SubirImagenLibroBoton.Click += SubirImagenLibroBoton_Click;
            // 
            // nudPaginas
            // 
            nudPaginas.Location = new Point(403, 203);
            nudPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPaginas.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudPaginas.Name = "nudPaginas";
            nudPaginas.Size = new Size(37, 23);
            nudPaginas.TabIndex = 25;
            nudPaginas.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nudCalificacion
            // 
            nudCalificacion.Location = new Point(343, 132);
            nudCalificacion.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudCalificacion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCalificacion.Name = "nudCalificacion";
            nudCalificacion.Size = new Size(41, 23);
            nudCalificacion.TabIndex = 26;
            nudCalificacion.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(298, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(318, 23);
            txtTitulo.TabIndex = 27;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Thistle;
            lblTitulo.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(238, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(54, 19);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Titulo:";
            // 
            // cbxAutor
            // 
            cbxAutor.FormattingEnabled = true;
            cbxAutor.Location = new Point(299, 70);
            cbxAutor.Name = "cbxAutor";
            cbxAutor.Size = new Size(167, 23);
            cbxAutor.TabIndex = 29;
            // 
            // edicionLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = Properties.Resources.FONDO3;
            ClientSize = new Size(800, 536);
            Controls.Add(cbxAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(nudCalificacion);
            Controls.Add(nudPaginas);
            Controls.Add(SubirImagenLibroBoton);
            Controls.Add(cbxGenero);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(TxtReseña);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PicPortada1);
            Name = "edicionLibro";
            Text = "DatosLibro";
            Load += DatosLibro_Load;
            ((System.ComponentModel.ISupportInitialize)PicPortada1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCalificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicPortada1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox TxtReseña;
        private Label label8;
        private Label label10;
        private Button btnAceptar;
        private Button btnCancelar;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private ComboBox cbxGenero;
        private Button SubirImagenLibroBoton;
        private NumericUpDown nudPaginas;
        private NumericUpDown nudCalificacion;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private ComboBox cbxAutor;
    }
}