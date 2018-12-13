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

namespace OlorALibro
{
    public partial class FormNotificaciones : Form
    {

        public static string filePath = @"..\..\Json\AdminUsers\users.json";       

        private BindingList<Usuario> users;

        private BindingList<Usuario> usuariosNotif = new BindingList<Usuario>();

        public int numUsuarios = 0;

        public int maxPuntos = 0;

        public FormNotificaciones(int num, int maxPuntos)
        {
            InitializeComponent();
            numUsuarios = num;
            this.maxPuntos = maxPuntos;
        }

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Json/AdminUsers/users.json"));
                    users = jArrayUsuarios.ToObject<BindingList<Usuario>>();
                    foreach (Usuario user in users) // hago lo mismo que en FormUsers,
                    {                               // debido que por problemas de accesos no se puede 
                        if (user.Puntos > maxPuntos)//pasar la lista por el constructor al ser una BindingList<Usuario>
                        {
                            usuariosNotif.Add(user);
                        }
                    }

                    dataGridViewNotif.DataSource = null;
                    dataGridViewNotif.DataSource = usuariosNotif;
                }

                    DimensionColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("No existe el Json");
            }

            label1.Text = $"Hay {numUsuarios} usuarios";
            label2.Text = $"con mas de {maxPuntos} puntos";
        }

        public void DimensionColumns()
        {
            DataGridViewColumnCollection col = dataGridViewNotif.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewNotif.Size.Width / 2) - 1;
            }
        }
    }
}
