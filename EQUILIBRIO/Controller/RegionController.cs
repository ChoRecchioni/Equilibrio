using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Controller
{
    public class RegionController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Region> findAll()
        {

            var reg = from r in entidades.Region
                      select r;

            return reg.ToList();
        }

        
        //Metodo para encontrar uno
        public static Region FindRegion(int codigo)
        {

            return entidades.Region.SingleOrDefault(r => r.codigo == codigo);
        }
                
        // Fin nuevo Controller

        //private static List<Region> listaRegion = new List<Region>();

        ////Metodo de registrar region

        //public static string AddRegion(string codigo, string nombre)
        //{
        //    try
        //    {
        //        listaRegion.Add(new Region()
        //        {

        //            Codigo = int.Parse(codigo),
        //            Nombre = nombre,
        //        });

        //        return "Region agregada.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todas las regiones
        //public static List<Region> FindAll()
        //{
        //    return listaRegion;
        //}

        ////Metodo para precargar regiones
        //public static void CargarRegion()
        //{

        //    if (listaRegion.Count < 1)
        //    {
        //        AddRegion("1", "Tarapacá");
        //        AddRegion("2", "Metropolitana de Santiago");
        //        AddRegion("3", "Los lagos");
        //        AddRegion("4", "Biobío");
        //        AddRegion("5", "Ñuble");
        //    }
        //}

        //public static Region FindRegion(string cod)
        //{

        //    try
        //    {
        //        foreach (Region region in FindAll())
        //        {
        //            if (region.Codigo == int.Parse(cod))
        //            {
        //                return region;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}
    }
}