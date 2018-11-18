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
    public partial class FormLibrerias : Form
    {
        //Creo una libreria auxiliar, debería pasarle una
        Libreria lib = new Libreria();

        //Deberemos pasarle el nombre de la Libreria para realizar el id de la actividad
        String nombrelib;

        public FormLibrerias()
        {
            InitializeComponent();
        }

        //LEEMOS EL JSON
        private void Librerias_Load(object sender, EventArgs e)
        {
            lib.Activs = new BindingList<Actividad>();

            if (File.Exists(@"..\..\act_lib.json"))
            {
                JArray ja = JArray.Parse(File.ReadAllText(@"..\..\act_lib.json"));
                lib.Activs = ja.ToObject<BindingList<Actividad>>();
            }
 
            dataGridViewActividades.DataSource = lib.Activs;
        }

        //GRABAMOS EL JSON
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            JArray ja = (JArray) JToken.FromObject(lib.Activs);

            StreamWriter jw = File.CreateText(@"..\..\act_lib.json");
            JsonTextWriter jtw = new JsonTextWriter(jw);

            ja.WriteTo(jtw);

            jtw.Close();

            MessageBox.Show("Grabado correctamente!", "GRABADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Refrescamos la dataGrid por cada activated llamando al metodo refrescarGrid()
        private void Librerias_Activated(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        //Añadir una nueva actividad
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            nombrelib = textBoxNombreLibreria.Text;
            FormActividades f = new FormActividades(lib.Activs, nombrelib);
            f.ShowDialog();
        }

        //Editar una actividad
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(a);
            f.ShowDialog();
        }

        //Eliminar una actividad
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro que desa eliminar esta atividad", "Eliminar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                lib.Activs.RemoveAt(dataGridViewActividades.SelectedRows[0].Index);
                refrescarGrid();
            }

        }

        //Método para refrescar la dataGridView
        private void refrescarGrid()
        {
            //dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = lib.Activs;
        }

        //Editar una actividad al hacer doble click sobre la row
        private void dataGridViewActividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(a);
            f.ShowDialog();
        }
    }
}
