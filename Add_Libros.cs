using dassh_board;
using MySql.Data.MySqlClient;
using pantalla_inicio;


namespace Apartado_de_Libros_proyecto_progra_III
{
    public partial class AddLibro1 : Form
    {
        //Creo el objeto para la conexion
        conexion bd = new conexion();


        // Variable para recordar la ruta de la imagen seleccionada por el usuario
        private string rutaImagenSeleccionada = "";
       

        // Propiedad pública que devolverá el libro registrado a la ventana principal
        public Libro NuevoLibro { get; private set; }
        public AddLibro1()
        {
            InitializeComponent();
        }

        private void AddLibroForm1_Load(object sender, EventArgs e)
        {

            ActualizarEstrellas();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarAutorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarAutorTextBox_KeyDown(object sender, KeyEventArgs e)
        //Parte del codigo que permite registrar un autor en el ComboBox al presionar Enter despues de escribirlo en el TextBox
        {
            // Verifica si la tecla presionada fue Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de "beep" de Windows al presionar Enter
                e.SuppressKeyPress = true;

                string textoIngresado = RegistrarAutorTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(textoIngresado))
                {
                    // Busca si el autor ya existe en el ComboBox
                    int index = SeleccionarAutorComboBox.FindStringExact(textoIngresado);

                    if (index != -1)
                    {
                        // Si ya existe, simplemente lo selecciona
                        SeleccionarAutorComboBox.SelectedIndex = index;
                    }
                    else
                    {
                        // Si no existe, lo agrega a la lista y lo selecciona
                        SeleccionarAutorComboBox.Items.Add(textoIngresado);
                        SeleccionarAutorComboBox.SelectedItem = textoIngresado;
                    }

                    // Limpia el TextBox para registrar un nuevo autor
                    RegistrarAutorTextBox.Clear();
                }
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

        // Evento Load del formulario (haz doble clic en el fondo de la ventana para generarlo)
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
            //hago que la imagen se guarde en la carpeta portadas libros
          //  ImagenLibroPictureBox.Image.save("PortadasLibros"+ +".jpg");



            //creo la conexion 
          //  using (MySqlConnection conexion = bd.ObtenerConexion())
            //{
                // abro la conexión
              //  conexion.Open();
                //MySqlCommand comando = new MySqlCommand("INSERT INTO libros(portada) VALUES(@rutaportada)", conexion);
                //comando.Parameters.AddWithValue("@rutaportada", rutaImagenSeleccionada);









                // cierro la conexión
                //conexion.Close();
            //}







            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
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
        public string RutaImagen { get; set; }
    }
}
