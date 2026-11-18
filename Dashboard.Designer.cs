namespace dassh_board
{
    partial class Dashboard1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            userControl31 = new UserControl3();
            panel1 = new Panel();
            button1 = new Button();
            btncerrar = new Button();
            btnusuario = new Button();
            btnagg = new Button();
            btnbiblioteca = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.MistyRose;
            userControl11.BorderStyle = BorderStyle.Fixed3D;
            userControl11.Location = new Point(253, 12);
            userControl11.Margin = new Padding(3, 4, 3, 4);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(200, 120);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load;
            userControl11.Click += btnbiblioteca_Click;
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.MistyRose;
            userControl21.BorderStyle = BorderStyle.Fixed3D;
            userControl21.Location = new Point(253, 174);
            userControl21.Margin = new Padding(3, 4, 3, 4);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(200, 120);
            userControl21.TabIndex = 1;
            userControl21.Click += btnagg_Click;
            // 
            // userControl31
            // 
            userControl31.BackColor = Color.MistyRose;
            userControl31.BorderStyle = BorderStyle.Fixed3D;
            userControl31.Location = new Point(253, 333);
            userControl31.Margin = new Padding(3, 4, 3, 4);
            userControl31.Name = "userControl31";
            userControl31.Size = new Size(200, 120);
            userControl31.TabIndex = 2;
            userControl31.Load += userControl31_Load;
            userControl31.Click += userControl31_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(btnusuario);
            panel1.Controls.Add(btnagg);
            panel1.Controls.Add(btnbiblioteca);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 518);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkMagenta;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 36);
            button1.Name = "button1";
            button1.Size = new Size(150, 43);
            button1.TabIndex = 4;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btncerrar
            // 
            btncerrar.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.ImageAlign = ContentAlignment.TopLeft;
            btncerrar.Location = new Point(10, 458);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(150, 30);
            btncerrar.TabIndex = 3;
            btncerrar.Text = "Cerrar seción";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnusuario
            // 
            btnusuario.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusuario.ForeColor = Color.DarkMagenta;
            btnusuario.Image = (Image)resources.GetObject("btnusuario.Image");
            btnusuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuario.Location = new Point(9, 332);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(150, 43);
            btnusuario.TabIndex = 2;
            btnusuario.Text = "CUENTA/USUARIO";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // btnagg
            // 
            btnagg.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagg.ForeColor = Color.DarkMagenta;
            btnagg.Image = (Image)resources.GetObject("btnagg.Image");
            btnagg.ImageAlign = ContentAlignment.MiddleLeft;
            btnagg.Location = new Point(9, 225);
            btnagg.Name = "btnagg";
            btnagg.Size = new Size(150, 43);
            btnagg.TabIndex = 1;
            btnagg.Text = "AGREGAR LIBROS";
            btnagg.UseVisualStyleBackColor = true;
            btnagg.Click += btnagg_Click;
            // 
            // btnbiblioteca
            // 
            btnbiblioteca.BackgroundImageLayout = ImageLayout.Center;
            btnbiblioteca.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbiblioteca.ForeColor = Color.DarkMagenta;
            btnbiblioteca.Image = (Image)resources.GetObject("btnbiblioteca.Image");
            btnbiblioteca.ImageAlign = ContentAlignment.TopRight;
            btnbiblioteca.Location = new Point(9, 124);
            btnbiblioteca.Name = "btnbiblioteca";
            btnbiblioteca.Size = new Size(150, 43);
            btnbiblioteca.TabIndex = 0;
            btnbiblioteca.Text = "BIBLIOTECA";
            btnbiblioteca.UseVisualStyleBackColor = true;
            btnbiblioteca.Click += btnbiblioteca_Click;
            // 
            // Dashboard1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 518);
            Controls.Add(panel1);
            Controls.Add(userControl31);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(500, 498);
            Name = "Dashboard1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The BookWorm Society";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private Panel panel1;
        private Button btnusuario;
        private Button btnagg;
        private Button btnbiblioteca;
        private Button btncerrar;
        private Button button1;
    }
}
