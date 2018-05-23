using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Main : Form, Login_Window.Iloger
    {
        BaseDeDatos bd;
        public Main()
        {
            InitializeComponent();
            bd = new BaseDeDatos();
        }

        public void Login(Usuario usuario)
        {
            user_name.Text = usuario.nombre;
            bd.AgregarUsuario(usuario);
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            Login_Window login_Window = new Login_Window(this);
            login_Window.Show();
        }
    }
}
