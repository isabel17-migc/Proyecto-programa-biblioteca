using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace pantalla_inicio
{
    public partial class LibroPlantilla : UserControl
    {

        public LibroPlantilla()
        {
            InitializeComponent();
            PicPortada.Click += LibroPlantilla_click;
            LblTitulo.Click += LibroPlantilla_click; //estos son para que al hacer clicj en el label o imagen igual pase el evento
        }

        //VOY A PONER LAS PROPIEDADES QUE NECESITO PARA ESTA CLASE, Y SON ESTE LA RUTA Y EL TITULO
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] //pongo esto para editar la configuraciones de serializacion era mas facil hacerlo private perpo me da flojera
        public string Ruta { get; set; } = "";  //segun que no se tenian que inicializar cuando se declaraban en una clase o algo asi, pero si no lo hago me da error, asi que lo inicializo a vacio
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Titulo { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int id { get; set; } = 0;


        #region Metodo que llena los controles de la plantilla con los datos del libro
        //VOY A PONER AQUI EL METODO PARA QUE EL CONTROL SE LLENE SOLITO
        public void CargarDatos(int IdLibro, string RutaImagen, string TituloLibro) //pongo en los parametros los valores que le voy a dar despues
        {
            //LLENO LA VARIABLE QUE GUARDA EL ID DE EL LIBRO
            //leo los valores 
            this.Ruta = RutaImagen;
            this.Titulo = TituloLibro;
            this.id = IdLibro;
            //guardo el id recuperado 
            
            //muestro los datos
            LblTitulo.Text = TituloLibro;

            //para la imagen primero reviso que exista
            if (File.Exists(RutaImagen))
            {
                using (var stream = new FileStream(RutaImagen, FileMode.Open, FileAccess.Read))
                {

                    PicPortada.Image = Image.FromStream(stream);

                    // Ajustar el tamaño para que la portada no se deforme
                    PicPortada.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                PicPortada.Image = null;
            }


        }

        #endregion
        
        
        //El evento click de este control 

        private void LibroPlantilla_click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                return;
            }

            DatosLibro Libro = new DatosLibro(id);
            Libro.Show();
        }
    }
}
