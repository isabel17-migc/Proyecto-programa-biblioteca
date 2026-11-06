using System;
using System.Collections.Generic;
using System.Text;

namespace pantalla_inicio
{
    internal class crear_carpeta
    {
        //propiedades 
        public string NombreCarpeta { get; set; } = "portadas_libros";
        //devuelve la ruta del bin
        public string Rutabin { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        //devuelve la ruta completa de la carpeta portadas_libros
        public string RutaCarpeta => System.IO.Path.Combine(Rutabin, NombreCarpeta);

        public void CrearCarpetaSiNoExiste()
        {
            //verifica si la carpeta no existe
            if (!System.IO.Directory.Exists(RutaCarpeta))
            {
                //si no existe la crea
                System.IO.Directory.CreateDirectory(RutaCarpeta);
            }
        }

    }
}
