namespace pantalla_inicio
{
    partial class datosUsuarioEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datosUsuarioEditar));
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(222, 233);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(366, 27);
            txtContraseña.TabIndex = 14;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(287, 172);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(366, 27);
            txtNombre.TabIndex = 13;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(629, 29);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(537, 29);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 239);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 10;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 177);
            label2.Name = "label2";
            label2.Size = new Size(191, 22);
            label2.TabIndex = 9;
            label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 29);
            label1.Name = "label1";
            label1.Size = new Size(263, 52);
            label1.TabIndex = 8;
            label1.Text = "Tus datos:";
            // 
            // datosUsuarioEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FONDO_2;
            ClientSize = new Size(720, 600);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "datosUsuarioEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The BookWorm Society";
            Load += datosUsuarioEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}