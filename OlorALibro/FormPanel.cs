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
        string usuario;

        public formPanel(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void buttonLibreria_Click(object sender, EventArgs e)
        {
            FormLibrerias f = new FormLibrerias();
            f.ShowDialog();
        }
    }
}
