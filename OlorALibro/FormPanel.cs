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
        #region Propiedades
        public string usuario;

        public bool admin;
        #endregion

        #region Constructor
        public formPanel(string usuario, bool admin)
        {
            this.usuario = usuario;
            this.admin = admin;
            InitializeComponent();
        }
        #endregion

        private void formPanel_Load(object sender, EventArgs e)
        {            
            if (admin)
            {
                this.Text = "Panel de admnistrador (" + usuario.ToUpper()+") - Admin";
            }
            else
            {
                this.Text = "Panel de admnistrador (" + usuario.ToUpper() + ") - No Admin";
                menuGestion.Visible = false;

            }
        }


        #region Accesos
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            accesoFormUsuarios();
        }

        private void buttonLibreria_Click(object sender, EventArgs e)
        {
            accesoFormLibrerias();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            accesoFormUsuarios();
        }

        private void pictureUsuarios_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureUsuarios_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureUsuarios_MouseHover_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureUsuarios_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureLibrerias_Click(object sender, EventArgs e)
        {
            accesoFormLibrerias();
        }

        private void accesoFormLibrerias()
        {
            FormLibrerias l = new FormLibrerias();
            l.ShowDialog();
        }

        private void accesoFormUsuarios()
        {
            FormUsers a = new FormUsers();
            a.ShowDialog();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("JUEGO", button1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mapa m = new Mapa();
            m.ShowDialog();
        }
    }
}
