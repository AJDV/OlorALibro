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
        
        public string usuario { get; set; }

        public bool admin {get; set; }
        #endregion

        #region Constructor
        public formPanel(string usuario, bool admin)
        {
            this.usuario = usuario;
            this.admin = admin;
            InitializeComponent();
        }
        #endregion

        #region Metodos

        #region Eventos
        private void formPanel_Load(object sender, EventArgs e)
        {
            if (admin)
            {
                this.Text = "Panel de admnistrador (" + usuario.ToUpper() + ") - Admin";
            }
            else
            {
                this.Text = "Panel de admnistrador (" + usuario.ToUpper() + ") - No Admin";
                menuGestion.Visible = false;

            }
        }
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


        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("JUEGO", button1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mapa para busqueda de librerías");
            System.Diagnostics.Process.Start(Mapa.googleMaps);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosAdmins u = new UsuariosAdmins();
            u.ShowDialog();
        }

        private void buttonLogout_MouseHover(object sender, EventArgs e)
        {
            toolTipLogout.Show("logout", buttonLogout);
        }

        private void buttonExit_MouseHover(object sender, EventArgs e)
        {
            toolTipExit.Show("Exit", buttonExit);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs ec = new FormClosingEventArgs(CloseReason.None, false);
            formPanel_FormClosing(sender, ec);
        }

        private void usuariosLibreríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accesoFormUsuarios();
        }

        private void listaDeLibreríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaLibreria llbs = new ListaLibreria();
            llbs.ShowDialog();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListUsers users = new ListUsers();
            users.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs ec = new FormClosingEventArgs(CloseReason.None, false);
            formPanel_FormClosing(sender, ec);
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Mapa.listaLibroAmazon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JUEGO EN CONSTRUCCIÓN");
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JUEGO EN CONSTRUCCIÓN");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo i = new FormInfo();
            i.ShowDialog();
        }

        private void mapaDeLibreríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalizacion fl = new FormLocalizacion();
            fl.ShowDialog();
        }

        private void formPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("seguro que quieres cerrar la Aplicación?", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
        #endregion

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

        public void Logout()
        {
            if (MessageBox.Show("seguro que quieres Salir?", "LOGOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FormLogin f = new FormLogin();
                f.Show();
                Close();
            }
        }
        #endregion

       
    }
}