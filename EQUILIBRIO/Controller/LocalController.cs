using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class LocalController
    {
        private static List<Local> listaLocales = new List<Local>();

        //Metodo de registrar Local

        public static string AddLocal(string codigo, string nombre)
        {
            try
            {
                listaLocales.Add(new Local()
                {

                    Codigo = int.Parse(codigo),
                    Nombre = nombre,
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

            if (listaLocales.Count < 1)
            {
                AddLocal("1", "LA FLORIDA");
                AddLocal("2", "SANTIAGO CENTRO");
                AddLocal("3", "VIÑA DEL MAR");
                AddLocal("4", "MAIPU");
                AddLocal("5", "PROVIDENCIA");
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