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
            label1.Location = new Point(281, 12);
            label1.Name = "label1";
            label1.Size = new Size(211, 42);
            label1.TabIndex = 0;
            label1.Text = "Tus datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 123);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre de usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 169);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(555, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(636, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(309, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(321, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(252, 165);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.ReadOnly = true;
            txtContraseña.Size = new Size(321, 23);
            txtContraseña.TabIndex = 6;
            // 
            // datosUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FONDO_2;
            ClientSize = new Size(723, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(btnEditar);
            Controls.Add(btnRegresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "datosUsuario";
            Text = "datosUsuario";
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