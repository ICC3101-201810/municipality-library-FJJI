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
    public partial class Login_Window : Form
    {
        private Iloger listener;
        public interface Iloger
        {
            void Login(Usuario usuario);
        }
        public Login_Window(object sender)
        {
            InitializeComponent();
            if (sender is Iloger)
            {
                listener = (Iloger)sender;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox_user.Text;
            string claveUsuario = textBox_password.Text;
            Usuario usuario = new Usuario(nombreUsuario, claveUsuario);
            listener.Login(usuario);
            this.Close();
        }
    }
}
