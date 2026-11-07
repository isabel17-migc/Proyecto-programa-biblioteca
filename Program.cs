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

            
            var conexion = new conexion();
            conexion.CrearBaseSiNoExiste();
            Application.Run(new Inicio());

            //aqui voy a crear la carpeta portadas_libros en el bin llamando a el metodo de la clase imagenes   

            var carpeta = new crear_carpeta();
            carpeta.CrearCarpetaSiNoExiste();







            Application.Run(new Inicio());



        }
    }

}