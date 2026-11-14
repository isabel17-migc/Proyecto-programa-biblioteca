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

        
       
      
        public static string ConsultaSql = @"SELECT portada , titulo FROM libros WHERE id_usuario= @usuarioactual"; //esta es la consulta que va a realizar segun yo aqui lee solo esas dos columnas pero de todos los libros es siempre igual, segun yo si se pone afuera
       
      

        //AHORA VOY A PONER EL METODO QUE PRIMERO VA A REALIZAR LA CONSULTA PRINCIPAL, LA QUE CARGA TODOS LOS LIBRO
        public static DataTable ConsultaLibros()
        {

            MySqlParameter[] parametro = new MySqlParameter[]{
           new MySqlParameter ("@usuarioactual", UsuarioActual) 
            };

            //voy a traer mi metodo que hace consultas
            DataTable resultado = conexion.Leer(ConsultaSql, parametro); //segun yo llame al metodo y le pase el parametrono se si este bien  y lo guarde en la tabla
           //y ya nomas pongo para que me devuelva la tabla 
           return resultado;
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
                string RutaImagen = Convert.ToString(fila["portada"]);
                string TituloLibro = Convert.ToString(fila["titulo"]);
                //creo el objetooo
                LibroPlantilla libro = new LibroPlantilla();
                //con este metodo se llena el objeto
                libro.CargarDatos(RutaImagen, TituloLibro);
                //y por ultimo lo agrego al esete
                FlbBiblioteca.Controls.Add(libro);


            }




        }
#endregion

       






    }


}
