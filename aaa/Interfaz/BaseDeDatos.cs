using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class BaseDeDatos
    {
        List<Usuario> usuarios;

        public BaseDeDatos()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (!(usuarios.Contains(usuario)))
            {
                usuarios.Add(usuario);
            }
        }
    }
}
