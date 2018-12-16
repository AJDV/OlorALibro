using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OlorALibro.CRUD_users;
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
    public partial class UsuariosAdmins : Form
    {
        #region Properties
        private BindingList<UsuarioAdm> users;

        public static string filePath = @"..\..\Json\AdminUsers\loginAdmin.json";
        #endregion

        #region Constructor
        public UsuariosAdmins()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
       
        private void UsuariosAdmins_Load(object sender, EventArgs e)
        {
            groupBoxAdmin.Visible = false;
            textBox3.PasswordChar = '•';
            textBox2.PasswordChar = '•';
            try
            {
                if (File.Exists(filePath))
                {
                    users = (JArray.Parse(File.ReadAllText(filePath))).ToObject<BindingList<UsuarioAdm>>();
                }
                else
                {
                    users = new BindingList<UsuarioAdm>();
                }
                dataGridView1.DataSource = users;
                dataGridView1.ScrollBars = ScrollBars.None;
                dataGridView1.Columns["Contrasenia"].Visible = false;
                DataGridViewColumnCollection col = dataGridView1.Columns;
                col.RemoveAt(2);
                foreach(DataGridViewColumn co in col)
                {
                    co.Width = dataGridView1.Size.Width / col.Count;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK);
            }

        }

        #endregion

        #region Methods

        #region buttons
        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxAdmin.Visible = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && VerificarUser() && verificarContraseña())
            {
                if(MessageBox.Show("GUARDAR ?", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    users.Add(new UsuarioAdm(checkBoxAdmin.Checked, textBox1.Text, textBox3.Text));
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                    JToken.FromObject(users).WriteTo(jw);
                    jw.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users;
                    dataGridView1.Columns["Contrasenia"].Visible = false;
                    DataGridViewColumnCollection col = dataGridView1.Columns;
                    col.RemoveAt(2);
                    foreach (DataGridViewColumn co in col)
                    {
                        co.Width = dataGridView1.Size.Width / col.Count;
                    }
                    dataGridView1.ClearSelection();
                    groupBoxAdmin.Visible = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    checkBoxAdmin.Checked = false;
                }   
            }

            
        }

        #region Metodos suplementarios
        private bool verificarContraseña() //Verificamos Coincidencia de la contraseña para asegurar que la contraseña es la deseada
        {
            bool ok = false;
            if (textBox3.Text!="" && (textBox3.Text == textBox2.Text))
            {
                ok = true;
            }
            else
            {
                MessageBox.Show("La contraseña no coincide", "MENSAJE", MessageBoxButtons.OK);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox3.Focus();   
            }
            return ok;
        }

        private bool VerificarUser() //Verificamos que este usuario no exista
        {
            bool ok = true;
            foreach(UsuarioAdm user in users)
            {
                if(user.User == textBox1.Text)
                {
                    ok = false;
                    MessageBox.Show(textBox1.Text + " ya existe como nombre de Usuario, introduce uno valido!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            return ok;
        }
        #endregion

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '•';
            textBox3.PasswordChar = '•';
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
            textBox3.PasswordChar = '\0';
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            groupBoxAdmin.Visible = false;
            if(dataGridView1.SelectedRows.Count != 0)
            {
                if(MessageBox.Show("Seguro que quieres eliminar ?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    users.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                    JToken.FromObject(users).WriteTo(jw);
                    jw.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users;
                    dataGridView1.Columns["Contrasenia"].Visible = false;
                    DataGridViewColumnCollection col = dataGridView1.Columns;
                    col.RemoveAt(2);
                    foreach (DataGridViewColumn co in col)
                    {
                        co.Width = dataGridView1.Size.Width / col.Count;
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    dataGridView1.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun usuario", "MENSAJE", MessageBoxButtons.OK);
            }
        }

        private void buttonDelete_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("delete user", buttonDelete);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("add user", button1);
        }
        #endregion
        #endregion
    }
}
