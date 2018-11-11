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
    public partial class Librerias : Form
    {
        Libreria lib = new Libreria();
        List<Actividad> acts;

        public Librerias()
        {
            InitializeComponent();
        }

        private void Librerias_Load(object sender, EventArgs e)
        {
            acts = lib.Activs;
            dataGridViewActividades.DataSource = acts;
        }

        private void Librerias_Activated(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            Actividades f = new Actividades(acts);
            f.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Actividad a = (Actividad) dataGridViewActividades.CurrentRow.DataBoundItem;
            //Actividades f = new Actividades(a);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            acts.RemoveAt(dataGridViewActividades.SelectedRows[0].Index);
            refrescarGrid();
        }

        private void refrescarGrid()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = acts;
        }
    }
}
