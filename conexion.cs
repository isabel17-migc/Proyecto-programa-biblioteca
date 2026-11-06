using MySql.Data.MySqlClient; //importo la biblioteca que se usa para crear la conexion con la base de datos

namespace pantalla_inicio
{
    internal class conexion
    {
        //creo las propiedades de la clase 
        public string Servidor { get; set; } = "localhost"; 
        public uint Puerto { get; set; } = 3306;
        public string BaseDatos = "biblioteca_copia";
        public string Usuario { get; set; } = "root";
        public string Password { get; set; } = "";

        //creo el metodo que me devuelve la cadena
        public string ObtenerCadena()
        {
            //es un objeto que de clase de (var es un dato que puede variar o algo asi)
            var builder = new MySqlConnectionStringBuilder
            {
                //son las propiedades de la clase a la que se le asignan los valores que se
                //recuperaron de arriba
                Server = Servidor,
                Port = Puerto,
                Database = BaseDatos,
                UserID = Usuario,
                Password = Password
            };
            //el valor de retorno  es la propiedad ConnectionString del objeto builder, que es la cadena de conexion a la base de datos
            return builder.ConnectionString;
        }
        //creo el metodo que crea la conexion a la base de datos
        public MySqlConnection ObtenerConexion() 
        {
            //pongo lo que devuelve el metodo que es un objeto de la clase MySqlConnection, que utiliza de parametro la cadena o enrealidad llamo al metodo que devuelve la cadena
            return new MySqlConnection(ObtenerCadena());
        }




        //creo el metodo que va a ejecutar el script is no existe la base de datos

        public void CrearBaseSiNoExiste()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = Servidor,
                Port = Puerto,
                UserID = Usuario,
                Password = Password
                // sin Database a propósito: todavía no existe
            };

            using var conexion = new MySqlConnection(builder.ConnectionString);
            conexion.Open();

            var comando = new MySqlCommand(
                "SELECT COUNT(*) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = @nombre",
                conexion);
            comando.Parameters.AddWithValue("@nombre", BaseDatos);
            long existe = Convert.ToInt64(comando.ExecuteScalar());

            if (existe == 0)
            {
                string ruta = Path.Combine(AppContext.BaseDirectory, "script_biblioteca_0.5.sql");
                string sql = File.ReadAllText(ruta);

                var script = new MySqlScript(conexion, sql);
                script.Execute();
            }
        }


    }
}
//ya se creo la clase conexion, ahora se puede crear un objeto de la clase conexion y llamar al metodo ObtenerConexion() para obtener la conexion a la base de datos.