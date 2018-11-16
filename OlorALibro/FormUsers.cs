using OlorALibro.CRUD_users;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace OlorALibro
{
    public partial class FormUsers : Form
    {
        BindingList<Usuario> usuarios = new BindingList<Usuario>();

        public FormUsers()
        {
            InitializeComponent();
        }

        private void updateGridJsonUsuarios()
        {
            JArray jArrayUsuarios = (JArray)JToken.FromObject(usuarios);

            StreamWriter fichero = File.CreateText(@"../../Json/AdminUsers/users.json");

            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);

            jArrayUsuarios.WriteTo(jsonWriter);

            jsonWriter.Close();

            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void editarUsuario()
        {
            try
            {
                Usuario u = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;

                Console.WriteLine();

                textBoxEditUser.Text = u.User;
                textBoxEditContrasenia.Text = u.Contrasenia;
                textBoxEditNombre.Text = u.Nombre;
                textBoxEditApellido.Text = u.Apellido;
                textBoxEditCorreo.Text = u.Correo;
                textBoxEditPuntos.Text = u.Puntos.ToString();

                tabControlEdicion.SelectedIndex = 1;
            }
            catch(Exception entry)
            {
                MessageBox.Show("No se ha seleccionado nigun usuario para editar!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void FormUsers_Load(object sender, EventArgs e)
        {
            JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Json/AdminUsers/users.json"));
            usuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();

            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void toolStripAniadir_Click(object sender, EventArgs e)
        {
            tabControlEdicion.SelectedIndex = 0;
            textBoxAddUser.Focus();
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            editarUsuario();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario(textBoxAddNombre.Text, textBoxAddContrasenia.Text, textBoxAddNombre.Text, textBoxAddApellido.Text, textBoxAddCorreo.Text, Int32.Parse(textBoxAddPuntos.Text));
                usuarios.Add(user);
                updateGridJsonUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Todos los campos son obligatorios!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBorrar_Click(object sender, EventArgs e)
        {
            
            if(dataGridViewUsuarios.CurrentRow != null)
            {
                DialogResult confirm = MessageBox.Show("Confirmar", "Borrar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirm == DialogResult.OK)
                {
                    usuarios.RemoveAt(dataGridViewUsuarios.CurrentRow.Index);
                    updateGridJsonUsuarios();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun usuario para borrar", "Borrar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarUsuario();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;

                u.User = textBoxEditUser.Text;
                u.Contrasenia = textBoxEditContrasenia.Text;
                u.Nombre = textBoxEditNombre.Text;
                u.Apellido = textBoxEditApellido.Text;
                u.Correo = textBoxEditCorreo.Text;
                u.Puntos = Int32.Parse(textBoxEditPuntos.Text);

                updateGridJsonUsuarios();

                dataGridViewUsuarios.Refresh();
            }
            catch(Exception entry)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }
}