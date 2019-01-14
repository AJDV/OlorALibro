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

namespace OlorALibro
{
    public partial class FormUsers : Form
    {
        BindingList<Usuario> usuarios = new BindingList<Usuario>();

        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"E:\ABP\OlorALibro\OlorALibro\CRUD users\users.json"))
            {
                JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"E:\ABP\OlorALibro\OlorALibro\CRUD users\users.json"));
                usuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
            }
            else
            {
                MessageBox.Show("El archivo no existe", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            if (usuarios.Count > 0)
            {
                dataGridViewUsuarios.DataSource = usuarios;
            }
            else
            {
                MessageBox.Show("ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
