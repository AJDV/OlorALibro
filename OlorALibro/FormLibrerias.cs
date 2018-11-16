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

        public FormLibrerias()
        {
            InitializeComponent();
        }

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
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Libreria l = new Libreria();
            l.Nombre = textBoxNom.Text;
            l.Direccion = textBoxDireccio.Text;
            l.Telefono = Int32.Parse(textBoxTelefon.Text);
            libs.Add(l);
            MessageBox.Show("Libreria guardada");
            limpiezaBox();
            guardarJSON();
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

        
    }
}
