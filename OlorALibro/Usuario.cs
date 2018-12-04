using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    class Usuario
    {
        public bool admin { get; set; }
        public string User { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int Puntos { get; set; }

        public Usuario()
        {

        }

        public Usuario(bool admin, string user, string contrasenia)
        {
            this.admin = admin;
            this.User = user;
            this.Contrasenia = contrasenia;
        }

        public Usuario(bool admin, string user, string contrasenia, string nombre, string apellido, string correo, int puntos)
        {
            this.admin = admin;
            this.User = user;
            this.Contrasenia = contrasenia;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Puntos = puntos;
        }

    }
}
