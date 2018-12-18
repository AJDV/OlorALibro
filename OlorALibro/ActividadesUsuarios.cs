using System;
using System.Collections.Generic;
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
        public List<string> Usuarios { get; set; }

        public ActividadesUsuarios(Actividad activ, string nombreLib)
        {
            NombreLibreriaActividad = nombreLib;
            TituloActividad = activ.Nombre;
            Descripcion = activ.Descripcion;
            Fecha = activ.Fecha;
            Hora = activ.Hora;
        }
    }
}
