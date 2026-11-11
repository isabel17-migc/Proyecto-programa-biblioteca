using Apartado_de_Libros_proyecto_progra_III;
using dassh_board;
using MySql.Data.MySqlClient;
using pantalla_inicio;
using pantalla_loig_in;
using System.Data;

namespace Biblioteca
{
    public partial class Biblioteca1 : Form
    {




        public Biblioteca1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Biblioteca1_Load(object sender, EventArgs e)
        {


            cb_estre.Items.Clear(); //Limpiamos primero el combobox de los items de la conexion anterior
            cb_autor.Items.Clear(); //Limpiamos primero el combobox de los items de la conexion anterior



            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                MySqlCommand comandoCalificaciones = new MySqlCommand(
                    "Select distinct calificacion from libros order by calificacion asc", cn
                );

                using (MySqlDataReader calificacion = comandoCalificaciones.ExecuteReader())
                {
                    while (calificacion.Read())
                    {
                        cb_estre.Items.Add(calificacion["calificacion"].ToString());
                    }
                }

                MySqlCommand comandoAutores = new MySqlCommand(
                    "Select distinct nombre from autores order by nombre", cn
                );

                using (MySqlDataReader autores = comandoAutores.ExecuteReader())
                {
                    while (autores.Read())
                    {
                        cb_autor.Items.Add(autores["nombre"].ToString());
                    }
                }

                cn.Close();
            }
            //LLAMO A LA CLASE QUE CARGA LOS LIBROS
            //primero este donde se guardan los datos
            DataTable resultado = MostrarLibros.ConsultaLibros();
            MostrarLibros.CrearLibros(resultado, FlbBiblioteca!); //le puse ese ! porque si no me dice que no acepta nulos y se supone es para que sepa que no es nulo o que no le voy a mandar nulos
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

        }
        #region botones
        private void btnagg_Click_1(object sender, EventArgs e)
        {
            AddLibro1 agregar_libros = new AddLibro1();

            agregar_libros.FormClosed += (s, args) => Application.Exit();

            agregar_libros.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Biblioteca1 biblioteca = new Biblioteca1();

            biblioteca.FormClosed += (s, args) => Application.Exit();

            biblioteca.Show();
            this.Hide();
        }

        private void btnbiblioteca_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();

            longin.FormClosed += (s, args) => Application.Exit();

            longin.Show();
            this.Hide();
        }
        #endregion
        private void FlbBiblioteca_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileSystemWatcher2_Changed(object sender, FileSystemEventArgs e)
        {

        }
    }
}
