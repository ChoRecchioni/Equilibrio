using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class RegionController
    {
        private static List<Region> listaRegion = new List<Region>();

        //Metodo de registrar region

        public static string AddRegion(string codigo, string nombre)
        {
            try
            {
                listaRegion.Add(new Region()
                {

                    Codigo = int.Parse(codigo),
                    Nombre = nombre,
                });

                return "Region agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las regiones
        public static List<Region> FindAll()
        {
            return listaRegion;
        }

        //Metodo para precargar regiones
        public static void CargarRegion()
        {

            if (listaRegion.Count < 1)
            {
                AddRegion("1", "Tarapacá");
                AddRegion("2", "Metropolitana de Santiago");
                AddRegion("3", "Los lagos");
                AddRegion("4", "Biobío");
                AddRegion("5", "Ñuble");
            }
        }
    }
}