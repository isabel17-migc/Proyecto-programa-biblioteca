using dassh_board;
using MySql.Data.MySqlClient; //la clase para la conexion
using Mysqlx.Crud;   
using pantalla_inicio;
using System.Data;
using System.IO;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Apartado_de_Libros_proyecto_progra_III
{
    public partial class AddLibro1 : Form
    {
     

        // Variables que voy a necesitar 
        public string rutaImagenSeleccionada = "";
        public string reseña = "";
        public int estrellasLlenas = 0;
        string Titulo = "";
        DateTime FechaInicio;
        DateTime FechaFin;
        public int Paginas = 0 ;
        public int IdAutor = 0;

        // Propiedad pública que devolverá el libro registrado a la ventana principal

        public AddLibro1()
        {
            InitializeComponent();
        }

        //creo el objeto libro para guardar la informacion del libro


        private void AddLibroForm1_Load(object sender, EventArgs e)
        {
            CargarAutores(); //llamo al metodo que carga los autores al abrir el formulario
            ActualizarEstrellas();
            CargarGeneros();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void RegistrarAutorTextBox_KeyDown(object sender, KeyEventArgs e) //le cambie al keydawn aqui en en el designer para que detecte las teclas que el usuario presiona
        {
            string Autor = "";
            //CODIGO ESTE PARA QUE SE INSERTEN LOS AUTORES EN LA BASE DE DATOS
            // Validar si la tecla presionada es ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //verifico que no este vacio y lo guardo
                if (!string.IsNullOrEmpty(RegistrarAutorTextBox.Text)) {
                    Autor = RegistrarAutorTextBox.Text.Trim();

                    try
                    {
                        //el comando
                        string comando = @"INSERT INTO autores(id_usuario, nombre) VALUES (@usuario, @autor)";
                        //creo los parametros
                        MySqlParameter[] Parametros = new MySqlParameter[]
                        {
                    new MySqlParameter("@usuario", MostrarLibros.UsuarioActual),
                    new MySqlParameter("@autor", Autor)

                        };
                        //metodo
                        conexion.Ejecutar(comando, Parametros);
                    }
                    catch
                    {
                        MessageBox.Show("Error al guardar el autor");
                    }

                }
                
              
                //llamo la funcion que vuelve a cargar los datos en el combobox
                CargarAutores();
            }
        }






        #region este metodo pone la imagen de el libro y guarda la ruta
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
        #endregion

        private void numCalificacion_ValueChanged(object sender, EventArgs e)
        {
            ActualizarEstrellas();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarEstrellas(); // Muestra las estrellas iniciales al abrir la ventana
            
        }

        #region el metodo que muestra las estrellas  y las guarda en la variable estrellas llenas

        // Método auxiliar para dibujar las estrellas
        private void ActualizarEstrellas()
        {
            estrellasLlenas = (int)numUpDownCalificacionEstrellas.Value;
            int estrellasVacias = 5 - estrellasLlenas;

            // Crea el texto combinando estrellas llenas (★) y vacías (☆)
            lblEstrellas.Text = new string('★', estrellasLlenas) + new string('☆', estrellasVacias);
        }

        #endregion


        #region este metodo guarda la informacion de el libro en la base de datos
        private void GuardarInformacionLibroBoton_Click(object sender, EventArgs e)
        {
            //le asigno valor a las variables que faltan
           Titulo = NombrarLibroTextBox.Text;
           FechaInicio = FechaInicioDateTimePicker.Value;
           FechaFin = FechaDeFinalizacionDateTimePicker.Value;
           Paginas = (int)NumeroPaginasNumericUpDown.Value;
           IdAutor = Convert.ToInt32(SeleccionarAutorComboBox.SelectedValue);
           int Genero = Convert.ToInt32(GeneroLiterarioComboBox.SelectedValue);


            // Verificar que el autor serleccionado en el combobox sea valido
            if (IdAutor != 0)
            {
                //hago que la imagen se guarde en la carpeta portadas libros llamando al metodo guardarimgen 
                crear_carpeta.CrearCarpetaSiNoExiste();
                string rutaPortada = crear_carpeta.GuardarImagenEnCarpeta(crear_carpeta.RutaCarpeta, Titulo, rutaImagenSeleccionada);



                #region esta parte guarda los datos de el libro y el genero
                //CONEXION
                //comandos
                string comando = @"INSERT INTO libros(id_usuario, id_autor, titulo, fecha_inicio, fecha_fin, calificacion, reseña, portada, paginas) VALUES(@usuario, @autor, @titulo, @fechainicio, @fechafin, @calificacion, @reseña, @ruta, @paginas)";
                //arreglo de parametros
                MySqlParameter[] Parametros = new MySqlParameter[]
                {
                new MySqlParameter("@usuario", MostrarLibros.UsuarioActual),
                new MySqlParameter("@autor", IdAutor ),
                new MySqlParameter("@titulo", Titulo),
                new MySqlParameter("@fechainicio", FechaInicio),
                new MySqlParameter("@fechafin", FechaFin),
                new MySqlParameter("@calificacion", estrellasLlenas),
                new MySqlParameter("@reseña", reseña),
                new MySqlParameter("@ruta", rutaPortada),
                new MySqlParameter("@paginas", Paginas)
                };
                //lamo a el metodo
                try
                {
                    conexion.Ejecutar(comando, Parametros);
                    MessageBox.Show("Libro guardado correctamente!");
                    Dashboard1 dashboard = new Dashboard1();

                    dashboard.FormClosed += (s, args) => Application.Exit();

                    dashboard.Show();
                    this.Hide();
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show(
                    $"Error SQL #{sqlEx.Number}: {sqlEx.Message}",
                    "Error de Base de Datos",
                    MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                }
                //ahora voy a consultar el id generado de el libro y guardar el genero
               
                //consulta 1 para saber el id de el libro
                string comando1 = @"SELECT id_libro FROM libros WHERE titulo = @titulo AND id_usuario = @usuarioactual  ";
                MySqlParameter[] parametros1 = new MySqlParameter[] {
                new MySqlParameter("@titulo", Titulo),
                new MySqlParameter("@usuarioactual", MostrarLibros.UsuarioActual)
                };
                int IdLibro = conexion.Leer2(comando1, parametros1);
                //consulta 2
                string comando2 = @"INSERT INTO genero_libro (id_libro, id_genero) VALUES (@idlibro, @idgenero)";
                MySqlParameter[] parametros2 = new MySqlParameter[]
                {
                    new MySqlParameter("@idlibro", IdLibro ),
                    new MySqlParameter("@idgenero", Convert.ToInt32(GeneroLiterarioComboBox.SelectedValue))
                };
                conexion.Ejecutar(comando2, parametros2);




            }
                #endregion
        }

        #endregion



        #region el evento de el comentario

        private void ComentarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada fue 'Enter'
            if (e.KeyCode == Keys.Enter)
            {
                // Evita que el TextBox haga un salto de línea o emita un sonido 'beep' de Windows
                e.SuppressKeyPress = true;

                // Captura el texto ingresado quitando espacios en blanco innecesarios
                reseña = ComentarioTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(reseña))
                {
                   
                    MessageBox.Show("Guardaste el comentario, ahora guarda el libro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }
                else
                {
                    MessageBox.Show("El comentario no puede estar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion
        #region un monton de eventos sin nada

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

        #endregion
      
        #region Metodo cargar autores
        private void CargarAutores()
        {
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                try
                {
                    cn.Open();
                    string cm = "SELECT id_autor, nombre FROM autores WHERE id_usuario = @usuarioactual;";


                    using (MySqlCommand comando = new MySqlCommand(cm, cn))
                    {
                        comando.Parameters.AddWithValue(
                        "@usuarioactual",
                         MostrarLibros.UsuarioActual);


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
        #endregion

        #region Metodo cargar generos
        public void CargarGeneros()
        {
            try
            {
                //hago la consulta que lee todos los generos
                string comando = @"SELECT * FROM genero";
                //llamo al metodo
                DataTable generos = conexion.Leer(comando);
                //ahora muestro los generos en el combobox
                GeneroLiterarioComboBox.DataSource = generos;
                GeneroLiterarioComboBox.DisplayMember = "genero";
                GeneroLiterarioComboBox.ValueMember = "id_genero";
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(
                    $"Error SQL #{ex.Number}: {ex.Message}",
                    "Error al mostrar los generos",
                    MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
            }


        }
        #endregion

        private void RegistrarAutorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
        




}