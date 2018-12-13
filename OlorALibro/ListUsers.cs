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
    public partial class ListUsers : Form
    {
        public static string filePath = @"..\..\Json\AdminUsers\users.json";

        private BindingList<Usuario> users;

        public ListUsers()
        {
            InitializeComponent();
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayUsers = JArray.Parse(File.ReadAllText(filePath));
                    users = jArrayUsers.ToObject<BindingList<Usuario>>();

                    dataGridViewUsers.DataSource = null;
                    dataGridViewUsers.DataSource = users;
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
            DataGridViewColumnCollection col = dataGridViewUsers.Columns;
            foreach (DataGridViewColumn co in col)
            {
                co.Width = (dataGridViewUsers.Size.Width / 3) - 1;
            }
        }
    }
}
