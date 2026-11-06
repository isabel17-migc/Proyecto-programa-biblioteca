using MySql.Data.MySqlClient; //importo biblioteca
using pantalla_loig_in;

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

            // creo la conexión llamando al método de mi clase
            using (MySqlConnection conexion = bd.ObtenerConexion())
            {
                // abro la conexión
                conexion.Open();

                // pongo el ese comando
                MySqlCommand comando = new MySqlCommand(
                    "INSERT INTO usuario (nombre_usuario) VALUES (@nombre)", conexion);
                comando.Parameters.AddWithValue("@nombre", nusuario);

                // aqui se inserta
                comando.ExecuteNonQuery();

                // cierro la conexión
                conexion.Close();
            }

            MessageBox.Show("Usuario guardado.");
        }

        
    }
    
}

