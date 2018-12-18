using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OlorALibro.CRUD_users;

namespace OlorALibro
{
    public partial class FormLogin : Form
    {
        public string usuario; //esta propiedad sirve para ser enviada al FormPanel e indicar el usuario

        public bool admin; // esta propiedad sirve para saber si el usuario puede tener los permisos para gestionar los usuarios administradores

        public bool deleteUserBackgroundText = true;

        public bool deletePasswordBackgroundText = true;        

        List<Usuario> usuarios = new List<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxLoginPasswordText.Focus();
            if (File.Exists(@"..\..\Json\AdminUsers\loginAdmin.json"))
            {
                JArray jArrayUsers = JArray.Parse(File.ReadAllText(@"..\..\Json\AdminUsers\loginAdmin.json"));
                usuarios = jArrayUsers.ToObject<List<Usuario>>();
            }
            else
            {
                MessageBox.Show("List de usuarios no encontrada!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

      
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            int contador = 0;
            while (!login &&   contador <= (usuarios.Count() - 1))
            {
                if (textBoxLoginUserText.Text.ToLower() == usuarios[contador].User && textBoxLoginPasswordText.Text == usuarios[contador].Contrasenia)
                {
                    login = true;
                }
                else
                {
                    contador++;
                }
            };
            if (login)
            {
                labelIncorrecta.Visible = false;
                if (MessageBox.Show("Bienvenido, " + usuarios[contador].User + "!", "Login Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    formPanel f = new formPanel(usuarios[contador].User, usuarios[contador].admin);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                labelIncorrecta.Visible = true;
            }
        }

        private void textBoxLoginUserText_Enter(object sender, EventArgs e)
        {
            if(textBoxLoginUserText.Text == "User")
            {
                textBoxLoginUserText.Text = "";
                textBoxLoginUserText.ForeColor = Color.Black;
                textBoxLoginUserText.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxLoginUserText_Leave(object sender, EventArgs e)
        {
            if (textBoxLoginUserText.Text == "")
            {
                textBoxLoginUserText.Text = "User";
                textBoxLoginUserText.ForeColor = Color.DimGray;
                textBoxLoginUserText.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxLoginPasswordText_Enter(object sender, EventArgs e)
        {
            if (textBoxLoginPasswordText.Text == "Password")
            {
                textBoxLoginPasswordText.Text = "";
                textBoxLoginPasswordText.ForeColor = Color.Black;
                textBoxLoginPasswordText.TextAlign = HorizontalAlignment.Center;
                textBoxLoginPasswordText.PasswordChar = '•';
            }
        }

        private void textBoxLoginPasswordText_Leave(object sender, EventArgs e)
        {
            if (textBoxLoginPasswordText.Text == "")
            {
                textBoxLoginPasswordText.PasswordChar = '\0';
                textBoxLoginPasswordText.Text = "Password";
                textBoxLoginPasswordText.ForeColor = Color.DimGray;
                textBoxLoginPasswordText.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxLoginUserText_TextChanged(object sender, EventArgs e)
        {
            labelIncorrecta.Visible = false;
        }

        private void textBoxLoginPasswordText_TextChanged(object sender, EventArgs e)
        {
            labelIncorrecta.Visible = false;
        }

       
    }
}
