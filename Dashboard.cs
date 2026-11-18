using Apartado_de_Libros_proyecto_progra_III;
using Biblioteca;
using pantalla_inicio;
using pantalla_loig_in;

namespace dassh_board
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void btnbiblioteca_Click(object sender, EventArgs e)
        {
            Biblioteca1 biblioteca = new Biblioteca1();

            biblioteca.FormClosed += (s, args) => Application.Exit();

            biblioteca.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Botón Biblioteca
            if (btnbiblioteca.Image != null)
            {
                btnbiblioteca.Image = new Bitmap(btnbiblioteca.Image, new Size(24, 24));
                btnbiblioteca.ImageAlign = ContentAlignment.MiddleLeft;
                btnbiblioteca.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            // Botón Agregar
            if (btnagg.Image != null)
            {
                btnagg.Image = new Bitmap(btnagg.Image, new Size(24, 24));
                btnagg.ImageAlign = ContentAlignment.MiddleLeft;
                btnagg.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            // Botón Usuario
            if (btnusuario.Image != null)
            {
                btnusuario.Image = new Bitmap(btnusuario.Image, new Size(24, 24));
                btnusuario.ImageAlign = ContentAlignment.MiddleLeft;
                btnusuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            // Botón Cerrar
            if (btncerrar.Image != null)
            {
                btncerrar.Image = new Bitmap(
                    btncerrar.Image, new Size(24, 24));

                btncerrar.ImageAlign = ContentAlignment.MiddleLeft;
                btncerrar.TextImageRelation =
                    TextImageRelation.ImageBeforeText;
            }

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void btnagg_Click(object sender, EventArgs e)
        {
            AddLibro1 agregar_libros = new AddLibro1();

            agregar_libros.FormClosed += (s, args) => Application.Exit();

            agregar_libros.Show();
            this.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();

            longin.FormClosed += (s, args) => Application.Exit();

            longin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            datosUsuario datos = new datosUsuario();
            datos.FormClosed += (s, args) => Application.Exit();
            datos.Show();
            this.Hide();
        }

        private void userControl31_Click(object sender, EventArgs e)
        {
            datosUsuario datos = new datosUsuario();
            datos.FormClosed += (s, args) => Application.Exit();
            datos.Show();
            this.Hide();
        }
    }
}
