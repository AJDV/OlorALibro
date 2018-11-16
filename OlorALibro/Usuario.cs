using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    class Usuario
    {
        public string User { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int Puntos { get; set; }

        public Usuario()
        {

        }

        public Usuario(string User, string Contrasenia, string Nombre, string Apellido, string Correo, int Puntos)
        {
            this.User = User;
            this.Contrasenia = Contrasenia;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Puntos = Puntos;
        }

    }
}
