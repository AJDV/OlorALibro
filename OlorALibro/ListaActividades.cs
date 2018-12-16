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
    public partial class ListaActividades : Form
    {
        public ListaActividades()
        {
            InitializeComponent();
        }

        private void ListaActividades_Load(object sender, EventArgs e)
        {
            BindingList<Actividad> acts = new BindingList<Actividad>();
            BindingList<Actividad> totalActs = new BindingList<Actividad>();
            string[] lista = Directory.GetFiles(FormEstadisticas.filePathAct);
            for (int i = 0; i < lista.Length; i++)
            {
                JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(lista[i]));
                acts = jArrayLibrerias.ToObject<BindingList<Actividad>>(); 
                foreach(Actividad act in acts)
                {
                    totalActs.Add(act);
                }
            }

            dataGridViewListaActiv.DataSource = null;
            dataGridViewListaActiv.DataSource = totalActs;
        }

        public void DimensionColumns()
        {
            DataGridViewColumnCollection col = dataGridViewListaActiv.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewListaActiv.Size.Width / 4) - 1;
            }
        }
    }
}
