using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

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

        //Metodo para agregar
        public static string AddRegion(string codigo, string nombre)
        {

            Region r = new Region()
            {
                codigo = int.Parse(codigo),
                nombre = nombre,
            };

            entidades.Region.Add(r);
            entidades.SaveChanges();

            return "Región agregada.";
        }


        //Metodo para encontrar uno
        public static Region FindRegion(int codigo)
        {

            return entidades.Region.SingleOrDefault(r => r.codigo == codigo);
        }


        //Metodo para editar
        public static string editRegion(string codigo, string nombre)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Region r = FindRegion(intCod);

            if (r != null)
            {
                r.nombre = nombre;
                entidades.SaveChanges();
                return "Region modificada";
            }
            else
            {
                return "No se pudo modificar la region";
            }
        }


        //Metodo para eliminar
        public static string removeRegion(int codigo)
        {

            Region r = FindRegion(codigo);
            entidades.Region.Remove(r);
            entidades.SaveChanges();
            return "Region eliminada";
        }

        // Fin nuevo Controller
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

        public static Region FindRegion(string cod)
        {

            try
            {
                foreach (Region region in FindAll())
                {
                    if (region.Codigo == int.Parse(cod))
                    {
                        return region;
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