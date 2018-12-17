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
        #region Properties
        public const string filePath = @"..\..\Json\ListaDeLibrerías\Librerias.json";

        public const string filePathAct = "..\\..\\Json\\ListaDeLibrerías\\ActivDeLibrerias\\Act_";

        BindingList<Libreria> libs;

        BindingList<Actividad> acts;

        Libreria l = new Libreria();

        private string linkWeb = "";

        private bool isAdding = false;

        private bool hasActivities; //confirma la existencia de actividades de una libreria

        private bool offActivitie = false; // cuando añade / elmina / edita una libreria, no dejar que se quite la seleccion de la libreria para ver el cambio de forma dinamica

        private bool isDelete = false;

        #endregion

        #region Constructor
        public FormLibrerias()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos
        #region eventos

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
            limpiezaBox();
            DimensionDeColumnas(dataGridViewLibrerias);
            DesactivarActivarEdicion(false);
            labelActExist.Visible = false;
        }

        //Grabamos el JSON en el activated
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            BindingList<Actividad> acts = new BindingList<Actividad>();
            //-------------
            int i = 0; // variable para verificar que el texto introducido es un numero
            float b = 0;
            //-------------
            if (textBoxNom.ReadOnly == true)
            {
                MessageBox.Show("No se puede Guardar, para editar, ir a 'EDITAR LIBRERIA'");
            }
            else // en este punto se hacen todas las comprobaciones pertinentes para poder guardar los datos sin ningún problema
            {
                if (textBoxNom.Text == "" || !FormEditar.ComprobarNombre(textBoxNom.Text, FormEditar.LeerNombreDeLibrerias()))
                {
                    if(!FormEditar.ComprobarNombre(textBoxNom.Text, FormEditar.LeerNombreDeLibrerias()))
                    {
                        MessageBox.Show("Este Nombre ya existe");
                        textBoxNom.Clear();
                        textBoxNom.Focus();
                    }
                    else
                    {
                        MessageBox.Show("nombre no valido");
                    }
                }
                else if (textBoxTelefon.Text == "" || !int.TryParse(textBoxTelefon.Text, out i) && textBoxTelefon.Text.Length < 9)
                {
                    MessageBox.Show("telefono no valido");
                }
                else if (textBoxDireccio.Text == "")
                {
                    MessageBox.Show("direccion no valido");
                }
                else if ((textBoxLatitud.Text == "LATITUD" || textBoxLatitud.Text == "") || (textBoxAltitud.Text == "ALTITUD" || textBoxAltitud.Text == "") || !float.TryParse(textBoxLatitud.Text, out b) || !float.TryParse(textBoxAltitud.Text, out b))
                {
                    MessageBox.Show("coordenadas no rellenadas");
                    textBoxAltitud.Focus();
                }
                else if (textBoxCorreo.Text == "" || !textBoxCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("correo no rellenado");
                    textBoxCorreo.Focus();
                }
                else
                {
                    if (MessageBox.Show("Guardar ?", "GUARDAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        try
                        {
                            if(libs.Count == 0)
                            {
                                libs = new BindingList<Libreria>();
                            }
                            libs.Add(new Libreria(textBoxNom.Text, textBoxDireccio.Text, int.Parse(textBoxTelefon.Text), textBoxCorreo.Text, $"{textBoxAltitud.Text},{textBoxLatitud.Text}", linkWeb, RutaActividades(textBoxNom.Text))); 
                            //añadimos un objeto con sus propiedades

                            JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                            JToken.FromObject(libs).WriteTo(jw);
                            jw.Close();

                            JsonTextWriter jwA = new JsonTextWriter(File.CreateText(RutaActividades(textBoxNom.Text)));
                            JToken.FromObject(acts).WriteTo(jwA);
                            jwA.Close();

                            RefresacarLista(libs);
                            MessageBox.Show("Libreria guardada");
                            limpiezaBox();
                            isAdding = false;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK);
                        }
                    }
                }

            }
        }

        //DAVID------------------------
        //Refrescar actividades y guardar JSON
        private void FormLibrerias_Activated(object sender, EventArgs e)
        {
            if (offActivitie && !isDelete)
            {
                dataGridViewActividades.DataSource = LeerJson(((Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem).actividesRuta);
            }
            if(dataGridViewActividades.Rows.Count > 0)
            {
                labelActExist.Visible = false;
            }
        }

        //Añadir una nueva actividad
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            if(dataGridViewLibrerias.SelectedRows.Count >0)
            {
                acts = new BindingList<Actividad>();
                offActivitie = true;
                l = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
                FormActividades f = new FormActividades(l.actividesRuta,false, l.Nombre);
                f.ShowDialog();

                dataGridViewActividades.DataSource = LeerJson(((Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem).actividesRuta);
                /* JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(l.actividesRuta));
                 acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                 dataGridViewActividades.DataSource = null;
                 dataGridViewActividades.DataSource = acts;*/
            }
            else
            {
                MessageBox.Show("Selecciona una Libreria");
            }


        }

        //Editar una actividad
        private void buttonEditarActividad_Click(object sender, EventArgs e)
        {
            offActivitie = true;
            if (dataGridViewActividades.SelectedRows.Count == 1)
            {
                try
                {
                    Libreria lib = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
                    Actividad act = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
                    FormActividades f = new FormActividades(lib.actividesRuta, lib.Nombre, dataGridViewActividades.CurrentRow.Index, act);
                    f.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Seleccionar una Actividad", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una Actividad");
            }
        }

        //Eliminar actividad
        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            isDelete = true;
            offActivitie = true;
            l = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
            acts = new BindingList<Actividad>();
            if(dataGridViewLibrerias.SelectedRows.Count == 1)
            {
                if(dataGridViewActividades.Rows.Count > 0)
                {
                    if(dataGridViewActividades.SelectedRows.Count > 0 )
                    {
                        if(MessageBox.Show("Elimar Actividad ? ", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            DataGridViewSelectedRowCollection rows = dataGridViewActividades.SelectedRows;
                            foreach(DataGridViewRow row in rows)
                            {
                                JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(l.actividesRuta));
                                acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                                acts.RemoveAt(row.Index);
                                JsonTextWriter jw = new JsonTextWriter(File.CreateText(l.actividesRuta));
                                JToken.FromObject(acts).WriteTo(jw);
                                jw.Close();
                            }
                            dataGridViewActividades.DataSource = null;
                            dataGridViewActividades.DataSource = acts;
                        }

                    }
                    else if(dataGridViewActividades.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Selecciona una Actividad");
                    }
                }
                else
                {
                    MessageBox.Show("No hay Actividades Registradas");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una Libreria");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Libreria libreria = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
            int row = dataGridViewLibrerias.CurrentRow.Index;
            int selected = dataGridViewLibrerias.SelectedRows.Count;
            if (selected == 1)
            {
                if(MessageBox.Show("Seguro que quieres eliminar lo seleccionado ? ", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                dataGridViewLibrerias.Rows.RemoveAt(row);
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                JToken.FromObject(libs).WriteTo(jw);
                jw.Close();
                RefresacarLista(libs);
                limpiezaBox();

                File.Delete(libreria.actividesRuta);
                dataGridViewActividades.Rows.Clear();
            }
            else if (row == 0)
            {
                MessageBox.Show("Ninguna Libreria seleccionada");
            }
        }

        private void dataGridViewLibrerias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //l = (Libreria) dataGridViewLibrerias.CurrentRow.DataBoundItem;
            //cargarActividades(l);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int selected = dataGridViewLibrerias.SelectedRows.Count;
            if (selected == 1)
            {
                FormEditar edit = new FormEditar((Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem);
                edit.ShowDialog();
                if (edit.cambios)
                {
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                    JToken.FromObject(libs).WriteTo(jw);
                    jw.Close();
                    RefresacarLista(libs);
                }
                MostrarDatos(libs[dataGridViewLibrerias.CurrentRow.Index]);
            }
            else if (selected > 1)
            {
                MessageBox.Show("Selecciona unicamente una librería");
            }
            else
            {
                MessageBox.Show("selecciona alguna librería");
            }
            
        }

        //Editar una actividad al hacer doble click sobre la row
        private void dataGridViewActividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libreria lib = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
            Actividad act = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            FormActividades f = new FormActividades(lib.actividesRuta, lib.Nombre, dataGridViewActividades.CurrentRow.Index, act);
            f.ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxAltitud.Text == "ALTITUD")
            {
                textBoxAltitud.Text = "";
                textBoxAltitud.TextAlign = HorizontalAlignment.Left;
                textBoxAltitud.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxAltitud.Text == "")
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            
                isAdding = true; // hace saber que estamos en modo add
                dataGridViewLibrerias.ClearSelection();
                limpiezaBox();
                DesactivarActivarEdicion(false);
                textBoxNom.Focus();
                buttonAdd.BackColor = Color.Transparent;
            
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTipAddLink.Show("Añadir Link", buttonLink);
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                FormLinkGoogle lG = new FormLinkGoogle();
                lG.ShowDialog();
                linkWeb = lG.linkWeb;
            }
            else
            {
                MessageBox.Show("Para añadir un Link debes añadir una Libreria");
            }
        }

        private void dataGridViewLibrerias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DesactivarActivarEdicion(true);
            if (dataGridViewLibrerias.SelectedRows.Count == 1)
            {
                MostrarDatosActividades();
                ClearSelectionGrid(dataGridViewActividades);
            }
            else
            {
                MessageBox.Show("Seleccionar solo una libreria");
            }

        }

        public void MostrarDatosActividades()
        {
            Libreria lib = libs[dataGridViewLibrerias.CurrentRow.Index];
            MostrarDatos(lib);
            DesactivarActivarEdicion(true);

            BindingList<Actividad> actividades = ObtenerActividades(lib);
            
            DimensionDeColumnas(dataGridViewActividades);
        }

        #endregion

        public static string RutaActividades(string nombreLib)
        {
            string ruta;
            if(nombreLib.Contains(" "))
            {
                ruta = $"{filePathAct}{nombreLib.Replace(" ", string.Empty)}.json";
            }
            else
            {
                ruta = $"{filePathAct}{nombreLib}.json";
            }
            return ruta ;
        }

        public BindingList<Actividad> ObtenerActividades(Libreria libreria)
        {
            try
            {
                if (File.Exists(libreria.actividesRuta))
                {
                    acts = new BindingList<Actividad>();
                    JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(libreria.actividesRuta));
                    acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                    if(acts.Count == 0 || acts == null)
                    {
                        dataGridViewActividades.DataSource = null;
                        dataGridViewActividades.Rows.Clear();
                        labelActExist.Visible = true;
                    }
                    else
                    {
                        labelActExist.Visible = false;
                        dataGridViewActividades.DataSource = acts;
                    }
                    hasActivities = true; 
                }
                else
                {
                    dataGridViewActividades.DataSource = null;
                    hasActivities = false;
                    labelActExist.Visible = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error de lectura");
            }
            return acts;
        }

        #region metodos propios
        public void limpiezaBox()
        {
            textBoxNom.Clear();
            textBoxDireccio.Clear();
            textBoxTelefon.Clear();
            textBoxCorreo.Clear();
            textBoxAltitud.Text = "ALTITUD";
            textBoxLatitud.Text = "LATITUD";
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
        //Método para refrescar la dataGridView
        private void refrescarGrid()
        {
            RefresacarLista(libs);

            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = l.Actividades;
        } 
        //----------------------------
        public void RefresacarLista(BindingList<Libreria> listaObjeto)
        {
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaObjeto;

            if (!offActivitie)
            {
                DataGridViewSelectedRowCollection rows = dataGridViewLibrerias.SelectedRows;
                foreach(DataGridViewRow row in rows)
                {
                    row.Selected = false;
                }
            }
            else
            {
                DataGridViewSelectedRowCollection rows = dataGridViewLibrerias.SelectedRows;
                foreach (DataGridViewRow row in rows)
                {
                    row.Selected = true;
                }
            }
        }

        public void DimensionDeColumnas(DataGridView dataGrid)
        {
            DataGridViewColumnCollection col = dataGridViewLibrerias.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewLibrerias.Size.Width / col.Count) - 1;
            }
           
        }        

        public void ClearSelectionGrid(DataGridView dataGrid)
        {
            DataGridViewSelectedRowCollection rows = dataGrid.SelectedRows;
            foreach(DataGridViewRow row in rows)
            {
                row.Selected = false;
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
            if (activ_desactiv)
            {
                buttonLink.Enabled = false;
            }
            else
            {
                buttonLink.Enabled = true;
            }
        }
        #endregion

        #endregion

        private void FormLibrerias_Click(object sender, EventArgs e)
        {
            offActivitie = false;
        }

        public bool CamposVacios()
        {
            bool ok = true;
            if(textBoxNom.Text != "" || textBoxTelefon.Text != "" || textBoxDireccio.Text != "" || textBoxCorreo.Text != "" || (textBoxAltitud.Text != ""  && textBoxAltitud.Text != "ALTITUD")|| (textBoxLatitud.Text != "" && textBoxLatitud.Text != "LATITUD"))
            {
                ok = false;
            }
            return ok;
        }

        private BindingList<Actividad> LeerJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
                    acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                }
                else
                {
                    acts = new BindingList<Actividad>();
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                    JToken.FromObject(acts).WriteTo(jw);
                    jw.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            return acts;
        }

        private void EscribirJson(string filePath, BindingList<Actividad> acts)
        {
            try
            {
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                JToken.FromObject(acts).WriteTo(jw);
                jw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

    }
}
