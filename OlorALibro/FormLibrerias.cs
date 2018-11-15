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
        Libreria lib = new Libreria();

        public FormLibrerias()
        {
            InitializeComponent();
        }

        private void Librerias_Load(object sender, EventArgs e)
        {
            lib.Activs = new BindingList<Actividad>();
            dataGridViewActividades.DataSource = lib.Activs;
        }

        private void Librerias_Activated(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            FormActividades f = new FormActividades(lib.Activs);
            f.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(a);
            f.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro que desa eliminar esta atividad", "Eliminar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                lib.Activs.RemoveAt(dataGridViewActividades.SelectedRows[0].Index);
                refrescarGrid();
            }

        }

        private void refrescarGrid()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = lib.Activs;
        }

        private void dataGridViewActividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(a);
            f.ShowDialog();
        }
    }
}
