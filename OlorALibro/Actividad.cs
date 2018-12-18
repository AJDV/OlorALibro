using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    public class Actividad 
    {
        public string id_act { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public List<string> usuarios { get; set; }

        public Actividad()
        {

        }

        public Actividad(string id, string nombre, string fecha, string hora, string descrip)
        {
            id_act = id;
            Nombre = nombre;
            Fecha = fecha;
            Hora = hora;
            Descripcion = descrip;
        }

    }
}
