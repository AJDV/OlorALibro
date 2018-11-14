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

namespace OlorALibro.CRUD_users
{
    public partial class formPanel : Form
    {
        static string usuario;

        public formPanel()
        {
            InitializeComponent();
        }

        public static void setUser(string user)
        {
            usuario = user;
        }

        private void formPanel_Load(object sender, EventArgs e)
        {
            labelUser.Text = usuario;
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Json/AdminUsers/users.json"))
            {
                FormUsers a = new FormUsers();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el archivo de usuarios", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
            
        }
    }
}
