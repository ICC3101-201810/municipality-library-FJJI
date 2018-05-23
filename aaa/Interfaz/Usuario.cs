using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Usuario
    {
        public string nombre;
        public string password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }
    }
}
