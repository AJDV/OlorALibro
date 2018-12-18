using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;
using OlorALibro.CRUD_users;

namespace OlorALibro
{
    public partial class FormUsers : Form
    {
        #region Properties
        BindingList<Usuario> usuarios;
        public const int PUNTOS_MAX = 100; // el limite a partir del cual el adminsitrador es notificado de que hay usuarios
                                            // que tienen los puntos suficientes para alguna promo (por ejemplo)
        BindingList<Usuario> userNot;

        public static string filePath = @"..\..\Json\AdminUsers\users.json";        

        int numUsuarios = 0;
        #endregion

        #region Constructor

        public FormUsers()
        {
            InitializeComponent();
        }

        #endregion

        private void FormUsers_Load(object sender, EventArgs e)
        {
            userNot = new BindingList<Usuario>();
            JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../JsonAndroid/users.json"));
            usuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
            GridRefresh();

            foreach (Usuario user in usuarios)
            {
                if (user.Puntos > PUNTOS_MAX)
                {
                    userNot.Add(user);
                }
            }
            numUsuarios = userNot.Count;

            if (numUsuarios > 0)
            {
                labelNot.Text = numUsuarios.ToString();
            }

            dimensionesColumnes();
        }



        private void buttonCorreo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/ServiceLogin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail&passive=1209600&sacu=1&ignoreShadow=0&hl=en-GB&acui=0&flowName=GlifWebSignIn&flowEntry=AddSession");
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            if(!groupBoxUser.Visible)
            {
                groupBoxUser.Visible = true;
            }
            else if (groupBoxUser.Visible)
            {
                groupBoxUser.Visible = false;
            }
            //--------
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona algun usuario para visualizar sus datos");
            }
            
        }

        public void GridRefresh()
        {
            dataGridViewUsuarios.ClearSelection();
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = usuarios;
            //---------------------- ancho de columnas
            DataGridViewColumnCollection col = dataGridViewUsuarios.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewUsuarios.Size.Width / 3);
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (groupBoxUser.Visible)
            {
                //-------- rellenar la informacion de la muestra de Datos
                Usuario u = usuarios[dataGridViewUsuarios.CurrentRow.Index];
                textBoxNombre.Text = u.Nombre;
                textBoxUsuario.Text = u.User;
                textBoxApellido.Text = u.Apellido;
                textBoxCorreo.Text = u.Correo;
                textBoxContrasenia.Text = u.Contrasenia;
                textBoxPuntos.Text = u.Puntos.ToString();
                //--------
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            userNot = new BindingList<Usuario>();
            DataGridViewSelectedRowCollection rows = dataGridViewUsuarios.SelectedRows;

            if(rows.Count > 0 && MessageBox.Show("Eliminar lo seleccionado ?", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in rows)
                {
                    dataGridViewUsuarios.Rows.RemoveAt(row.Index);
                }
                GrabarDatosEnJson();

                JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Json/AdminUsers/users.json"));
                usuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
                foreach (Usuario user in usuarios)
                {
                    if (user.Puntos > PUNTOS_MAX)
                    {
                        userNot.Add(user);
                    }
                }
                numUsuarios = userNot.Count;

                if (numUsuarios > 0)
                {
                    labelNot.Text = numUsuarios.ToString();
                }
                GridRefresh();   
            }
            else if(rows.Count == 0)
            {
                MessageBox.Show("Debes seleccionar algun usuario para poder Borrar");
            }            
        }

        public void GrabarDatosEnJson()
        {
            //---------- grabar JSONs
            JsonTextWriter jsonWriter = new JsonTextWriter(File.CreateText(@"../../Json/AdminUsers/users.json"));
            JToken.FromObject(usuarios).WriteTo(jsonWriter);
            jsonWriter.Close();
            //----------
        }

        private void buttonCorreo_MouseHover(object sender, EventArgs e)
        {
            toolTipMail.Show("EMAIL", buttonCorreo);
        }

        private void buttonEliminar_MouseHover(object sender, EventArgs e)
        {
            toolTipDelete.Show("Borrar", buttonEliminar);
        }

        private void buttonMostrar_MouseHover(object sender, EventArgs e)
        {
            toolTipAdd.Show("Mostrar", buttonMostrar);
        }

        public void dimensionesColumnes()
        {
            DataGridViewSelectedRowCollection rows = dataGridViewUsuarios.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                row.Selected = false;
            }
            groupBoxUser.Visible = false;
        }

        private void buttonNotif_Click(object sender, EventArgs e)
        {
            FormNotificaciones fn = new FormNotificaciones(numUsuarios, PUNTOS_MAX);
            fn.Show();
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPanel.EscribirJsonUsuariosAJsonApp();
        }
    }
}