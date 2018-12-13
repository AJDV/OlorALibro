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
    public partial class ListaLibreria : Form
    {
        public static string filePath = @"..\..\Json\ListaDeLibrerías\Librerias.json";

        public BindingList<Libreria> librerias;

        public ListaLibreria()
        {
            InitializeComponent();
        }

        private void ListaLibreria_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
                    librerias = jArrayLibrerias.ToObject<BindingList<Libreria>>();

                    dataGridViewListaLib.DataSource = null;
                    dataGridViewListaLib.DataSource = librerias;
                    dataGridViewListaLib.Columns["Coordenadas"].Visible=false;
                    dataGridViewListaLib.Columns["Correo"].Visible=false;
                    DimensionColumns();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existe el Json");
            }            
        }

        public void DimensionColumns()
        {
            DataGridViewColumnCollection col = dataGridViewListaLib.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewListaLib.Size.Width / 3) - 1;
            }
        }
    }
}
