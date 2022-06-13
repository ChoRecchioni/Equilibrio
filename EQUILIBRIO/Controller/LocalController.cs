using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class LocalController
    {
        private static List<Local> listaLocales = new List<Local>();

        //Metodo de registrar Local

        public static string AddLocal(string codigo, string nombre, string codDir, string telefono)
        {
           Direccion direccion = DireccionController.FindDireccion(codDir);
            try
            {
                listaLocales.Add(new Local()
                {
                    
                    Codigo = int.Parse(codigo),
                    Nombre = nombre,
                    Direccion = direccion,
                    Telefono = telefono
                });

                return "Local agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las regiones
        public static List<Local> FindAll()
        {
            return listaLocales;
        }

        //Metodo para precargar regiones
        public static void CargarLocales()
        {
            DireccionController.CargarDirección();

            if (listaLocales.Count < 1)
            {
                AddLocal("1", "LA FLORIDA","2", "101");
                AddLocal("2", "SANTIAGO CENTRO","3", "102");
                AddLocal("3", "VIÑA DEL MAR","4", "103");
                AddLocal("4", "MAIPU", "5", "104");
                AddLocal("5", "PROVIDENCIA", "6", "105");
            }
        }

        public static Local FindLocal(string cod)
        {

            try
            {
                foreach (Local local in FindAll())
                {
                    if (local.Codigo == int.Parse(cod))
                    {
                        return local;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}