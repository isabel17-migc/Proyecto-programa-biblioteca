namespace pantalla_inicio
{
    partial class datosUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datosUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegresar = new Button();
            btnEditar = new Button();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 16);
            label1.Name = "label1";
            label1.Size = new Size(263, 52);
            label1.TabIndex = 0;
            label1.Text = "Tus datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 164);
            label2.Name = "label2";
            label2.Size = new Size(191, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre de usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 225);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(540, 16);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(86, 31);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(632, 16);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(282, 159);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(366, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(217, 220);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ReadOnly = true;
            txtContraseña.Size = new Size(366, 27);
            txtContraseña.TabIndex = 6;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // datosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FONDO_2;
            ClientSize = new Size(720, 600);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(btnEditar);
            Controls.Add(btnRegresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "datosUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The BookWorm Society";
            Load += datosUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegresar;
        private Button btnEditar;
        private TextBox txtNombre;
        private TextBox txtContraseña;
    }
}