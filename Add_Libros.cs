using dassh_board;
using MySql.Data.MySqlClient; //la clase para la conexion
using Mysqlx.Crud;   
using pantalla_inicio;
using System.Data;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Apartado_de_Libros_proyecto_progra_III
{
    public partial class AddLibro1 : Form
    {
     

        // Variable para recordar la ruta de la imagen seleccionada por el usuario
        public string rutaImagenSeleccionada = "";

        // Propiedad pública que devolverá el libro registrado a la ventana principal
        public Libro NuevoLibro { get; private set; }
        public AddLibro1()
        {
            InitializeComponent();
        }

        //creo el objeto libro para guardar la informacion del libro


        private void AddLibroForm1_Load(object sender, EventArgs e)
        {
            CargarAutores(); //llamo al metodo que carga los autores al abrir el formulario
            ActualizarEstrellas();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarAutorTextBox_KeyDown(object sender, KeyEventArgs e) //le cambie al keydawn aqui en en el designer para que detecte las teclas que el usuario presiona
        {

            //CODIGO ESTE PARA QUE SE INSERTEN LOS AUTORES EN LA BASE DE DATOS
            // Validar si la tecla presionada es ENTER
            if (e.KeyCode == Keys.Enter)
            {
                string nombreAutor = RegistrarAutorTextBox.Text; //creela variable esta que sirve para guardar el nombre de el autor

                // Validar que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(nombreAutor))
                {
                    MessageBox.Show("Por favor, ingresa el nombre de un autor.");
                    return;
                }

                // guardarlo en la base de datos
                using (MySqlConnection cn = conexion.ObtenerConexion()) 
                {
                    cn.Open();
                  
                    // Insertar el autor
                    MySqlCommand comandoInsert = new MySqlCommand("INSERT INTO autores(nombre) VALUES(@nombre);", cn);
                    comandoInsert.Parameters.AddWithValue("@nombre", nombreAutor);
                    comandoInsert.ExecuteNonQuery();
                }

                //llamo la funcion que vuelve a cargar los datos en el combobox
                CargarAutores();
            }
        }







        private void SubirImagenLibroBoton_Click(object sender, EventArgs e)
        {
            // Crear la ventana de diálogo para seleccionar archivos
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtrar para mostrar únicamente formatos de imagen válidos
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Seleccionar portada del libro";

                // Verificar si el usuario seleccionó un archivo y presionó 'Aceptar'
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = openFileDialog.FileName;
                    // Cargar la imagen en el PictureBox especificado
                    ImagenLibroPictureBox.Image = Image.FromFile(openFileDialog.FileName);

                                        // Ajustar el tamaño para que la portada no se deforme
                    ImagenLibroPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void numCalificacion_ValueChanged(object sender, EventArgs e)
        {
            ActualizarEstrellas();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarEstrellas(); // Muestra las estrellas iniciales al abrir la ventana
        }

        // Método auxiliar para dibujar las estrellas
        private void ActualizarEstrellas()
        {
            int estrellasLlenas = (int)numUpDownCalificacionEstrellas.Value;
            int estrellasVacias = 5 - estrellasLlenas;

            // Crea el texto combinando estrellas llenas (★) y vacías (☆)
            lblEstrellas.Text = new string('★', estrellasLlenas) + new string('☆', estrellasVacias);
        }

        private void GuardarInformacionLibroBoton_Click(object sender, EventArgs e)
        {

            NuevoLibro = new Libro(); // Crear el objeto
            //les asigno datos a las propiedades del objeto libro que cree en la clase libro
            NuevoLibro.Titulo = NombrarLibroTextBox.Text;
            NuevoLibro.Calificacion = (int)numUpDownCalificacionEstrellas.Value;
            NuevoLibro.FechaInicio = FechaInicioDateTimePicker.Value;
            NuevoLibro.FechaFin = FechaDeFinalizacionDateTimePicker.Value;
            NuevoLibro.Comentario = ComentarioTextBox.Text;
            NuevoLibro.NumeroPaginas = (int)NumeroPaginasNumericUpDown.Value;
            //creo las variables para guardar los datos del libro en la base de datos (son las qufaltan cree las variables pero no las inserte)
            string Titulo = NuevoLibro.Titulo;
            int calificacion = NuevoLibro.Calificacion;
            DateTime fechaInicio = NuevoLibro.FechaInicio;
            DateTime fechaFin = NuevoLibro.FechaFin;
            var comentario = NuevoLibro.Comentario;
            int numeroPaginas = NuevoLibro.NumeroPaginas;



            // Verificar que el autor serleccionado en el combobox sea valido
            if (SeleccionarAutorComboBox.SelectedValue != null)
            {

                // Obtenemos el ID del autor seleccionado (ValueMember)
                int idAutor = Convert.ToInt32(SeleccionarAutorComboBox.SelectedValue);

                // Obtenemos el Nombre del autor seleccionado (DisplayMember)
                string nombreAutor = SeleccionarAutorComboBox.Text;





                //hago que la imagen se guarde en la carpeta portadas libros llamando al metodo guardarimgen 
                crear_carpeta.CrearCarpetaSiNoExiste();
                string rutaPortada = crear_carpeta.GuardarImagenEnCarpeta(crear_carpeta.RutaCarpeta, Titulo, rutaImagenSeleccionada);

               


                //creo la conexion 
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    //abro la conexión
                    cn.Open();

                    //mando el comando que va a insertar todos los datos en 
                    MySqlCommand comando = new MySqlCommand("INSERT INTO libros(id_autor, titulo, portada) VALUES(@id_autor, @titulo, @portada);", cn);
                    //parametros (faltan los demas solo puse los necesarios para comprobar que si funcione lo que hize)

                    comando.Parameters.AddWithValue("@id_autor", idAutor);
                    comando.Parameters.AddWithValue("@titulo", Titulo);
                    comando.Parameters.AddWithValue("@portada", rutaPortada);

                    //ejecuta el comando
                    comando.ExecuteNonQuery();

                    // cierro la conexión
                    cn.Close();
                }






                Dashboard1 dashboard = new Dashboard1();

                dashboard.FormClosed += (s, args) => Application.Exit();

                dashboard.Show();
                this.Hide();
            }
        }

        private void ComentarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada fue 'Enter'
            if (e.KeyCode == Keys.Enter)
            {
                // Evita que el TextBox haga un salto de línea o emita un sonido 'beep' de Windows
                e.SuppressKeyPress = true;

                // Captura el texto ingresado quitando espacios en blanco innecesarios
                string comentarioIngresado = ComentarioTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(comentarioIngresado))
                {
                    // Opcional: Notifica al usuario o guarda la información
                    MessageBox.Show("Comentario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si deseas limpiar el campo después de dar Enter, descomenta la siguiente línea:
                    // ComentarioTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("El comentario no puede estar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SeleccionarAutorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        private void GeneroLiterarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void ImagenLibroPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void NombrarLibroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //este metodo llena el combox
        private void CargarAutores()
        {
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                try
                {
                    cn.Open();
                    string query = "SELECT id_autor, nombre FROM autores;";

                    using (MySqlCommand comando = new MySqlCommand(query, cn))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(lector);


                            SeleccionarAutorComboBox.DataSource = dt;
                            SeleccionarAutorComboBox.DisplayMember = "nombre";
                            SeleccionarAutorComboBox.ValueMember = "id_autor";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar autores: " + ex.Message);
                }
            }
        }

        private void RegistrarAutorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Calificacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Comentario { get; set; }
        public string Genero { get; set; }
        public int NumeroPaginas { get; set; }
        //borre ruta imagen porque no se usa, se usa una varible temporal y luego el metodo la guarda en la carpeta portadas_libros y luego se guarda en la base de datos
    }




}
