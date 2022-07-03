using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Controller
{
    public class LocalController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Sede> findAll()
        {

            var sed = from s in entidades.Sede
                      select s;

            return sed.ToList();
        }

        //Metodo para agregar
        public static string AddSede(string nombre, string telefono, string codDir)
        {

            Sede s = new Sede()
            {
               
                nombre = nombre,
                telefono = telefono,
                fk_direccion = int.Parse(codDir),

            };

            entidades.Sede.Add(s);
            entidades.SaveChanges();

            return "Sede agregado.";
        }


        //Metodo para encontrar uno
        public static Sede FindSede(int codigo)
        {

            return entidades.Sede.SingleOrDefault(s => s.codigo == codigo);
        }


        //Metodo para editar
        public static string editSede(string codigo, string nombre, string telefono, string codDir)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Sede s = FindSede(intCod);

            if (s != null)
            {
                s.nombre = nombre;
                s.telefono = telefono;
                s.fk_direccion = int.Parse(codDir);
                entidades.SaveChanges();
                return "Sede modificada";
            }
            else
            {
                return "No se pudo modificar la Sede";
            }
        }


        //Metodo para eliminar
        public static string removeSede(int codigo)
        {

            Sede s = FindSede(codigo);
            entidades.Sede.Remove(s);
            entidades.SaveChanges();

            return "Sede eliminada";
        }

        // Fin nuevo Controller

        //private static List<Local> listaLocales = new List<Local>();

        ////Metodo de registrar Local

        //public static string AddLocal(string codigo, string nombre)
        //{
        //    try
        //    {
        //        listaLocales.Add(new Local()
        //        {

        //            Codigo = int.Parse(codigo),
        //            Nombre = nombre,
        //        });

        //        return "Local agregado.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todas las regiones
        //public static List<Local> FindAll()
        //{
        //    return listaLocales;
        //}

        ////Metodo para precargar regiones
        //public static void CargarLocales()
        //{

        //    if (listaLocales.Count < 1)
        //    {
        //        AddLocal("1", "LA FLORIDA");
        //        AddLocal("2", "SANTIAGO CENTRO");
        //        AddLocal("3", "VIÑA DEL MAR");
        //        AddLocal("4", "MAIPU");
        //        AddLocal("5", "PROVIDENCIA");
        //    }
        //}

        //public static Local FindLocal(string cod)
        //{

        //    try
        //    {
        //        foreach (Local local in FindAll())
        //        {
        //            if (local.Codigo == int.Parse(cod))
        //            {
        //                return local;
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