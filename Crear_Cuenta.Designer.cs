namespace pantalla_inicio
{
    partial class Crear_Cuenta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Cuenta1));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtcontra = new TextBox();
            txtusuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnnext = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(249, 119);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            label4.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 49);
            label4.Name = "label4";
            label4.Size = new Size(475, 47);
            label4.TabIndex = 10;
            label4.Text = "Crea tu nueva cuenta";
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(284, 377);
            txtcontra.Margin = new Padding(3, 4, 3, 4);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(175, 27);
            txtcontra.TabIndex = 14;
            txtcontra.UseSystemPasswordChar = true;
            txtcontra.TextChanged += txtcontra_TextChanged;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(234, 283);
            txtusuario.Margin = new Padding(3, 4, 3, 4);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(225, 27);
            txtusuario.TabIndex = 13;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 373);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 12;
            label2.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 277);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 11;
            label1.Text = "USUARIO:";
            // 
            // btnnext
            // 
            btnnext.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnnext.Location = new Point(75, 473);
            btnnext.Margin = new Padding(3, 4, 3, 4);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(187, 51);
            btnnext.TabIndex = 15;
            btnnext.Text = "Crear";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(293, 473);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(248, 51);
            button1.TabIndex = 16;
            button1.Text = "Volver al longin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Crear_Cuenta1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FONDO_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 692);
            Controls.Add(button1);
            Controls.Add(btnnext);
            Controls.Add(txtcontra);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Crear_Cuenta1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The bookWorm Society";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtcontra;
        private TextBox txtusuario;
        private Label label2;
        private Label label1;
        private Button btnnext;
        private Button button1;
    }
}
