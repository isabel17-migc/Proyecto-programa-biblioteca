using Biblioteca;
using dassh_board;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace pantalla_inicio
{
    public partial class edicionLibro : Form
    {
        //las propiedades
        //public string rutaImagenSeleccionada = "";
        public string reseña = "";
        public int estrellasLlenas = 0;
        string Titulo = "";
        DateTime FechaInicio;
        DateTime FechaFin;
        public int Paginas = 0;
        public int IdAutor = 0;
       
        public edicionLibro(int IdLibro) //ahora pide el id del libro antes de crear todo
        {
            InitializeComponent();
            IdLibroActual = IdLibro; //guardo el id del libro
        }


        private int IdLibroActual; //la variable que guardara el id
        public int Calificacion = 0;
        public string Ruta = "";




        private void DatosLibro_Load(object sender, EventArgs e)
        {
            llenarCombobox2(); //lleno el combobox
            cargarAutores2();
            LlenarDatos2(IdLibroActual);//voy a hacesr otro metodo que muestre los datos actuales
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarCambios();//voy a guardar todo 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Biblioteca1 biblioteca = new Biblioteca1();

            biblioteca.FormClosed += (s, args) => Application.Exit();

            biblioteca.Show();
            this.Hide();
        }

        #region Metodo para llenar los datos
        public void LlenarDatos2(int id)
        {
            //primero consulto todos los datos de el libro y los guardo en las variables
            string Comando = @"SELECT 
            l.titulo,
            a.nombre,
            l.fecha_inicio,
            l.fecha_fin,
            l.calificacion,
            l.paginas,
            l.reseña,
            l.portada,
            g.id_genero,      
            g.genero AS genero 
            FROM libros l
            JOIN autores a 
            ON l.id_autor = a.id_autor
            JOIN genero_libro gl 
             ON l.id_libro = gl.id_libro
            JOIN genero g 
            ON gl.id_genero = g.id_genero
            WHERE l.id_libro = @idlibroactual";

            MySqlParameter[] Parametros = new MySqlParameter[] {
            new MySqlParameter("@idlibroactual", IdLibroActual)

            };
            DataTable Resultado = conexion.Leer(Comando, Parametros);
            try
            {
                if (Resultado.Rows.Count > 0)
                {
                    //asigno todos los valores
                    DataRow libro = Resultado.Rows[0]; // saco la unica fila
                    txtTitulo.Text = libro["titulo"].ToString();
                    cbxAutor.Text = libro["nombre"].ToString();
                    TxtReseña.Text = libro["reseña"].ToString();
                    dtpInicio.Text = Convert.ToDateTime(libro["fecha_inicio"]).ToString("dd/MM/yyyy");
                    dtpFin.Text = Convert.ToDateTime(libro["fecha_fin"]).ToString("dd/MM/yyyy");
                    nudPaginas.Text = libro["paginas"].ToString();
                    cbxGenero.Text = libro["genero"].ToString();
                    Ruta = libro["portada"].ToString();
                    Calificacion = Convert.ToInt32(libro["calificacion"]);
                    string estrellas = new string('★', Calificacion);
                    nudCalificacion.Text = estrellas;
                    if (!string.IsNullOrWhiteSpace(Ruta))
                    {
                        PicPortada1.Image = Image.FromFile(Ruta);
                        PicPortada1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Hubo un error"+ e);
            }
        }

        #endregion

        #region metodo para llenar el combobox
        public void llenarCombobox2()
        {
            try
            {
                //hago la consulta que lee todos los generos
                string comando = @"SELECT * FROM genero";
                //llamo al metodo
                DataTable generos = conexion.Leer(comando);
                //ahora muestro los generos en el combobox
                cbxGenero.DataSource = generos;
                cbxGenero.DisplayMember = "genero";
                cbxGenero.ValueMember = "id_genero";
            }
            catch (MySqlException ex)
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
        #region metodo para llenar el cobobox de autores
        public void cargarAutores2 ()
  
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


                            cbxAutor.DataSource = dt;
                            cbxAutor.DisplayMember = "nombre";
                            cbxAutor.ValueMember = "id_autor";
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

        #region metodo para guardar los datos
        public void guardarCambios ()
        {
         
            //le asigno valor a las variables que faltan
            Titulo = txtTitulo.Text;
            FechaInicio = dtpInicio.Value;
            FechaFin = dtpFin.Value;
            Paginas = (int)nudPaginas.Value;
            IdAutor = Convert.ToInt32(cbxAutor.SelectedValue); //corregir
            int Genero = Convert.ToInt32(cbxGenero.SelectedValue);
            reseña = TxtReseña.Text;
            estrellasLlenas = (int)nudCalificacion.Value;
            

            // Verificar que el autor serleccionado en el combobox sea valido
            if (IdAutor != 0)
            {
               


                #region esta parte guarda los datos de el libro y el genero
                //CONEXION
                //comandos
                string comando = @"UPDATE libros SET id_autor= @autor, titulo = @titulo, fecha_inicio = @fechainicio, fecha_fin= @fechafin, calificacion= @c, reseña =@reseña, portada = @ruta, paginas = @paginas WHERE id_libro = @libro";
                //arreglo de parametros
                MySqlParameter[] Parametros = new MySqlParameter[]
                {
                new MySqlParameter("@autor", IdAutor ),
                new MySqlParameter("@titulo", Titulo),
                new MySqlParameter("@fechainicio", FechaInicio),
                new MySqlParameter("@fechafin", FechaFin),
                new MySqlParameter("@c", estrellasLlenas),
                new MySqlParameter("@reseña", reseña),
                new MySqlParameter("@ruta", Ruta),
                new MySqlParameter("@paginas", Paginas),
                new MySqlParameter("@libro", IdLibroActual)
                };


                //lamo a el metodo
                try
                {
                    // guardar el genero : debi haber puesto el id de el genero en la tabla libro pero no es mi culpa que primero quisieran una relacion muchos a muchos y ahora me da flojera editar el codigo de las demas consltas

                    string comando2 = @"UPDATE genero SET id_genero = @idgenero WHERE id_libro = @libro";
                    MySqlParameter[] parametros2 = new MySqlParameter[]
                    {
                    new MySqlParameter("@libro", IdLibroActual ),
                    new MySqlParameter("@idgenero", Convert.ToInt32(cbxGenero.SelectedValue))
                    };
                   // conexion.Ejecutar(comando2, parametros2);
                    
                    
                    conexion.Ejecutar(comando, Parametros);

                    MessageBox.Show("Cambios guardados!");
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
              




            }
                #endregion
        }

       
        #endregion region
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
                     Ruta= openFileDialog.FileName;
                    // Cargar la imagen en el PictureBox especificado
                    PicPortada1.Image = Image.FromFile(openFileDialog.FileName);

                    // Ajustar el tamaño para que la portada no se deforme
                    PicPortada1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}

