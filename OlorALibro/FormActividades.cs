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
    public partial class FormActividades : Form
    {
        #region Properties
        //Lista enlazada por referencia a la Lista de actividades
        BindingList<Actividad> acts = new BindingList<Actividad>();

        //Nombre de la libreria que nos servirá para el id de la actividad
        string nombrelib;

        //Actividad enlazada por referencia a una Actividad
        Actividad act = new Actividad();

        //Booleano para comprobar si haremos un ADD de la actividad en caso que no editemos
        bool siEdicion;

        private int posicion;

        private string filePathActiv;
        #endregion

        //Constructor general NO UTILiZADO
        public FormActividades()
        {
            InitializeComponent();
        }

        //Constructor donde le pasamos la Lista de Actividades
        public FormActividades(string filePath, bool siEdicion, string nombreLib)
        {
            InitializeComponent();
            filePathActiv = filePath;
            this.siEdicion = siEdicion;
            nombrelib = nombreLib;
        }

        //Constructor en caso de Edicion
        public FormActividades(string filePath, string nombreLib, int posicion, Actividad activdad)
        {
            InitializeComponent();
            filePathActiv = filePath;
            siEdicion = true;
            nombrelib = nombreLib;
            this.posicion = posicion;
            act = activdad;
        }
        
        //En el load comprobaremos si le pasamos una actividad, en caso de no pasarle crearemos una nueva
        private void Actividades_Load(object sender, EventArgs e)
        {
            if (siEdicion)
            {
                textBoxNombre.Text = act.Nombre;
                dateTimePickerFecha.Value = DateTime.Parse(act.Fecha);
                dateTimePickerHora.Value = DateTime.Parse(act.Hora);
                textBoxDescripcion.Text = act.Descripcion;
            }
        }

        //En el aceptar añadiremos datos a una actividad, pero solo haremos el add en caso de que no estemos modificando
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!siEdicion)
            {
                if (nombrelib.Contains(" "))
                {
                    nombrelib = nombrelib.Replace(" ", string.Empty);
                }

                if (ValidarCampos())
                {
                    LeerJson(filePathActiv);
                    acts.Add(new Actividad(nombrelib, textBoxNombre.Text, dateTimePickerFecha.Text, dateTimePickerHora.Text, textBoxDescripcion.Text, null));

                    EscribirJson(filePathActiv, acts);
                    MessageBox.Show("actividad registrada");
                }
            }
            if (siEdicion && HaSidoModificaco())
            {
                if (ValidarCampos())
                {
                    LeerJson(filePathActiv);
                    acts[posicion] = new Actividad(nombrelib, textBoxNombre.Text, dateTimePickerFecha.Text, dateTimePickerHora.Text, textBoxDescripcion.Text, null);
                    EscribirJson(filePathActiv, acts);
                    MessageBox.Show("ActividadAtualizada");
                }
            }
            Hide();
        }
        //El boton CANCELAR nos cerrará el form
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LeerJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
                    acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                }
                else
                {
                    acts = new BindingList<Actividad>();
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                    JToken.FromObject(acts).WriteTo(jw);
                    jw.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void EscribirJson(string filePath, BindingList<Actividad> acts)
        {
            try
            {
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                JToken.FromObject(acts).WriteTo(jw);
                jw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            if(textBoxNombre.Text == "" || textBoxDescripcion.Text == "")
            {
                ok = false;
            }
            return ok;
        }

        public bool HaSidoModificaco()
        {
            bool ok = false;
            if(textBoxNombre.Text != act.Nombre || textBoxDescripcion.Text != act.Descripcion || 
                dateTimePickerFecha.Text != act.Fecha || dateTimePickerHora.Text!= act.Hora)
            {
                ok = true;
            }
            return ok;
        }
    }
}
