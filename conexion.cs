using MySql.Data.MySqlClient; //importo la biblioteca que se usa para crear la conexion con la base de datos
using System.Data; //tienen que poner esta libreria tambien si estan usando el segundo metodo

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
                string ruta = Path.Combine(AppContext.BaseDirectory, "script_biblioteca_0.6.sql");
                string sql = File.ReadAllText(ruta);

                var script = new MySqlScript(conexion, sql);
                script.Execute();
            }
        }


        //creo el objeto que crea las conexiones asi nomas llamo a sus metodos y lo declaro static para que se pueda usar en cualquier parte del programa sin necesidad de crear un objeto de la clase conexion
        static conexion bd = new conexion();



        //AQUI VOY A HACER LOS TRES METODOS QUE ME VAN A PERMITIR HACER EL CRUD DE LA BASE DE DATOS, CREAR, LEER, ACTUALIZAR Y ELIMINAR


        //1-INSERT, SELECT, UPDATE, DELETE
        //estem tiene de parametro la variable "comandosql" se tiene que crear cada que se usa el metodo cualquiera de los tres metodos
        static void Crear(string comandosql)
        {
            using (MySqlConnection conexion = bd.ObtenerConexion())
            {


                // abro la conexión
                conexion.Open();

                MySqlCommand comando = new MySqlCommand(comandosql, conexion);
                //quiero especificar que no pueden poner los datos directamente en el comando sql, sino que se tienen que poner como parametros, para evitar inyecciones sql


                //el metodo que lo ejecuta
                comando.ExecuteNonQuery();


                // cierro la conexión
                conexion.Close();
            }


        }


        //2-READ
        static DataTable Leer(string comandosql)
        {
            using (MySqlConnection conexion = bd.ObtenerConexion())
            {


                // abro la conexión
                conexion.Open();
                //pongo el comando
                MySqlCommand comando = new MySqlCommand(comandosql, conexion);
                //quiero especificar que no pueden poner los datos directamente en el comando sql, sino que se tienen que poner como parametros, para evitar inyecciones sql

                //aqui voy a poner la tabla que guarda el resultado o mas bien inicializarla
                DataTable tablaResultado = new DataTable();


                // uso el adaptador para llenar la tabla con los registros que devuelve el comando sql
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                //y ese metodo llena la tabla con los registros que devuelve el comando sql
                adaptador.Fill(tablaResultado);

                //asi que al llamar a el metodo cuando quieran ver el resultado de la consulta sql, tienen que poner el nombre de la tabla que se creo en este metodo, que es "tablaResultado" y ya pueden ver los registros que devuelve el comando sql
                // cierro la conexión
                conexion.Close();
                return tablaResultado;
            }

        }
        //3- devuelve de que nomas la primera columna de el registro sirve para comprobar cosas como si existe un registro o no, o si hay un registro con ese nombre de usuario y contraseña

        static int Leer2(string comandosql)
        {
            using (MySqlConnection conexion = bd.ObtenerConexion())
            {


                // abro la conexión
                conexion.Open();

                MySqlCommand comando = new MySqlCommand(comandosql, conexion);
                //quiero especificar que no pueden poner los datos directamente en el comando sql, sino que se tienen que poner como parametros, para evitar inyecciones sql


                //el metodo que lo ejecuta
                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                //el resultado se guarda en esta variable


                // cierro la conexión
                conexion.Close();

                //y la funcion devuelve la variable con los datos
                return resultado;
            }


        }



       

    }
}

//ya se creo la clase conexion, ahora se puede crear un objeto de la clase conexion y llamar al metodo ObtenerConexion() para obtener la conexion a la base de datos.
