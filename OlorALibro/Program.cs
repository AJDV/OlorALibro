using OlorALibro.CRUD_users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());

            //using (FormLogin login = new FormLogin()) //if data ok, form will close it self!
            //{
            //    if (login.ShowDialog() == DialogResult.OK)
            //        Application.Run(new formPanel("xd"));
            //}
        }
    }
}
