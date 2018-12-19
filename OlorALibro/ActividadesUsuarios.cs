using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    public class ActividadesUsuarios
    {
        public string NombreLibreriaActividad { get; set; }
        public string TituloActividad { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public BindingList<string> Usuarios { get; set; }

        public ActividadesUsuarios(Actividad activ, string nombreLib)
        {
            if (activ.usuarios == null)
            {
                activ.usuarios = new BindingList<string>();
            }

            NombreLibreriaActividad = nombreLib;
            TituloActividad = activ.Nombre;
            Descripcion = activ.Descripcion;
            Fecha = activ.Fecha;
            Hora = activ.Hora;
            Usuarios = activ.usuarios;
        }
    }
}
