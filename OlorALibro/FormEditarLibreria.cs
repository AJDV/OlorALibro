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
    public partial class FormEditarLibreria : Form
    {
        
        BindingList<Libreria> LibList = new BindingList<Libreria>();
        int pos;
        Libreria l = new Libreria();
        public FormEditarLibreria(int pos, BindingList<Libreria> LibList)
        {
            InitializeComponent();
            this.LibList = LibList;
            this.pos = pos;
            l = LibList.ElementAt<Libreria>(pos);
        }

        private void EditarLibreria_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = l.nom;
            textBoxDir.Text = l.direccio;
            textBoxTelefon.Text = l.telefon.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(LibList.ElementAt<Libreria>(pos).ToString());
            LibList.ElementAt<Libreria>(pos).nom = textBoxNom.Text;
            LibList.ElementAt<Libreria>(pos).telefon = int.Parse(textBoxTelefon.Text);
            LibList.ElementAt<Libreria>(pos).direccio = textBoxDir.Text;
            this.Close();
            //Se recargan la cosas cuando clico dafuq?
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Seguro que desea eliminar la libreria?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(d == DialogResult.OK)
            {
                LibList.RemoveAt(pos);
                this.Close();
            }        
        }
    }
}
