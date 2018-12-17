using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public bool closing = false; // permite saber que tipo de cierre es, si mediante boton o X(cruz)

        public const string filePathJsonAppActiv = @"..\..\JsonAndroid\Actividades.json";

        public const string filePathJsonAppLibrerias = @"..\..\JsonAndroid\Librerias.json";

        public const string filePathJsonAppUsuarios = @"..\..\JsonAndroid\Usuarios.json";

        int closed = 0;
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

            BindingList<Usuario> userNot = new BindingList<Usuario>();
            BindingList<Usuario> usuarios = new BindingList<Usuario>();
            JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Json/AdminUsers/users.json"));
            usuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();

            foreach (Usuario user in usuarios)
            {
                if (user.Puntos > FormUsers.PUNTOS_MAX)
                {
                    userNot.Add(user);
                }
            }
            int numUsuarios = userNot.Count;

            if (numUsuarios > 0)
            {
                labelNot.Text = numUsuarios.ToString();
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
            if(MessageBox.Show("Salir de la aplicación ?", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                closing = true;
                Application.Exit();
            }
            else
            {
                closing = false;
            }
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
            if (MessageBox.Show("Salir de la aplicación ?", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                closing = true;
                Application.Exit();
            }
            else
            {
                closing = false;
            }
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
                PasarEstructuraJsonAAndroid();
                FormLogin f = new FormLogin();
                f.Show();
                closing = true;
                Hide();
            }
            else
            {
                closing = false;
            }
        }

        #endregion

        private void formPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(closed == 0 &&!closing && MessageBox.Show("Salir de apliación", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                PasarEstructuraJsonAAndroid();
                closed++;
                closing = true;
                Application.Exit();                
            }
            else if(!closing)
            {
                e.Cancel = true;
            }


        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadisticas fe = new FormEstadisticas();
            fe.ShowDialog();
        }

        private void labelNot_MouseHover(object sender, EventArgs e)
        {
            string notificiones;
            if(int.Parse(labelNot.Text) > 0)
            {
                if(int.Parse(labelNot.Text) == 1)
                {
                    notificiones = "notificacion";
                }
                else
                {
                    notificiones = "notificaciones";
                }

                toolTipNot.Show($"Tienes {labelNot.Text} {notificiones}", labelNot);
            }
        }

        private void actividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaActividades la = new ListaActividades();
            la.ShowDialog();
        }

        #region Pasar Estructura de Json c# a Android
        public static void EscribirJsonActividadesAJsonApp()
        {
            BindingList<Actividad> acts = new BindingList<Actividad>();
            BindingList<ActividadesUsuarios> totalActs = new BindingList<ActividadesUsuarios>();
            BindingList<Libreria> libs = new BindingList<Libreria>();

            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(ListaLibreria.filePath));
            libs = jArrayLibrerias.ToObject<BindingList<Libreria>>();

            string[] lista = Directory.GetFiles(FormEstadisticas.filePathAct);
            for (int i = 0; i < libs.Count(); i++)
            {
                JArray jArrayActividad = JArray.Parse(File.ReadAllText(libs[i].actividesRuta));
                acts = jArrayActividad.ToObject<BindingList<Actividad>>();
                foreach (Actividad act in acts)
                {                    

                    totalActs.Add(new ActividadesUsuarios(act, libs[i].Nombre));
                }

                try
                {
                    JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePathJsonAppActiv));
                    JToken.FromObject(totalActs).WriteTo(jw);
                    jw.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        public static void EscribirJsonLibreriasAJsonApp()
        {
            BindingList<Libreria> libs = new BindingList<Libreria>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(ListaLibreria.filePath));
            libs = jArrayLibrerias.ToObject<BindingList<Libreria>>();

            try
            {
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePathJsonAppLibrerias));
                JToken.FromObject(libs).WriteTo(jw);
                jw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public static void EscribirJsonUsuariosAJsonApp()
        {
            BindingList<Usuario> users = new BindingList<Usuario>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(FormUsers.filePath));
            users = jArrayLibrerias.ToObject<BindingList<Usuario>>();

            try
            {
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePathJsonAppUsuarios));
                JToken.FromObject(users).WriteTo(jw);
                jw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public static void PasarEstructuraJsonAAndroid()
        {
            EscribirJsonUsuariosAJsonApp();
            EscribirJsonLibreriasAJsonApp();
            EscribirJsonActividadesAJsonApp();
        }

        #endregion

    }
}