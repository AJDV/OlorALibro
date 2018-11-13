using Newtonsoft.Json.Linq;
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
using OlorALibro.CRUD_users;

namespace OlorALibro
{
    public partial class FormLogin : Form
    {
        BindingList<Usuario> usuarios = new BindingList<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            String path =  "..\\..\\CRUD users\\loginAdmin.json";
            //MessageBox.Show(path);

            //path = path.Remove(path.Length - 11);
            //path = path + "..\\..\\CRUD users\\loginAdmin.json";
            //MessageBox.Show(path);

            if (File.Exists(path))
            {
                JArray jArrayPelis = JArray.Parse(File.ReadAllText(path));
                usuarios = jArrayPelis.ToObject<BindingList<Usuario>>();
            }
            else
            {
                MessageBox.Show("BindingList de usuarios no encontrada!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            int contador = 0;
            while (!login && (usuarios.Count() - 1) >= contador)
            {
                if (textBoxLoginUserText.Text == usuarios[contador].usuario && textBoxLoginPasswordText.Text == usuarios[contador].password)
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
                MessageBox.Show("Bienvenido, " + usuarios[contador].usuario + "!", "Login Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                labelIncorrecta.Visible = true;
            }
        }
    }
}
