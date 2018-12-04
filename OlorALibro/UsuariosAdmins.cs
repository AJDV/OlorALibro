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
                if (File.Exists(@"..\..\Json\AdminUsers\loginAdmin.json"))
                {
                    users = (JArray.Parse(File.ReadAllText(@"..\..\Json\AdminUsers\loginAdmin.json"))).ToObject<BindingList<UsuarioAdm>>();
                }
                else
                {
                    users = new BindingList<UsuarioAdm>();
                }
                dataGridView1.DataSource = users;                   //asociamos el dataGrid con el Json
                dataGridView1.ScrollBars = ScrollBars.None;         //quitamos el Scroll para no ver la columna de contraseña (un poco chapuza), pero es para no hacer una clase con solo admin y user
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
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(@"..\..\Json\AdminUsers\loginAdmin.json"));
                    JToken.FromObject(users).WriteTo(jw);
                    jw.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users; //refrescamos el dataGrid
                    groupBoxAdmin.Visible = false;    //quitamos el formulario de añadir usuario
                    textBox1.Clear();                 //refrescamos el formulario;
                    textBox2.Clear();
                    textBox3.Clear();
                    checkBoxAdmin.Checked = false;
                }               
            }
            dataGridView1.ClearSelection();         //quitamos la selecion de fila para no eliminar un usuario por descuido
        }

        //Los siguientes dos metodos son para habilitar la visibilidad al hacer click o levantar el dedo del click
        //-------------------------------------------------------------
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
        //-------------------------------------------------------------
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            groupBoxAdmin.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que quieres eliminar ?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    users.RemoveAt(dataGridView1.CurrentCell.RowIndex); //eliminamos el usuario en la posicion deseada
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(@"..\..\Json\AdminUsers\loginAdmin.json"));
                    JToken.FromObject(users).WriteTo(jw); //sobreescribimos el archivo Json
                    jw.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = users;    //refrescamos el dataGrid
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
        #endregion

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

        #endregion
    }
}
