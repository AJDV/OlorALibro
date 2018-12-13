using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OlorALibro
{
    public partial class FormLocalizacion : Form
    {
        public static string filePath = @"..\..\Json\ListaDeLibrerías\Librerias.json";

        public BindingList<Libreria> librerias;

        public FormLocalizacion()
        {
            InitializeComponent();
        }

        private void FormLocalizacion_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
                    librerias = jArrayLibrerias.ToObject<BindingList<Libreria>>();

                    dataGridViewLista.DataSource = null;
                    dataGridViewLista.DataSource = librerias;
                    dataGridViewLista.Columns["Coordenadas"].Visible = false;
                    dataGridViewLista.Columns["Correo"].Visible = false;
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
            DataGridViewColumnCollection col = dataGridViewLista.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewLista.Size.Width / 2) - 1;
            }

            DataGridViewRowCollection rows = dataGridViewLista.Rows;
            foreach (DataGridViewRow row in rows)
            {
                row.Height = 40;
            }

        }

        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            label1.Visible = false;
            label2.Visible = false;

            Libreria lib = (Libreria)dataGridViewLista.CurrentRow.DataBoundItem;
            StringBuilder direccion = new StringBuilder("http://maps.google.com/maps?q=");
            direccion.Append(lib.Direccion);
            webBrowser1.Visible = true;
            webBrowser1.Navigate(direccion.ToString());

            
        }
    }
}
