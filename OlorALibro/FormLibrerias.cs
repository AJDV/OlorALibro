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
        public String filePath = @"..\..\Json\ListaDeLibrerías\Librerias.json";
        BindingList<Libreria> libs;
        BindingList<Actividad> acts;
        Libreria l;

        public FormLibrerias()
        {
            InitializeComponent();
        }

        //VICTOR------------------------
        //Contiene el leer JSON por DAVID
        private void Librerias_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
                libs = jArrayLibrerias.ToObject<BindingList<Libreria>>();       
            }
            else
            {
                libs = new BindingList<Libreria>();
                StreamWriter file = File.CreateText(@"..\..\Json\ListaDeLibrerías\Librerias.json");
                JsonTextWriter jsonWriter = new JsonTextWriter(file);
            }

            dataGridViewLibrerias.DataSource = libs;

            //DAVID
            //LEER JSON ACTIVIDADES
            l.Actividades = new BindingList<Actividad>();

            if (File.Exists(@"..\..\act_lib.json"))
            {
                JArray ja = JArray.Parse(File.ReadAllText(@"..\..\act_lib.json"));
                l.Actividades = ja.ToObject<BindingList<Actividad>>();
            }

            dataGridViewActividades.DataSource = l.Actividades;
            dataGridViewActividades.ClearSelection();
        }

        public void cargarActividades(Libreria l)
        {
            String nombreLib = l.Nombre;
            nombreLib = nombreLib.Replace(" ", string.Empty);
            String activPath = @"..\..\Json\ListaDeLibrerías\ActivDeLibrerias\Act_" + nombreLib + ".json";   
              

            l.Actividades = new BindingList<Actividad>();

            if (File.Exists(activPath))
            {
                JArray jArrayActividades = JArray.Parse(File.ReadAllText(activPath));
                l.Actividades = jArrayActividades.ToObject<BindingList<Actividad>>();
            }
            else
            {
                MessageBox.Show(activPath);
            }
            dataGridViewActividades.DataSource = l.Actividades;
            dataGridViewActividades.ClearSelection();
        }

        //Contiene el grabar JSON Actividades por DAVID
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            l = new Libreria();
            l.Nombre = textBoxNom.Text;
            l.Direccion = textBoxDireccio.Text;
            l.Telefono = Int32.Parse(textBoxTelefon.Text);
            libs.Add(l);
            MessageBox.Show("Libreria guardada");
            limpiezaBox();
            guardarJSON();


            //DAVID
            //GRABAR JSON ACTIVIDADES
            JArray ja = (JArray)JToken.FromObject(l.Actividades);

            StreamWriter jw = File.CreateText(@"..\..\act_lib.json");
            JsonTextWriter jtw = new JsonTextWriter(jw);

            ja.WriteTo(jtw);

            jtw.Close();

            MessageBox.Show("Grabado correctamente!", "GRABADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void limpiezaBox()
        {
            textBoxNom.Clear();
            textBoxDireccio.Clear();
            textBoxTelefon.Clear();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            var data = dataGridViewLibrerias.SelectedCells;

            //Buscamos la libreria en la bindingList de librerias
            //for (int i = 0; i < libs.Count(); i++)
            //{
            //    if ()
            //}
            int p = 0, eliminar = 0; ;
            System.Windows.Forms.DialogResult msg;
            foreach (Libreria item in libs)
            {
                if (item.Nombre == textBoxNom.Text && item.Telefono == Int32.Parse(textBoxTelefon.Text) && item.Direccion == textBoxDireccio.Text)
                {
                    eliminar = p;
                }
                else
                {
                    p++;
                    msg = DialogResult.Cancel;
                }
            }

            if (MessageBox.Show("Esta seguro que desea eliminar la libreria?...", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                libs.RemoveAt(p);
            }
            limpiezaBox();
            guardarJSON();
            //MessageBox.Show(dataGridViewLibrerias.SelectedCells.ToString());
        }

        private void dataGridViewLibrerias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            //MessageBox.Show(dataGridViewLibrerias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            textBoxNom.Text = dataGridViewLibrerias.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTelefon.Text = dataGridViewLibrerias.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxDireccio.Text = dataGridViewLibrerias.Rows[e.RowIndex].Cells[1].Value.ToString();

            l = (Libreria) dataGridViewLibrerias.CurrentRow.DataBoundItem;
            cargarActividades(l);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Libreria toSend = new Libreria();
            foreach(Libreria item in libs)
            {
                if(item.Nombre == textBoxNom.Text && item.Telefono == Int32.Parse(textBoxTelefon.Text) && item.Direccion == textBoxDireccio.Text)
                {
                    toSend = item;
                }
            }
            FormEditar edit = new FormEditar(toSend);
            edit.ShowDialog();
            guardarJSON();
        }

        public void guardarJSON()
        {
            StreamWriter file = File.CreateText(filePath);
            JArray jArrayLibs = (JArray)JToken.FromObject(libs);
            JsonWriter jsonWriter = new JsonTextWriter(file);
            jArrayLibs.WriteTo(jsonWriter);
            jsonWriter.Close();
        }
        //----------------------------



        //DAVID------------------------
        //Refrescar actividades
        private void FormLibrerias_Activated(object sender, EventArgs e)
        {
            refrescarGrid();
        }

        //Añadir una nueva actividad
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            String nombrelib = textBoxNom.Text;
            l = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;

            FormActividades f = new FormActividades(l.Actividades, nombrelib);
            f.ShowDialog();
        }

        //Editar una actividad
        private void buttonEditarActividad_Click(object sender, EventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(a);
            f.ShowDialog();
        }

        //Eliminar actividad
        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro que desa eliminar esta atividad", "Eliminar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                l.Actividades.RemoveAt(dataGridViewActividades.SelectedRows[0].Index);
                refrescarGrid();
            }
        }

        //Método para refrescar la dataGridView
        private void refrescarGrid()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = l.Actividades;

            dataGridViewActividades.Columns[0].Visible = false;
            dataGridViewActividades.ClearSelection();
        }

        //Editar una actividad al hacer doble click sobre la row
        private void dataGridViewActividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(a);
            f.ShowDialog();
        }
        //----------------------------
    }
}
