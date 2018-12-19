using Newtonsoft.Json;
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
    public partial class FormEditar : Form
    {
        public static string filePath = @"..\..\Json\ListaDeLibrerías\Librerias.json";

        public Libreria lib = new Libreria();

        public bool cambios = false;

        public string nombreComprobar="";
     

        public FormEditar(Libreria lib)
        {
            InitializeComponent();
            this.lib = lib;
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            string[] coord = lib.Coordenadas.Split(',');
            textBoxNom.Text = lib.Nombre;
            nombreComprobar = lib.Nombre;
            textBoxDireccion.Text = lib.Direccion;
            textBoxTelefono.Text = lib.Telefono.ToString();
            textBoxCorreo.Text = lib.Correo;
            textBoxAltitud.Text = coord[0];
            textBoxLatitud.Text = coord[1];
            textBoxLink.Text = lib.linkWeb;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(textBoxNom.Text == lib.Nombre && textBoxTelefono.Text == lib.Telefono.ToString() && textBoxDireccion.Text == lib.Direccion 
                && $"{textBoxAltitud.Text},{textBoxLatitud.Text}" == lib.Coordenadas && textBoxCorreo.Text == lib.Correo
                && textBoxLink.Text == lib.linkWeb)
            {
                MessageBox.Show("No hay cambios efectuados!");
            }
            else if(!ComprobarNombre(nombreComprobar, textBoxNom.Text, LeerNombreDeLibrerias()))
            {
                MessageBox.Show("Este nombre ya existe");
                textBoxNom.Clear();
                textBoxNom.Focus();
            }
            else
            {
                if(textBoxNom.Text != lib.Nombre)
                {
                    CambiarDeArchivoActiv(textBoxNom.Text); //cambia el JSON de actividades asociado
                }
                lib.Nombre = textBoxNom.Text;
                lib.Direccion = textBoxDireccion.Text;                
                lib.Telefono = int.Parse(textBoxTelefono.Text);
                lib.Correo = textBoxCorreo.Text;
                lib.Coordenadas = $"{textBoxAltitud.Text},{textBoxLatitud.Text}";
                lib.linkWeb = textBoxLink.Text;
                MessageBox.Show("Libreria Actualizada");
                cambios = true;
                Hide();
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAltitud_Enter(object sender, EventArgs e)
        {
            if(textBoxAltitud.Text == "ALTITUD")
            {
                textBoxAltitud.Text = "";
            }
        }

        private void textBoxAltitud_Leave(object sender, EventArgs e)
        {
            if (textBoxAltitud.Text == "")
            {
                textBoxAltitud.Text = "ALTITUD";
            }
        }

        private void textBoxLatitud_Enter(object sender, EventArgs e)
        {
            if (textBoxLatitud.Text == "LATITUD")
            {
                textBoxLatitud.Text = "";
            }
        }

        private void textBoxLatitud_Leave(object sender, EventArgs e)
        {
            if (textBoxLatitud.Text == "")
            {
                textBoxLatitud.Text = "LATITUD";
            }
        }
        public static bool ComprobarNombre(string nombreComprobar, string nombre, List<string> nombres)
        {

            int j = 0;
            List<string> nombresAux = new List<string>();
            while( j< nombres.Count)
            {
                if(nombres[j] == nombreComprobar)
                {
                    nombres.RemoveAt(j);
                }
                j++;
            }
            nombresAux = nombres;
            int i = 0;
            bool ok = true;
            string nomAux;
            if (nombre.Contains(" "))
            {
                nombre = nombre.Replace(" ", string.Empty);
            }
            nombre = nombre.ToLower();

            while(i< nombresAux.Count && ok)
            {
                nomAux = nombresAux[i].ToLower();

                if (nomAux.Contains(" "))
                {
                    nomAux = nomAux.Replace(" ", string.Empty);
                }

                if (nombre == nomAux)
                {
                    ok = false;
                }
                i++;
            }
            return ok;
        }

        public static List<string> LeerNombreDeLibrerias()
        {
            List<string> nombreDeLibrerias = new List<string>();
            BindingList<Libreria> libs = new BindingList<Libreria>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
            libs = jArrayLibrerias.ToObject<BindingList<Libreria>>();
            foreach(Libreria libreria in libs)
            {
                nombreDeLibrerias.Add(libreria.Nombre);
            }
            return nombreDeLibrerias;
        }

        private void CambiarDeArchivoActiv(string nombreLibreria)
        {
            string nuevaRutaActividad = FormLibrerias.RutaActividades(nombreLibreria);


            BindingList<Actividad> act = new BindingList<Actividad>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(lib.actividesRuta));
            act = jArrayLibrerias.ToObject<BindingList<Actividad>>();

            JsonTextWriter jw = new JsonTextWriter(File.CreateText(nuevaRutaActividad));
            JToken.FromObject(act).WriteTo(jw);
            jw.Close();

            File.Delete(lib.actividesRuta);
            lib.actividesRuta = nuevaRutaActividad;
        }
    }
}
