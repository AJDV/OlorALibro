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
        List<Usuario> usuarios = new List<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"E:\ABP\OlorALibro\OlorALibro\CRUD users\loginAdmin.json"))
            {
                JArray jArrayPelis = JArray.Parse(File.ReadAllText(@"E:\ABP\OlorALibro\OlorALibro\CRUD users\loginAdmin.json"));
                usuarios = jArrayPelis.ToObject<List<Usuario>>();
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
