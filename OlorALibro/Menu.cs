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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Librerias l = new Librerias();
            l.ShowDialog();
        }
    }
}
