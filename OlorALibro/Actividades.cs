using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    public partial class Actividades : Form
    {
        List<Actividad> acts;
        Actividad a = new Actividad();
        bool cambios = false;

        public Actividades()
        {
            InitializeComponent();
        }

        public Actividades(List<Actividad> acts)
        {
            InitializeComponent();
            this.acts = acts;
        }

        //public Actividades(Actividad a)
        //{
        //    InitializeComponent();
        //    this.a = a;
        //}

        private void Actividades_Load(object sender, EventArgs e)
        {
            //if (a != null)
            //{
            //    textBoxNombre.Text = a.Nombre;
            //    dateTimePickerFecha.Value = a.Fecha;
            //    textBoxDescripcion.Text = a.Descripción;
            //}
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            anadirActividad();
            guardarActividad();
            this.Close();
        }

        private void Actividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cambios)
            {
                anadirActividad();
                guardarActividad();
            }
        }

        private void anadirActividad()
        {
            a.Nombre = textBoxNombre.Text;
            a.Fecha = dateTimePickerFecha.Value;
            a.Descripción = textBoxDescripcion.Text;
        }

        private void guardarActividad()
        {
            DialogResult dr = MessageBox.Show("Está apunto de añadir una actividad, está seguro?", "Atención", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                acts.Add(a);
                cambios = true;
            }
            else
            {
                MessageBox.Show("No se ha añadido ninguna actividad", "Cambios no guardados", MessageBoxButtons.OK);
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
