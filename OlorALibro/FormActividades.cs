﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    public partial class FormActividades : Form
    {
        //Lista enlazada por referencia a la Lista de actividades
        BindingList<Actividad> acts;

        //Nombre de la libreria que nos servirá para el id de la actividad
        String nombrelib;

        //Actividad enlazada por referencia a una Actividad
        Actividad a;

        //Booleano para comprobar si haremos un ADD de la actividad en caso que no editemos
        bool editar = false;

        //Constructor general NO UTILiZADO
        public FormActividades()
        {
            InitializeComponent();
        }

        //Constructor donde le pasamos la Lista de Actividades
        public FormActividades(BindingList<Actividad> acts, String nombrelib)
        {
            InitializeComponent();
            acts = new BindingList<Actividad>();
            this.acts = acts;
            this.nombrelib = nombrelib;
        }

        //Constructor donde le pasamos una Actividad
        public FormActividades(Actividad a)
        {
            InitializeComponent();
            this.editar = true;
            this.a = a;
        }

        //En el load comprobaremos si le pasamos una actividad, en caso de no pasarle crearemos una nueva
        private void Actividades_Load(object sender, EventArgs e)
        {

            if (a != null)
            {
                textBoxNombre.Text = a.Nombre;
                dateTimePickerFecha.Value = DateTime.Parse(a.Fecha);
                dateTimePickerHora.Value = DateTime.Parse(a.Hora);
                textBoxDescripcion.Text = a.Descripcion;
            }
            else
            {
                this.a = new Actividad();
            }
        }

        //En el aceptar añadiremos datos a una actividad, pero solo haremos el add en caso de que no estemos modificando
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            anadirActividad();
            if (!editar)
            {
                guardarActividad();
            }
            this.Close();
        }

        //Añadimos los datos de una actividad
        private void anadirActividad()
        {
            a.Nombre = textBoxNombre.Text;
            a.Fecha = dateTimePickerFecha.Value.ToString("yyyy-MM-dd");
            a.Hora = dateTimePickerHora.Value.ToString("HH:mm");
            a.Descripcion = textBoxDescripcion.Text;
        }

        //Realizaremos el add de una actividad sobre la List, solo en caso que no estemos modificando
        private void guardarActividad()
        {
            DialogResult dr = MessageBox.Show("Está apunto de añadir una actividad, está seguro?", "Atención", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK && !editar)
            {
                a.id_act = "Act_" + nombrelib;
                acts.Add(a);
                //GRABAR JSON ACTIVIDADES
                JArray ja = (JArray)JToken.FromObject(acts);
                String nombreLib = nombrelib;
                nombreLib = nombreLib.Replace(" ", string.Empty);
                String activPath = @"..\..\Json\ListaDeLibrerías\ActivDeLibrerias\Act_" + nombreLib + ".json";
                StreamWriter jw = File.CreateText(activPath);
                JsonTextWriter jtw = new JsonTextWriter(jw);

                ja.WriteTo(jtw);
                
                jtw.Close();

                MessageBox.Show("Grabado correctamente!", "GRABADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //GRABAR JSON ACTIVIDADES
                JArray ja = (JArray)JToken.FromObject(acts);
                String nombreLib = nombrelib;
                nombreLib = nombreLib.Replace(" ", string.Empty);
                String activPath = @"..\..\Json\ListaDeLibrerías\ActivDeLibrerias\Act_" + nombreLib + ".json";
                StreamWriter jw = File.CreateText(activPath);
                JsonTextWriter jtw = new JsonTextWriter(jw);

                ja.WriteTo(jtw);

                jtw.Close();

                MessageBox.Show("Grabado correctamente!", "GRABADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //El boton CANCELAR nos cerrará el form
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}