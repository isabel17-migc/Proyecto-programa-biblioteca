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
            guardarCambios();
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
            txtContraseña.Text= usuario["contraseña"].ToString();
        }
        #endregion

        #region el metodo que guarda los cambios
        public void guardarCambios()
        {
            
                string comando0 = @"SELECT id_usuario FROM usuario WHERE nombre_usuario = @nombre";
                MySqlParameter[] parametros0 = new MySqlParameter[]
                {
                new MySqlParameter ("@nombre", txtNombre.Text)
                };
                int resultado = conexion.Leer2(comando0, parametros0);

           
                if (resultado == 0)
                {
                    try
                    {
                    string contraseña = txtContraseña.Text;
                        string comando = @"UPDATE usuario SET nombre_usuario = @nombre2 , contraseña = @contraseña WHERE id_usuario = @id";
                        MySqlParameter[] parametros = new MySqlParameter[]
                        {
                     new MySqlParameter ("@nombre2", txtNombre.Text),
                     new MySqlParameter("@contraseña", contraseña),
                     new MySqlParameter("@id", MostrarLibros.UsuarioActual)
                        };

                    try
                    {
                        conexion.Ejecutar(comando, parametros);
                        MessageBox.Show("Cambios guardados correctamente");
                        datosUsuario datos = new datosUsuario();
                        datos.FormClosed += (s, args) => Application.Exit();
                        datos.Show();
                        this.Hide();
                        
                    }
                    catch(MySqlException ex) 
                    {
                        MessageBox.Show("Hubo un error inesperado" + ex);
                    }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hubo un error inesperado" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado ya existe");
                }
            }
            
        }
        #endregion
    }

