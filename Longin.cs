using dassh_board;
using MySql.Data;
using MySql.Data.MySqlClient; //declaro la biblionteca
using pantalla_inicio;

using System.Data.SqlTypes;
using System.Drawing.Text;

namespace pantalla_loig_in
{
    public partial class Longin1 : Form
    {

        public Longin1()
        {
            InitializeComponent();
        }


        private string Usuario { get; set; } = ""; //pongo el get set porque segun es mas seguro y profesional

        private string Contraseña { get; set; } = "";

        public int UsuarioActual = 0; //a este no le puse get set porque es private



        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnnext_Click(object sender, EventArgs e)
        {
            //lleno las variables para el arreglo
            Usuario = txtusuario.Text.Trim();
            Contraseña = txtcontra.Text.Trim();

            //con este verifico que se llenen ambos txtbox

            if (Usuario == "" || Contraseña == "")
            {
                MessageBox.Show("Escribe el usuario y la contraseña.");
                return;
            }

            //creo el arreglo 
            MySqlParameter[] Parametros = new MySqlParameter[]{  //cree un objeto de la clase mysqlparameter y lo puse como arreglo
            new MySqlParameter("@Usuario", Usuario ),
            new MySqlParameter("@Contrasena", Contraseña)
            };
            //creo mi comando sql
            string Comando = @"SELECT id_usuario FROM usuario WHERE nombre_usuario= @Usuario AND contraseña= @Contrasena"; //
            //llamo a mi metodo leer 2
            int Resultado = conexion.Leer2(Comando, Parametros);
            //pongo un if para validar que este correcto 
            if (Resultado != 0)
            {
                MessageBox.Show("Sesión iniciada!");
                UsuarioActual = Resultado; //guardo el usuario actual que va a usar en los demas formularios

                Dashboard1 dashboard = new Dashboard1();

                dashboard.FormClosed += (s, args) => Application.Exit();

                dashboard.Show();
                this.Hide();

                MostrarLibros.UsuarioActual = Resultado;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");

            }



        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Crear_Cuenta1 crear_cuenta = new Crear_Cuenta1();

            crear_cuenta.FormClosed += (s, args) => Application.Exit();

            crear_cuenta.Show();
            this.Hide();
        }

        private void Longin1_Load(object sender, EventArgs e)
        {

        }
    }
}
