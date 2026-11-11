using System.Security.Cryptography.X509Certificates;

namespace pantalla_inicio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            //CREO LA BASE DE DATOS SI NO EXISTE
            conexion.CrearBaseSiNoExiste();
            //CREO LA CARPETA PARA GUARDAR LAS PORTADAS DE LOS LIBROS
            crear_carpeta.CrearCarpetaSiNoExiste();







            Application.Run(new Inicio());



        }
    }

}