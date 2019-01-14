using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    public class Excepciones
    {
        public static void ExcepcionError()
        {
            MessageBox.Show("Error");
        }

        public static void ExcepcionSinCambios()
        {
            MessageBox.Show("No hay cambios efectuados!");
        }

        public static void ExcepcionNombreExistente()
        {
            MessageBox.Show("Este nombre ya existe");
        }

        public static void Excepcion_LibreriaActualizada()
        {
            MessageBox.Show("Libreria Actualizada");
        }
    }
}
