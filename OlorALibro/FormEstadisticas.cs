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
    public partial class FormEstadisticas : Form
    {

        public const string filePathAct = "..\\..\\Json\\ListaDeLibrerías\\ActivDeLibrerias";

        public FormEstadisticas()
        {
            InitializeComponent();
        }

        public int JsonActividades()
        {
            BindingList<Actividad> acts = new BindingList<Actividad>();
            int totalActividades = 0;
            string[] lista = Directory.GetFiles(filePathAct);
            for(int i = 0; i < lista.Length; i++)
            {
                JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(lista[i]));
                acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                totalActividades += acts.Count;
            }
            return totalActividades;
        }

        public int JsonLibreria()
        {
            BindingList<Libreria> libreria = new BindingList<Libreria>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(FormLibrerias.filePath));
            libreria = jArrayLibrerias.ToObject<BindingList<Libreria>>();
            return libreria.Count;
        }

        public int JsonUsuariosApp()
        {
            BindingList<Usuario> users = new BindingList<Usuario>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(ListUsers.filePath));
            users = jArrayLibrerias.ToObject<BindingList<Usuario>>();
            return users.Count;
        }

        public int JsonUsuariosEscritorio()
        {
            BindingList<UsuarioAdm> usersDesk = new BindingList<UsuarioAdm>();
            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(UsuariosAdmins.filePath));
            usersDesk = jArrayLibrerias.ToObject<BindingList<UsuarioAdm>>();
            return usersDesk.Count;
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            labelLibrerias.Text = JsonLibreria().ToString();
            labelActividades.Text = JsonActividades().ToString();
            labelUsersApp.Text = JsonUsuariosApp().ToString();
            labelUsersDesk.Text = JsonUsuariosEscritorio().ToString();
        }
    }
}
