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
        Libreria l = new Libreria();

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

            RefresacarLista(libs);
            DimensionDeColumnas(dataGridViewLibrerias);
            dataGridViewLibrerias.ClearSelection();
        }

        public void cargarActividades(Libreria l)
        {
            string nombreLib = l.Nombre;
            nombreLib = nombreLib.Replace(" ", string.Empty);
            string activPath = @"..\..\Json\ListaDeLibrerías\ActivDeLibrerias\Act_" + nombreLib + ".json";   
              

            l.Actividades = new BindingList<Actividad>();

            if (File.Exists(activPath))
            {
                JArray jArrayActividades = JArray.Parse(File.ReadAllText(activPath));
                l.Actividades = jArrayActividades.ToObject<BindingList<Actividad>>();
            }
            else
            {
                //GRABAR JSON ACTIVIDADES
                JArray ja = (JArray)JToken.FromObject(l.Actividades);
                StreamWriter jw = File.CreateText(activPath);
                JsonTextWriter jtw = new JsonTextWriter(jw);
                ja.WriteTo(jtw);
                jtw.Close();

                MessageBox.Show("Grabado correctamente!", "GRABADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewActividades.DataSource = l.Actividades;
            dataGridViewActividades.ClearSelection();
        }

        //Grabamos el JSON en el activated
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNom.ReadOnly == true)
            {
                MessageBox.Show("No se puede Guardar, para editar, ir a 'EDITAR LIBRERIA'");
            }
            else // en este punto se hacen todas las comprobaciones pertinentes para poder guardar los datos sin ningún problema
            {
                if (textBoxNom.Text == "")
                {
                    MessageBox.Show("Te has dejado el nombre de la libreria");
                }
                else if (textBoxTelefon.Text == "")
                {
                    MessageBox.Show("Te has dejado el telefono de la libreria");
                }
                else if (textBoxDireccio.Text == "")
                {
                    MessageBox.Show("Te has dejado la direccion de la libreria");
                }
                else if ((textBoxLatitud.Text == "LATITUD" || textBoxLatitud.Text == "") || (textBoxAltitud.Text == "ALTITUD" || textBoxAltitud.Text == ""))
                {
                    MessageBox.Show("Las coordenadas no esta rellenadas al completo!");
                    textBoxAltitud.Focus();
                }
                else if (textBoxCorreo.Text == "")
                {
                    MessageBox.Show("El correo no esta rellenado");
                    textBoxCorreo.Focus();
                } 
                else
                {
                    if(MessageBox.Show("Guardar ?", "GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        try
                        {
                            libs.Add(new Libreria(textBoxNom.Text, textBoxDireccio.Text, Int32.Parse(textBoxTelefon.Text), textBoxCorreo.Text, $"{textBoxAltitud.Text},{textBoxLatitud.Text}"));
                            JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                            JToken.FromObject(libs).WriteTo(jw);
                            jw.Close();
                            RefresacarLista(libs);
                            MessageBox.Show("Libreria guardada");
                            limpiezaBox();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK);
                        }
                    }
                }         

            }
        }

        public void limpiezaBox()
        {
            textBoxNom.Clear();
            textBoxDireccio.Clear();
            textBoxTelefon.Clear();
            textBoxCorreo.Clear();
            textBoxAltitud.Text = "ALTITUD";
            textBoxLatitud.Text = "LATITUD";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {            
            int row = dataGridViewLibrerias.CurrentRow.Index;
            int selected = dataGridViewLibrerias.SelectedRows.Count;
            if(selected == 1 && MessageBox.Show("Seguro que quieres eliminar lo seleccionado ? ", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                dataGridViewLibrerias.Rows.RemoveAt(row);
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                JToken.FromObject(libs).WriteTo(jw);
                jw.Close();
                RefresacarLista(libs);
            }
            else if(row == 0)
            {
                MessageBox.Show("Ninguna Libreria seleccionada");
            }
        }

        private void dataGridViewLibrerias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            l = (Libreria) dataGridViewLibrerias.CurrentRow.DataBoundItem;
            cargarActividades(l);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int selected = dataGridViewLibrerias.SelectedRows.Count;
            if (selected == 1)
            {
                int pos = dataGridViewLibrerias.CurrentRow.Index ;
                FormEditar edit = new FormEditar(libs[pos]);
                edit.ShowDialog();
                if (edit.cambios)
                {
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                    JToken.FromObject(libs).WriteTo(jw);
                    jw.Close();
                    RefresacarLista(libs);
                }


            }
            else if(selected > 1)
            {
                MessageBox.Show("Selecciona unicamente una librería");
            }
            else
            {
                MessageBox.Show("selecciona alguna librería");
            }

            //guardarJSON();
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
        //Refrescar actividades y guardar JSON
        private void FormLibrerias_Activated(object sender, EventArgs e)
        {
            //Refrescar grid
            refrescarGrid();

            MostrarDatos(libs[dataGridViewLibrerias.CurrentRow.Index]);
        }

        //Añadir una nueva actividad
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            
            l = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
            String nombrelib = l.Nombre;
            FormActividades f = new FormActividades(l.Actividades, nombrelib);
            f.ShowDialog();
        }

        //Editar una actividad
        private void buttonEditarActividad_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad a = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
                FormActividades f = new FormActividades(a);
                f.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Todos los campos son obligatorios!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            RefresacarLista(libs);

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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBoxAltitud.Text == "ALTITUD")
            {
                textBoxAltitud.Text = "";
                textBoxAltitud.TextAlign = HorizontalAlignment.Left;
                textBoxAltitud.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBoxAltitud.Text == "")
            {
                textBoxAltitud.TextAlign = HorizontalAlignment.Center;
                textBoxAltitud.ForeColor = Color.DarkGray;
                textBoxAltitud.Text = "ALTITUD";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBoxLatitud.Text == "LATITUD")
            {
                textBoxLatitud.Text = "";
                textBoxLatitud.TextAlign = HorizontalAlignment.Left;
                textBoxLatitud.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxLatitud.Text == "")
            {
                textBoxLatitud.TextAlign = HorizontalAlignment.Center;
                textBoxLatitud.ForeColor = Color.DarkGray;
                textBoxLatitud.Text = "LATITUD";
            }
        }
        //----------------------------

        public void RefresacarLista(BindingList<Libreria> listaObjeto)
        {
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaObjeto;
        }

        public void DimensionDeColumnas(DataGridView dataGrid)
        {
            DataGridViewColumnCollection col = dataGridViewLibrerias.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewLibrerias.Size.Width / col.Count) - 1;
            }
           
        }

        private void dataGridViewLibrerias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewLibrerias.SelectedRows.Count == 1)
            {
                Libreria lib = libs[dataGridViewLibrerias.CurrentRow.Index];
                MostrarDatos(lib);
                DesactivarActivarEdicion(true);
            }
            else
            {
                MessageBox.Show("Seleccionar solo una libreria");
            }
                
        }

        public void DesactivarActivarEdicion(bool activ_desactiv)
        {
            textBoxNom.ReadOnly = activ_desactiv;
            textBoxTelefon.ReadOnly = activ_desactiv;
            textBoxCorreo.ReadOnly = activ_desactiv;
            textBoxDireccio.ReadOnly = activ_desactiv;
            textBoxAltitud.ReadOnly = activ_desactiv;
            textBoxLatitud.ReadOnly = activ_desactiv;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridViewLibrerias.ClearSelection();
            limpiezaBox();
            DesactivarActivarEdicion(false);
            textBoxNom.Focus();
        }

        private void buttonAdd_MouseHover(object sender, EventArgs e)
        {
            toolTipadd.Show("Añadir Librería", buttonAdd);
        }

        private void buttonAnadir_MouseHover(object sender, EventArgs e)
        {
            buttonAnadir.ForeColor = Color.Orange;
        }

        private void buttonEliminarActividad_MouseHover(object sender, EventArgs e)
        {
            buttonEliminarActividad.ForeColor = Color.Orange;
        }

        private void buttonEditarActividad_MouseHover(object sender, EventArgs e)
        {
            buttonEditarActividad.ForeColor = Color.Orange;
        }

        private void buttonAnadir_MouseLeave(object sender, EventArgs e)
        {
            buttonAnadir.ForeColor = Color.White;
        }

        private void buttonEliminarActividad_MouseLeave(object sender, EventArgs e)
        {
            buttonEliminarActividad.ForeColor = Color.White;
        }

        private void buttonEditarActividad_MouseLeave(object sender, EventArgs e)
        {
            buttonEditarActividad.ForeColor = Color.White;
        }

        public void MostrarDatos(Libreria unaLibreria)
        {
            string[] coord = unaLibreria.Coordenadas.Split(','); //para separar las diferentes coordenadas
            textBoxNom.Text = unaLibreria.Nombre;
            textBoxTelefon.Text = unaLibreria.Telefono.ToString();
            textBoxCorreo.Text = unaLibreria.correo;
            textBoxDireccio.Text = unaLibreria.Direccion;
            textBoxAltitud.Text = coord[0];
            textBoxLatitud.Text = coord[1];
        }
    }
}
