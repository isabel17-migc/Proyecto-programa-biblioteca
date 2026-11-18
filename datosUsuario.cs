using dassh_board;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pantalla_inicio
{
    public partial class datosUsuario : Form
    {
        //propiedades

        
        public datosUsuario()
        {
            InitializeComponent();
        }

        private void datosUsuario_Load(object sender, EventArgs e)
        {
            mostrarUsuario();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();
            this.Hide();
        }
        #region Metodo que hace la consulta 
        public void mostrarUsuario()
        {
            string comando = "SELECT nombre_usuario, contraseña FROM usuario WHERE id_usuario = @usuario";
            MySqlParameter[] parametro = new MySqlParameter[]
            {
                new MySqlParameter("@usuario", MostrarLibros.UsuarioActual)
            };
            DataTable resultado = conexion.Leer(comando, parametro);

            DataRow usuario = resultado.Rows[0];
            txtNombre.Text = usuario["nombre_usuario"].ToString();
            txtContraseña.Text = usuario["contraseña"].ToString();
        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            datosUsuarioEditar editar = new datosUsuarioEditar();
            editar.FormClosed += (s, args) => Application.Exit();
            editar.Show();
            this.Hide();
        }
    }
}
