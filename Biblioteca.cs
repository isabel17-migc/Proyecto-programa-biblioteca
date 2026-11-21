using Apartado_de_Libros_proyecto_progra_III;
using dassh_board;
using MySql.Data.MySqlClient;
using pantalla_inicio;
using pantalla_loig_in;
using System.Data;
using System.Drawing.Text;


namespace Biblioteca
{

    public partial class Biblioteca1 : Form
    {
        private bool cargarCombos = true; // Variable booleana, con el proposito que filtre los combobox una vez por ambos y no uno por uno
        private void CargarLibros()
        {
            string estrella = cb_estre.SelectedItem?.ToString() ?? "Todos"; //Primero SelectedItem es la opcion que seleccionaste,
            //El ToString lo convierte a texto,y el ?? Todos hace que si es nulo, se ponga en Todos asi no marca error

            string genero = cb_genero.SelectedItem?.ToString() ?? "Todos";

            string barra = txt_barra.Text.Trim(); // Obtener el texto del cuadro

            //LLAMO A LA CLASE QUE CARGA LOS LIBROS
            //primero este donde se guardan los datos
            DataTable resultado = MostrarLibros.ConsultaLibros(estrella, genero, barra);
            MostrarLibros.CrearLibros(resultado, FlbBiblioteca!); //le puse ese ! porque si no me dice que no acepta nulos y se supone es para que sepa que no es nulo o que no le voy a mandar nulos

        }
        public Biblioteca1()
        {
            InitializeComponent();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargarCombos == true)
            {
                return;
            }
            CargarLibros();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargarCombos == true)
            {
                return;
            }
            CargarLibros();
        }

        private void Biblioteca1_Load(object sender, EventArgs e)
        {

            cb_estre.Items.Clear(); //Limpiamos primero el combobox de los items de la conexion anterior
            cb_genero.Items.Clear(); //Limpiamos primero el combobox de los items de la conexion anterior

            cb_estre.Items.Add("Todos");

            for (int i = 1; i <= 5; i++)
            {
                cb_estre.Items.Add(i);
            }
            cb_estre.SelectedIndex = 0;

            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                MySqlCommand comandoGeneros = new MySqlCommand(
                    "Select genero from genero", cn
                );

                cb_genero.Items.Add("Todos");

                using (MySqlDataReader generos = comandoGeneros.ExecuteReader())
                {
                    while (generos.Read())
                    {
                        cb_genero.Items.Add(generos["genero"]);
                    }

                    cb_genero.SelectedIndex = 0;
                }

                cn.Close();

            }

            cargarCombos = false; //Ya que esta en false, ya se puede filtrar los combobox

            CargarLibros();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            datosUsuario datos = new datosUsuario();
            datos.FormClosed += (s, args) => Application.Exit();
            datos.Show();
            this.Hide();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
        }

        private void txt_barra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarLibros();
            }
        }
    }
}
