namespace pantalla_inicio
{
    partial class DatosLibro
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
            lblTitulo1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtReseña = new TextBox();
            label8 = new Label();
            LblInicio = new Label();
            LblFin = new Label();
            LblPaginas = new Label();
            label10 = new Label();
            LblGenero = new Label();
            btnEditar = new Button();
            btnRegresar = new Button();
            lblEstrellas = new Label();
            LblAutor = new Label();
            ((System.ComponentModel.ISupportInitialize)PicPortada1).BeginInit();
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
            // lblTitulo1
            // 
            lblTitulo1.Anchor = AnchorStyles.Top;
            lblTitulo1.AutoSize = true;
            lblTitulo1.BackColor = Color.Thistle;
            lblTitulo1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo1.Location = new Point(249, 16);
            lblTitulo1.MaximumSize = new Size(490, 100);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(98, 29);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 101);
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
            label2.Location = new Point(569, 102);
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
            label3.Location = new Point(569, 167);
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
            label5.Location = new Point(262, 234);
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
            label6.Location = new Point(262, 166);
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
            TxtReseña.ReadOnly = true;
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
            // LblInicio
            // 
            LblInicio.AutoSize = true;
            LblInicio.BackColor = Color.Transparent;
            LblInicio.Location = new Point(699, 108);
            LblInicio.Name = "LblInicio";
            LblInicio.Size = new Size(38, 15);
            LblInicio.TabIndex = 12;
            LblInicio.Text = "label4";
            LblInicio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblFin
            // 
            LblFin.AutoSize = true;
            LblFin.BackColor = Color.Transparent;
            LblFin.Location = new Point(699, 171);
            LblFin.Name = "LblFin";
            LblFin.Size = new Size(38, 15);
            LblFin.TabIndex = 13;
            LblFin.Text = "label4";
            LblFin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblPaginas
            // 
            LblPaginas.AutoSize = true;
            LblPaginas.BackColor = Color.Transparent;
            LblPaginas.Location = new Point(427, 238);
            LblPaginas.Name = "LblPaginas";
            LblPaginas.Size = new Size(38, 15);
            LblPaginas.TabIndex = 14;
            LblPaginas.Text = "label4";
            LblPaginas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Thistle;
            label10.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(569, 234);
            label10.Name = "label10";
            label10.Size = new Size(70, 19);
            label10.TabIndex = 15;
            label10.Text = "Genero:";
            // 
            // LblGenero
            // 
            LblGenero.AutoSize = true;
            LblGenero.BackColor = Color.Transparent;
            LblGenero.Location = new Point(699, 239);
            LblGenero.Name = "LblGenero";
            LblGenero.Size = new Size(38, 15);
            LblGenero.TabIndex = 16;
            LblGenero.Text = "label4";
            LblGenero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Location = new Point(721, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(67, 23);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar\r\n";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.FlatStyle = FlatStyle.System;
            btnRegresar.Location = new Point(721, 37);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(67, 23);
            btnRegresar.TabIndex = 19;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblEstrellas
            // 
            lblEstrellas.AutoSize = true;
            lblEstrellas.BackColor = Color.Transparent;
            lblEstrellas.Location = new Point(367, 166);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(62, 15);
            lblEstrellas.TabIndex = 17;
            lblEstrellas.Text = "lblEstrellas";
            lblEstrellas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.BackColor = Color.Transparent;
            LblAutor.Location = new Point(333, 104);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(38, 15);
            LblAutor.TabIndex = 11;
            LblAutor.Text = "label4";
            LblAutor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DatosLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = Properties.Resources.FONDO3;
            ClientSize = new Size(800, 536);
            Controls.Add(btnRegresar);
            Controls.Add(btnEditar);
            Controls.Add(lblEstrellas);
            Controls.Add(LblGenero);
            Controls.Add(label10);
            Controls.Add(LblPaginas);
            Controls.Add(LblFin);
            Controls.Add(LblInicio);
            Controls.Add(LblAutor);
            Controls.Add(label8);
            Controls.Add(TxtReseña);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo1);
            Controls.Add(PicPortada1);
            Name = "DatosLibro";
            Text = "DatosLibro";
            Load += DatosLibro_Load;
            ((System.ComponentModel.ISupportInitialize)PicPortada1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicPortada1;
        private Label lblTitulo1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox TxtReseña;
        private Label label8;
        private Label LblInicio;
        private Label LblFin;
        private Label LblPaginas;
        private Label label10;
        private Label LblGenero;
        private Button btnEditar;
        private Button btnRegresar;
        private Label lblEstrellas;
        private Label LblAutor;
    }
}