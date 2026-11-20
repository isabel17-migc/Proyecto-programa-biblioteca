using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pantalla_inicio
{
    internal class MostrarLibros
    {
        //ESTA VARIABLE SE PUEDE USAR EN TODOS LOS FORMULARIOS Y SE VA A GUARDAR DENTRO EL USUARIO DE EL USUARIO USANDOLA
        public static int UsuarioActual = 0;

        
       
      
        public static string ConsultaSql = @"SELECT id_libro, portada , titulo FROM libros WHERE id_usuario= @usuarioactual"; //esta es la consulta que va a realizar segun yo aqui lee solo esas dos columnas pero de todos los libros es siempre igual, segun yo si se pone afuera
       
      

        //AHORA VOY A PONER EL METODO QUE PRIMERO VA A REALIZAR LA CONSULTA PRINCIPAL, LA QUE CARGA TODOS LOS LIBRO
        public static DataTable ConsultaLibros(string estrella="Todos", string genero="Todos") //Parametros del metodo
        {

            string consulta = ConsultaSql; //creo una copia para que aqui se guarden los cambios de la consultas, ya que el original es static

            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@usuarioactual", UsuarioActual)); //Los parametros los hice una lista ya que se van a ir agregando nuevos parametros
            

            //Para fitrar estrellas

            if(estrella != "Todos")
            {
                consulta += " AND calificacion = @calificacion"; //agrega esto a la consulta original (la que llama los libros)";
                parametros.Add (new MySqlParameter("@calificacion", Convert.ToInt32(estrella))); //agregue la calificación a los parametros y la converti en numero
            }

            //Para filtrar los generos

            if(genero != "Todos")
            {
                consulta += " AND id_libro IN" +
                    "(SELECT gl.id_libro " +
                    "FROM genero_libro gl " +
                    "INNER JOIN genero g ON " +
                    "g.id_genero = gl.id_genero " +
                    "WHERE g.genero = @genero)";
                parametros.Add(new MySqlParameter("@genero", genero));
            }

            return conexion.Leer(consulta, parametros.ToArray()); //Se cambio los parametros a arreglos otravez, porque Leer pide arreglo no lista
        }

        #region Metodo que muestra los libros
        //VOY A HACER OTRO METODO QUE VA A CREAR OBJETOS DE EL LIBRO PLANTILLA POR CADA FILA Y VA A PONER LA FOTO Y EL TITULO
        public static void CrearLibros(DataTable resultado, FlowLayoutPanel FlbBiblioteca) //puse de parametros el data table de el metodo anterior y el flow ese porque es donde se van a crear
        {
            //cada que se abra se van a recargar, por si hacen filtraciones o asi
            FlbBiblioteca.Controls.Clear(); 
            //pongo un foreach
            foreach (DataRow fila in resultado.Rows) // pongo aqui que se va a hacer esto por cada datarow  osea fila en la tabla de los resultados
            {
                //leo los valores de el datatable
                int IdLibro = Convert.ToInt32(fila["id_libro"]);
                string RutaImagen = Convert.ToString(fila["portada"]);
                string TituloLibro = Convert.ToString(fila["titulo"]);
                
                //creo el objetooo
                LibroPlantilla libro = new LibroPlantilla();
                //con este metodo se llena el objeto
                libro.CargarDatos(IdLibro, RutaImagen, TituloLibro);

                //guardo el id de el libro
                libro.Tag = IdLibro;

                //y por ultimo lo agrego al esete
                FlbBiblioteca.Controls.Add(libro);


            }

            


        }
#endregion

       






    }


}
