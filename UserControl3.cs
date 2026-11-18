using pantalla_inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dassh_board
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            datosUsuario datos = new datosUsuario();
            datos.FormClosed += (s, args) => Application.Exit();
            datos.Show();
            this.Hide();
        }

        private void UserControl3_Click(object sender, EventArgs e)
        {
            datosUsuario datos = new datosUsuario();
            datos.FormClosed += (s, args) => Application.Exit();
            datos.Show();
            this.Hide();
        }
    }
}
