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
    public partial class FormLibrerias : Form
    {
        List<Libreria> libs = new List<Libreria>();
        /* Demomento esto la hace siempre new al abrir, en un
        futuro se deberia comprobar si existe el JSON para 
        cojer los datos de alli con if-else statement*/
        public FormLibrerias()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FormAñadirLibreria f = new FormAñadirLibreria(libs);
            f.ShowDialog();
        }
    }
}
