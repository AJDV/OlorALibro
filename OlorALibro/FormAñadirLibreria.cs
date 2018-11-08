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
    public partial class FormAñadirLibreria : Form
    {
        List<Libreria> l = new List<Libreria>();
        Libreria libreria = new Libreria();
        public FormAñadirLibreria(List<Libreria> list)
        {
            InitializeComponent();
            this.l = list;
        }

        private void FormAñadirLibreria_Load(object sender, EventArgs e)
        {
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            libreria.nom = textBoxNom.Text;
            libreria.telefon = int.Parse(textBoxTelefon.Text);
            libreria.direccio = textBoxDir.Text;
            l.Add(libreria);
            this.Close();
        }
    }
}
