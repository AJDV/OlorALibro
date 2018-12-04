using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    class UsuarioAdm
    {
        public bool admin { get; set; }
        public string User { get; set; }
        public string Contrasenia { get; set; }

        public UsuarioAdm()
        {

        }

        public UsuarioAdm(bool admin, string user, string contrasenia)
        {
            this.admin = admin;
            this.User = user;
            this.Contrasenia = contrasenia;
        }

    }
}
