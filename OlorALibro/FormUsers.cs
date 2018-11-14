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

        private void updateGridJson()
        {
            JArray jArrayUsuarios = (JArray)JToken.FromObject(usuarios);

            StreamWriter fichero = File.CreateText(@"../../Json/AdminUsers/users.json");

            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);

            jArrayUsuarios.WriteTo(jsonWriter);

            jsonWriter.Close();

            dataGridViewUsuarios.DataSource = usuarios;
        }

        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
                JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Json/AdminUsers/users.json"));
                usuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();

                dataGridViewUsuarios.DataSource = usuarios;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControlEdicion.SelectedIndex = 0;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tabControlEdicion.SelectedIndex = 1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario(textBoxAddNombre.Text, textBoxAddContrasenia.Text, textBoxAddNombre.Text, textBoxAddApellido.Text, textBoxAddCorreo.Text, Int32.Parse(textBoxAddPuntos.Text));
                usuarios.Add(user);
                updateGridJson();
            }
            catch (Exception)
            {
                MessageBox.Show("Todos los campos son obligatorios!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirmar", "Borrar usuario", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                usuarios.RemoveAt(dataGridViewUsuarios.CurrentRow.Index);
                updateGridJson();
            }            
        }

        private void dataGridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlEdicion.SelectedIndex = 1;
            textBoxEditUser.Text = dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxEditContrasenia.Text = dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxEditNombre.Text = dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxEditApellido.Text = dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxEditCorreo.Text = dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentRow.Index].Cells[4].Value.ToString();
            textBoxEditPuntos.Text = dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}