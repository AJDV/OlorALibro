using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            textBoxLoginUserText.Focus();
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
                MessageBox.Show("Bienvenido, " + usuarios[contador].User + "!", "Login Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.usuario = usuarios[contador].User;
                this.admin = usuarios[contador].admin;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                labelIncorrecta.Visible = true;
            }
        }

        private void textBoxLoginUserText_TextChanged(object sender, EventArgs e)
        {
            labelIncorrecta.Visible = false;
            if (deleteUserBackgroundText)
            {
                textBoxLoginUserText.Text = "";
                deleteUserBackgroundText = false;
            }
            textBoxLoginUserText.TextAlign = HorizontalAlignment.Left;
            textBoxLoginUserText.ForeColor = Color.Black;                    
        }

        private void textBoxLoginPasswordText_TextChanged(object sender, EventArgs e)
        {
            labelIncorrecta.Visible = false;
            if (deletePasswordBackgroundText)
            {
                textBoxLoginPasswordText.Text = "";
                deletePasswordBackgroundText = false;
            }
            textBoxLoginPasswordText.TextAlign = HorizontalAlignment.Left;
            textBoxLoginPasswordText.ForeColor = Color.Black;
            textBoxLoginPasswordText.PasswordChar = '•';

        }
    }
}
