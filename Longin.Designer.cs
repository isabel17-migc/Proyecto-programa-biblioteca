namespace pantalla_loig_in
{
    partial class Longin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Longin1));
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtcontra = new TextBox();
            btnnext = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 212);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 293);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(178, 212);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(197, 23);
            txtusuario.TabIndex = 2;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(229, 293);
            txtcontra.Name = "txtcontra";
            txtcontra.PasswordChar = '*';
            txtcontra.Size = new Size(146, 23);
            txtcontra.TabIndex = 3;
            txtcontra.UseSystemPasswordChar = true;
            txtcontra.TextChanged += txtcontra_TextChanged;
            // 
            // btnnext
            // 
            btnnext.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnnext.Location = new Point(161, 386);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(164, 38);
            btnnext.TabIndex = 4;
            btnnext.Text = "SIGUIENTE";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 31);
            label3.Name = "label3";
            label3.Size = new Size(79, 38);
            label3.TabIndex = 5;
            label3.Text = "THE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            label4.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 81);
            label4.Name = "label4";
            label4.Size = new Size(194, 38);
            label4.TabIndex = 6;
            label4.Text = "BOOKWORM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(332, 128);
            label5.Name = "label5";
            label5.Size = new Size(144, 38);
            label5.TabIndex = 7;
            label5.Text = "SOCIETY";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(346, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 13.8F);
            label6.Location = new Point(12, 454);
            label6.Name = "label6";
            label6.Size = new Size(240, 23);
            label6.TabIndex = 12;
            label6.Text = "¿Aun no tienes una cuenta?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Font = new Font("Book Antiqua", 13.8F);
            linkLabel1.Location = new Point(283, 454);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 23);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crea una";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Longin1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 519);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnnext);
            Controls.Add(txtcontra);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Longin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The bookWorm Society";
            Load += Longin1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtcontra;
        private Button btnnext;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private LinkLabel linkLabel1;
    }
}
