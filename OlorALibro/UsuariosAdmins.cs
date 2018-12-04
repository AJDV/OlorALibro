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
    public partial class UsuariosAdmins : Form
    {
        private BindingList<UsuarioAdm> users;
        public UsuariosAdmins()
        {
            InitializeComponent();
        }

        private void UsuariosAdmins_Load(object sender, EventArgs e)
        {
            groupBoxAdmin.Visible = false;
            textBox3.PasswordChar = '•';
            textBox2.PasswordChar = '•';
            try
            {
                if (File.Exists(@"..\..\Json\AdminUsers\loginAdmin.json"))
                {
                    users = (JArray.Parse(File.ReadAllText(@"..\..\Json\AdminUsers\loginAdmin.json"))).ToObject<BindingList<UsuarioAdm>>();
                }
                else
                {
                    users = new BindingList<UsuarioAdm>();
                }
                dataGridView1.DataSource = users;
                dataGridView1.ScrollBars = ScrollBars.None;
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK);
            }

        }

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
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(@"..\..\Json\AdminUsers\loginAdmin.json"));
                    JToken.FromObject(users).WriteTo(jw);
                    jw.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users;
                    groupBoxAdmin.Visible = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    checkBoxAdmin.Checked = false;
                }

                
                
            }

            
        }

        private bool verificarContraseña()
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

        private bool VerificarUser()
        {
            bool ok = true;
            foreach(UsuarioAdm user in users)
            {
                if(user.User == textBox1.Text)
                {
                    ok = false;
                }
            }
            return ok;
        }

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
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(@"..\..\Json\AdminUsers\loginAdmin.json"));
                    JToken.FromObject(users).WriteTo(jw);
                    jw.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users;
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
    }
}
