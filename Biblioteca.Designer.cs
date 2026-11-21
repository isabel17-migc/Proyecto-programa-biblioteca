namespace Biblioteca
{
    partial class Biblioteca1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca1));
            panel1 = new Panel();
            button1 = new Button();
            btncerrar = new Button();
            btnbiblioteca = new Button();
            btnusuario = new Button();
            btnagg = new Button();
            txt_barra = new TextBox();
            cb_estre = new ComboBox();
            cb_genero = new ComboBox();
            FlbBiblioteca = new FlowLayoutPanel();
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(btnbiblioteca);
            panel1.Controls.Add(btnusuario);
            panel1.Controls.Add(btnagg);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 691);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkMagenta;
            button1.Image = pantalla_inicio.Properties.Resources.BIBLIOTECA;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 168);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 57);
            button1.TabIndex = 12;
            button1.Text = "  BIBLIOTECA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btncerrar
            // 
            btncerrar.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncerrar.Image = pantalla_inicio.Properties.Resources.cerrar_seccion;
            btncerrar.ImageAlign = ContentAlignment.TopLeft;
            btncerrar.Location = new Point(10, 613);
            btncerrar.Margin = new Padding(3, 4, 3, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(171, 40);
            btncerrar.TabIndex = 11;
            btncerrar.Text = "  Cerrar sesión";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnbiblioteca
            // 
            btnbiblioteca.BackgroundImageLayout = ImageLayout.Center;
            btnbiblioteca.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbiblioteca.ForeColor = Color.DarkMagenta;
            btnbiblioteca.Image = pantalla_inicio.Properties.Resources.inicio1;
            btnbiblioteca.ImageAlign = ContentAlignment.MiddleLeft;
            btnbiblioteca.Location = new Point(10, 43);
            btnbiblioteca.Margin = new Padding(3, 4, 3, 4);
            btnbiblioteca.Name = "btnbiblioteca";
            btnbiblioteca.Size = new Size(171, 57);
            btnbiblioteca.TabIndex = 8;
            btnbiblioteca.Text = "INICIO";
            btnbiblioteca.UseVisualStyleBackColor = true;
            btnbiblioteca.Click += btnbiblioteca_Click;
            // 
            // btnusuario
            // 
            btnusuario.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusuario.ForeColor = Color.DarkMagenta;
            btnusuario.Image = pantalla_inicio.Properties.Resources.USUARIO;
            btnusuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuario.Location = new Point(10, 447);
            btnusuario.Margin = new Padding(3, 4, 3, 4);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(171, 57);
            btnusuario.TabIndex = 10;
            btnusuario.Text = "    CUENTA/USUARIO";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // btnagg
            // 
            btnagg.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagg.ForeColor = Color.DarkMagenta;
            btnagg.Image = pantalla_inicio.Properties.Resources.agregar_libro__2_;
            btnagg.ImageAlign = ContentAlignment.MiddleLeft;
            btnagg.Location = new Point(10, 303);
            btnagg.Margin = new Padding(3, 4, 3, 4);
            btnagg.Name = "btnagg";
            btnagg.Size = new Size(171, 57);
            btnagg.TabIndex = 9;
            btnagg.Text = "     AGREGAR LIBROS";
            btnagg.UseVisualStyleBackColor = true;
            btnagg.Click += btnagg_Click_1;
            // 
            // txt_barra
            // 
            txt_barra.Location = new Point(197, 11);
            txt_barra.Name = "txt_barra";
            txt_barra.Size = new Size(309, 27);
            txt_barra.TabIndex = 5;
            txt_barra.TextChanged += textBox1_TextChanged;
            txt_barra.KeyDown += txt_barra_KeyDown;
            // 
            // cb_estre
            // 
            cb_estre.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estre.FormattingEnabled = true;
            cb_estre.Location = new Point(513, 12);
            cb_estre.Name = "cb_estre";
            cb_estre.Size = new Size(151, 28);
            cb_estre.TabIndex = 6;
            cb_estre.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cb_genero
            // 
            cb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_genero.FormattingEnabled = true;
            cb_genero.Location = new Point(672, 12);
            cb_genero.Name = "cb_genero";
            cb_genero.Size = new Size(151, 28);
            cb_genero.TabIndex = 7;
            cb_genero.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FlbBiblioteca
            // 
            FlbBiblioteca.BackColor = Color.Transparent;
            FlbBiblioteca.Location = new Point(197, 49);
            FlbBiblioteca.Margin = new Padding(3, 4, 3, 4);
            FlbBiblioteca.Name = "FlbBiblioteca";
            FlbBiblioteca.Size = new Size(728, 641);
            FlbBiblioteca.TabIndex = 8;
            FlbBiblioteca.Paint += FlbBiblioteca_Paint;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            fileSystemWatcher2.Changed += fileSystemWatcher2_Changed;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(831, 9);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(83, 33);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Biblioteca1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = pantalla_inicio.Properties.Resources.FONDO3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(928, 691);
            Controls.Add(btnRegresar);
            Controls.Add(FlbBiblioteca);
            Controls.Add(cb_genero);
            Controls.Add(cb_estre);
            Controls.Add(txt_barra);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Biblioteca1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The BookWorm Society";
            Load += Biblioteca1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txt_barra;
        private ComboBox cb_estre;
        private ComboBox cb_genero;
        private Button button1;
        private Button btncerrar;
        private Button btnbiblioteca;
        private Button btnusuario;
        private Button btnagg;
        private FlowLayoutPanel FlbBiblioteca;
        private FileSystemWatcher fileSystemWatcher1;
        private FileSystemWatcher fileSystemWatcher2;
        private Button btnRegresar;
    }
}
