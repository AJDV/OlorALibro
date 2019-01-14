using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlorALibro
{
    public static class Json
    {
        #region LeerJson

        public static void leerJsonActividad(string filePath)
        {
            BindingList<Actividad> acts = new BindingList<Actividad>();
            try
            {
                if (File.Exists(filePath))
                {
                    JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(filePath));
                    acts = jArrayLibrerias.ToObject<BindingList<Actividad>>();
                }
                else
                {
                    EscribirJsonActividades(filePath, acts);
                }
            }
            catch (Exception)
            {
                Excepciones.ExcepcionError();
            }
        }

        //Devuelve una lista de nombres de Librerías
        public static List<string> LeerJsonNombreLibreria()
        {
            List<string> nombreDeLibrerias = new List<string>();
            BindingList<Libreria> libs = new BindingList<Libreria>();

            JArray jArrayLibrerias = JArray.Parse(File.ReadAllText(Constantes.FILEPATHLIBRERIAS));
            libs = jArrayLibrerias.ToObject<BindingList<Libreria>>();

            foreach (Libreria libreria in libs)
            {
                nombreDeLibrerias.Add(libreria.Nombre);
            }
            return nombreDeLibrerias;
        }

        #endregion

        public static void EscribirJsonActividades(string filePath, BindingList<Actividad> acts)
        {
            try
            {
                JsonTextWriter jw = new JsonTextWriter(File.CreateText(filePath));
                JToken.FromObject(acts).WriteTo(jw);
                jw.Close();
            }
            catch (Exception)
            {
                Excepciones.ExcepcionError();
            }
        }
    }
}
