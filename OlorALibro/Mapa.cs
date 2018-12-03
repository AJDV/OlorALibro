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
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("https://www.google.es/maps/place/CEP/@41.3892684,2.1706431,17z/data=!3m1!4b1!4m5!3m4!1s0x12a4a2f0468c1cd1:0xa50af3e9cffaa23a!8m2!3d41.3892644!4d2.1728318"));
        }
    }
}
