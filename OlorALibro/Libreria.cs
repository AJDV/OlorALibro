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
        public string Nom { get; set; }
        public BindingList<Actividad> Activs { get; set; }
    }
}
