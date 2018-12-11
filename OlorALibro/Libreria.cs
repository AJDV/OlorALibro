﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlorALibro
{
    public class Libreria
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string correo { get; set; }
        public string Coordenadas { get; set; }
        public BindingList<Actividad> Actividades { get; set; }

        public Libreria()
        {

        }

        public Libreria(string nombre, string direccion, int tel, string corr, string coord)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = tel;
            correo = corr;
            Coordenadas = coord;
        }
    }
}
