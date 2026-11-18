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
    public partial class datosUsuarioEditar : Form
    {
        public string contraseña = "";
        public datosUsuarioEditar()
        {
            InitializeComponent();
        }
        private void datosUsuarioEditar_Load(object sender, EventArgs e)
        {
            mostrarUsuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            datosUsuario datos = new datosUsuario();
            datos.FormClosed += (s, args) => Application.Exit();
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
            contraseña = usuario["contraseña"].ToString();
        }
        #endregion
    }
}
