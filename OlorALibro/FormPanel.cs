using System;
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
    }
}
