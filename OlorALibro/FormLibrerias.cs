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
    public partial class FormLibrerias : Form
    {
        BindingList<Libreria> libs = new BindingList<Libreria>();
        public string filePath = @"..\..\Resources\librerias.json";
        /* Demomento esto la hace siempre new al abrir, en un
        futuro se deberia comprobar si existe el JSON para 
        cojer los datos de alli con if-else statement*/
        public FormLibrerias()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FormAñadirLibreria f = new FormAñadirLibreria(libs);
            f.ShowDialog();
        }

        private void FormLibrerias_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleTurquoise;

            if (File.Exists(filePath))
            {
                JArray jArrayLibs = JArray.Parse(File.ReadAllText(filePath));
                libs = jArrayLibs.ToObject<BindingList<Libreria>>();
            }

            else libs = new BindingList<Libreria>();

            dataGridViewLibrerias.DataSource = libs;
        }


        private void dataGridViewLibrerias_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            int i = 0, c = 0;
            Libreria l = new Libreria();
            //Busca los datos de la cell clicada
            do
            {
                if (c > 2)
                {
                    c = 0;
                    i++;
                }

                if (dataGridViewLibrerias.Rows[i].Cells[c].Selected)
                {
                    encontrado = true;
                    l.nom = dataGridViewLibrerias.Rows[i].Cells[0].Value.ToString();
                    l.direccio = dataGridViewLibrerias.Rows[i].Cells[2].Value.ToString();
                    l.telefon = Int32.Parse(dataGridViewLibrerias.Rows[i].Cells[1].Value.ToString());
                }
                else c++;
                    
                
            }
            while (encontrado = false && i<= dataGridViewLibrerias.RowCount && c <= dataGridViewLibrerias.ColumnCount);
            int p = 0;
            //Busca esa libreria en la List de librerias
            foreach(Libreria item in libs)//Aqui salta error cuando elimino libreria... Hablar con grupo/francisco
            {
                if (item.nom == l.nom && item.direccio == item.direccio)
                {
                    FormEditarLibreria a = new FormEditarLibreria(p, libs);
                    a.ShowDialog();
                }
                else p++;
            }

            dataGridViewLibrerias.Update();
        }
        
        
    }
}
