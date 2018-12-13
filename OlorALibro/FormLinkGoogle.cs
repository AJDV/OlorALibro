using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    public partial class FormLinkGoogle : Form
    {
        private const string linkStart = "https://";

        public string linkWeb { get; set; }
        public Libreria libreria = new Libreria();

        public FormLinkGoogle()
        {
            InitializeComponent();
        }

        public FormLinkGoogle(string link)
        {
            libreria.linkWeb = link;
        }

        private void buttonSave_MouseHover(object sender, EventArgs e)
        {
            toolTipSave.Show("GUARDAR Link", buttonSave);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxLink.Text == "")
            {
                MessageBox.Show("No hay ningun dato rellenado");
            }
            else if (!textBoxLink.Text.StartsWith(linkStart))
            {
                MessageBox.Show($"el Link no es valido, debe contener '{linkStart}'");
            }
            else
            {
                linkWeb = textBoxLink.Text;
                MessageBox.Show("guardado correctamente");
                Hide();
            }
        }

        private void FormLinkGoogle_Load(object sender, EventArgs e)
        {
            textBoxLink.Text = "";
        }
    }
}
