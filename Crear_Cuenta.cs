using MySql.Data.MySqlClient; //importo biblioteca
using pantalla_loig_in;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pantalla_inicio
{
    public partial class Crear_Cuenta1 : Form

    {
        //creo un objeto de la clase conexion se crea una vez por formulario
        conexion bd = new conexion();

        public Crear_Cuenta1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();

            longin.FormClosed += (s, args) => Application.Exit();

            longin.Show();
            this.Hide();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            string nusuario = txtusuario.Text.Trim();
            string contraseña = txtcontra.Text.Trim();

            if (nusuario == "")
            {
                MessageBox.Show("Escribe un nombre de usuario.");
                return;
            }

            if (contraseña == "")
            {
                MessageBox.Show("Llena el campo de contraseña");
                return;
            }



            // creo la conexión llamando al método de mi clase
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                // abro la conexión
                cn.Open();

                // pongo el ese comando
                MySqlCommand comando = new MySqlCommand(
                    "INSERT INTO usuario (nombre_usuario, contraseña) VALUES (@nombre, @contraseña)", cn);
                comando.Parameters.AddWithValue("@nombre", nusuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                // aqui se inserta
                comando.ExecuteNonQuery();

                // cierro la conexión
                cn.Close();
            }

            MessageBox.Show("Usuario guardado.");


        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

