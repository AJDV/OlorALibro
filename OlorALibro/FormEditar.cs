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

        Libreria lib = new Libreria();

        public FormEditar(Libreria lib)
        {
            InitializeComponent();
            this.lib = lib;
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = lib.Nombre;
            textBoxDireccion.Text = lib.Direccion;
            textBoxTelefono.Text = lib.Telefono.ToString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            lib.Nombre = textBoxNom.Text;
            lib.Direccion = textBoxDireccion.Text;
            lib.Telefono = Int32.Parse(textBoxTelefono.Text);
            MessageBox.Show("Libreria Actualizada");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
