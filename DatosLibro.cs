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
    public partial class DatosLibro : Form
    {
        public DatosLibro(int IdLibro) //ahora pide el id del libro antes de crear todo
        {
            InitializeComponent();
            IdLibroActual = IdLibro; //guardo el id del libro
        }


        private int IdLibroActual; //la variable que guardara el id
        public int Calificacion = 0;
        public string Ruta = "";




        private void DatosLibro_Load(object sender, EventArgs e)
        {
            LlenarDatos(); //aqui llamo al metodo que lo llena cada que se abre
        }











        #region Metodo para llenar cada campo
        private void LlenarDatos()
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
            if (Resultado.Rows.Count > 0)
            {
                //asigno todos los valores
                DataRow libro = Resultado.Rows[0]; // saco la unica fila
                lblTitulo1.Text = libro["titulo"].ToString();
                LblAutor.Text = libro["nombre"].ToString();
                TxtReseña.Text = libro["reseña"].ToString();
                LblInicio.Text = Convert.ToDateTime(libro["fecha_inicio"]).ToString("dd/MM/yyyy");
                LblFin.Text = Convert.ToDateTime(libro["fecha_fin"]).ToString("dd/MM/yyyy");
                LblPaginas.Text = libro["paginas"].ToString();
                LblGenero.Text = libro["genero"].ToString();
                Ruta = libro["portada"].ToString();
                Calificacion = Convert.ToInt32(libro["calificacion"]);
                string estrellas = new string('★', Calificacion);
                lblEstrellas.Text = estrellas;

                if (!string.IsNullOrWhiteSpace(Ruta))
                {
                    PicPortada1.Image = Image.FromFile(Ruta);
                    PicPortada1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                MessageBox.Show("Error");

            }




        }

        #endregion

        #region evento click de editar

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando a el modo edición...");
            edicionLibro edicion = new edicionLibro(IdLibroActual);
            edicion.FormClosed += (s, args) => Application.Exit();
            edicion.Show();
            this.Hide();

        }

        #endregion



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
        }
    }
}
