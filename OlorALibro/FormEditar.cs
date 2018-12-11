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
    public partial class FormEditar : Form
    {

        public Libreria lib = new Libreria();

        public bool cambios = false;
     

        public FormEditar(Libreria lib)
        {
            InitializeComponent();
            this.lib = lib;
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            string[] coord = lib.Coordenadas.Split(',');
            textBoxNom.Text = lib.Nombre;
            textBoxDireccion.Text = lib.Direccion;
            textBoxTelefono.Text = lib.Telefono.ToString();
            textBoxCorreo.Text = lib.correo;
            textBoxAltitud.Text = coord[0];
            textBoxLatitud.Text = coord[1];
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(textBoxNom.Text == lib.Nombre && textBoxTelefono.Text == lib.Telefono.ToString() && textBoxDireccion.Text == lib.Direccion 
                && $"{textBoxAltitud.Text},{textBoxLatitud.Text}" == lib.Coordenadas && textBoxCorreo.Text == lib.correo)
            {
                MessageBox.Show("No hay cambios efectuados!");
            }
            else
            {
                lib.Nombre = textBoxNom.Text;
                lib.Direccion = textBoxDireccion.Text;
                lib.Telefono = int.Parse(textBoxTelefono.Text);
                lib.correo = textBoxCorreo.Text;
                lib.Coordenadas = $"{textBoxAltitud.Text},{textBoxLatitud.Text}";
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
    }
}
