using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    public class Libreria
    {
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public BindingList<Actividad> Actividades { get; set; }
    }
}
