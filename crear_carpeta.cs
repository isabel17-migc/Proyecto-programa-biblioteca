using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace pantalla_inicio
{
    public class crear_carpeta
    {
        //propiedades 
        public static string NombreCarpeta { get; set; } = "portadas_libros";
        //devuelve la ruta del bin
        public static string Rutabin { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        //devuelve la ruta completa de la carpeta portadas_libros
        public static string RutaCarpeta => System.IO.Path.Combine(Rutabin, NombreCarpeta);

        public static void CrearCarpetaSiNoExiste()
        {
            //verifica si la carpeta no existe
            if (!System.IO.Directory.Exists(RutaCarpeta))
            {
                //si no existe la crea
                System.IO.Directory.CreateDirectory(RutaCarpeta);
            }
        } 

    public  static string GuardarImagenEnCarpeta(string rutaCarpeta, string Titulo, string rutaImagenSeleccionada)
        {
            if (string.IsNullOrWhiteSpace(rutaImagenSeleccionada) || !File.Exists(rutaImagenSeleccionada))
            {
                throw new FileNotFoundException("No se encontró la imagen seleccionada.", rutaImagenSeleccionada);
            }

            Directory.CreateDirectory(rutaCarpeta);

            //voy a revisar primero que el libro no tenga caracteres invalidos para el nombre del archivo
            string TituloRevisado = ""; //en esta variable se va a guardar el titulo sin caracteres invalidos
            //creo un ciclo for que revisa cada caracter de el titulo y si es un caracter invalido lo reemplaza por un guion bajo
            for (int i = 0; i < Titulo.Length; i++)
            {
                char c = Titulo[i];
                if (c == ':' || c == '*' || c == '?' || c == '"' || c == '<' || c == '>' || c == '|')
                {
                    TituloRevisado += '_';
                }
                else
                {
                    TituloRevisado += c;
                }
            }

            //obtengo la extension de el archivo de la imagen seleccionada
          string  extension = Path.GetExtension(rutaImagenSeleccionada);
        

            //propiedades
            string nombrePortada = TituloRevisado + "_portada" + extension; // Obtiene el nombre del libro desde la variable esta

            // Obtiene la ruta completa donde se va a guardar la imagen 
            string rutaPortada = Path.Combine(rutaCarpeta, nombrePortada); 
           
            // Copia la imagen original a la carpeta portadas_libros con el nuevo nombre
            System.IO.File.Copy(rutaImagenSeleccionada, rutaPortada, true); // El tercer parámetro 'true' permite sobrescribir si el archivo ya existe
            return rutaPortada;//devuelvo eso porque lo ocupo para guardarlo en la base de datos
        }
    }
}
