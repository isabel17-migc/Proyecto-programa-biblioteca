namespace pantalla_inicio
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            lbltitulo = new Label();
            piclogo = new PictureBox();
            btniniciar = new Button();
            lblfrase = new Label();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Thistle;
            lbltitulo.Font = new Font("Stencil", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(107, 39);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(482, 44);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "THE BOOKWORM SOCIETY";
            lbltitulo.UseWaitCursor = true;
            // 
            // piclogo
            // 
            piclogo.BackgroundImage = (Image)resources.GetObject("piclogo.BackgroundImage");
            piclogo.BackgroundImageLayout = ImageLayout.Stretch;
            piclogo.BorderStyle = BorderStyle.Fixed3D;
            piclogo.Location = new Point(14, 16);
            piclogo.Margin = new Padding(3, 4, 3, 4);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(86, 104);
            piclogo.SizeMode = PictureBoxSizeMode.CenterImage;
            piclogo.TabIndex = 1;
            piclogo.TabStop = false;
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.Plum;
            btniniciar.FlatStyle = FlatStyle.Popup;
            btniniciar.Font = new Font("Rockwell", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btniniciar.ForeColor = Color.Black;
            btniniciar.ImageAlign = ContentAlignment.TopCenter;
            btniniciar.Location = new Point(182, 347);
            btniniciar.Margin = new Padding(3, 4, 3, 4);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(207, 56);
            btniniciar.TabIndex = 2;
            btniniciar.Text = "INICIAR";
            btniniciar.UseVisualStyleBackColor = false;
            btniniciar.Click += btniniciar_Click;
            // 
            // lblfrase
            // 
            lblfrase.AutoSize = true;
            lblfrase.BorderStyle = BorderStyle.FixedSingle;
            lblfrase.FlatStyle = FlatStyle.Flat;
            lblfrase.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfrase.ForeColor = Color.DarkMagenta;
            lblfrase.Location = new Point(72, 588);
            lblfrase.Name = "lblfrase";
            lblfrase.Size = new Size(2, 35);
            lblfrase.TabIndex = 3;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(601, 704);
            Controls.Add(lblfrase);
            Controls.Add(btniniciar);
            Controls.Add(piclogo);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The bookWorm Society";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private PictureBox piclogo;
        private Button btniniciar;
        private Label lblfrase;
    }
}
