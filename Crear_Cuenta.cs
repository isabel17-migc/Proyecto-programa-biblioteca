using dassh_board;
using MySql.Data.MySqlClient; //importo biblioteca
using pantalla_loig_in;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pantalla_inicio
{
    public partial class Crear_Cuenta1 : Form

    {
        

        public Crear_Cuenta1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();

            longin.FormClosed += (s, args) => Application.Exit();

            longin.Show();
            this.Hide();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            string nusuario = txtusuario.Text.Trim();
            string contraseña = txtcontra.Text.Trim();

            if (nusuario == "")
            {
                MessageBox.Show("Escribe un nombre de usuario.");
                return;
            }

            if (contraseña == "")
            {
                MessageBox.Show("Llena el campo de contraseña");
                return;
            }

            //AQUI SE VA A GUARDAR LA CONTRASEÑA SI NO EXISTE no se si sea la forma correcta usar tantos if pero funciona sjsjs

            if (nusuario != "" & contraseña != "")
            {
                //creo el arreglo de los parametros
                MySqlParameter[] Parametros = new MySqlParameter[]
                {
                   new MySqlParameter("@nusuario", nusuario),
                   new MySqlParameter("@contrasena", contraseña)
                };
                //creo el comando
                string comando = @"SELECT id_usuario FROM usuario WHERE nombre_usuario = @nusuario";
                //llamo a mi metodo
                int resultado = conexion.Leer2(comando, Parametros);
                if(resultado == 0) 
                {
                    //ahora si voy a guardar el usuario y la contraseña
                    //creo el comando
                    string comando2 = @"INSERT INTO usuario(nombre_usuario, contraseña) VALUES (@nusuario, @contrasena)";
                    //llamo a la funcion y pongo un try catch por si falla
                    try
                    {
                        conexion.Ejecutar(comando2, Parametros);
                        //si funciona lo dice
                        MessageBox.Show("Usuario creado correctamente");
                        //y lo lleva automaticamente a la pantalla principal
                        MessageBox.Show("Sesión iniciada automaticamente");

                        //hago otra consulta que saca el id de el usuario
                        string comando3 = @"SELECT id_usuario FROM usuario WHERE nombre_usuario = @nusuario AND contraseña = @contraseña";

                        MostrarLibros.UsuarioActual = conexion.Leer2(comando3, Parametros);

                        Dashboard1 dashboard = new Dashboard1();

                        dashboard.FormClosed += (s, args) => Application.Exit();

                        dashboard.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo guardar el usuario, intenta otra vez");
                    }


                }
                else
                {
                    MessageBox.Show("Usuario ya existente");
                }
            }
            


        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

