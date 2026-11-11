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
        }

        //VOY A PONER LAS PROPIEDADES QUE NECESITO PARA ESTA CLASE, Y SON ESTE LA RUTA Y EL TITULO
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] //ahorita lo explico
        public  string Ruta { get; set; } = "";  //segun que no se tenian que inicializar cuando se declaraban en una clase o algo asi, pero si no lo hago me da error, asi que lo inicializo a vacio
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Titulo { get; set; } = "";

        #region Metodo que llena los controles de la plantilla con los datos del libro
        //VOY A PONER AQUI EL METODO PARA QUE EL CONTROL SE LLENE SOLITO
        public  void CargarDatos(string RutaImagen, string TituloLibro) //pongo en los parametros los valores que le voy a dar despues
        {
            //leo los valores 
            this.Ruta = RutaImagen;
            this.Titulo = TituloLibro;

            //muestro los datos
            LblTitulo.Text = TituloLibro;

            //para la imagen
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


    }
}
