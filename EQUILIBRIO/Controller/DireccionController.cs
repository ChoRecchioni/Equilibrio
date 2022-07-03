using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class DireccionController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Direccion> findAll()
        {

            var dir = from d in entidades.Direccion
                      select d;

            return dir.ToList();
        }

        //Metodo para agregar
        public static string AddDireccion(string codigo, string alias, string calleYnum, string depto, string codComuna)
        {

            Direccion d = new Direccion()
            {
                codigo = int.Parse(codigo),
                alias = alias,
                calleYnum = calleYnum,
                depto = depto,
                fk_comuna = int.Parse(codComuna),
            };

            entidades.Direccion.Add(d);
            entidades.SaveChanges();

            return "Direccion agregada.";
        }


        //Metodo para encontrar uno
        public static Direccion FindDireccion(int codigo)
        {

            return entidades.Direccion.SingleOrDefault(d => d.codigo == codigo);
        }


        //Metodo para editar
        public static string editDireccion(string codigo, string alias, string calleYnum, string depto, string codComuna)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Direccion d = FindDireccion(intCod);

            if (d != null)
            {
                d.alias = alias;
                d.calleYnum = calleYnum;
                d.depto = depto;
                d.fk_comuna = int.Parse(codComuna);
                entidades.SaveChanges();
                return "Dirección modificada";
            }
            else
            {
                return "No se pudo modificar la Direccion";
            }
        }


        //Metodo para eliminar
        public static string removeDireccion(int codigo)
        {

            Direccion d = FindDireccion(codigo);
            entidades.Direccion.Remove(d);
            entidades.SaveChanges();

            return "Dirección eliminada";
        }

        // Fin nuevo Controller

        //private static List<Direccion> listaDireccion = new List<Direccion>();

        ////Metodo para agregar Direccion
        //public static string AddDireccion(string codigo, string alias, string calleYnum, string depto, string codcomuna, string codregion)
        //{
        //    Comuna comuna = ComunaController.FindComuna(codcomuna);
        //    Region region = RegionController.FindRegion(codregion);
        //    try
        //    {
        //        listaDireccion.Add(new Direccion()
        //        {

        //            Codigo = int.Parse(codigo),
        //            Alias = alias,
        //            CalleYnum = calleYnum,
        //            Depto = depto,
        //            Comuna = comuna,
        //            Region = region,
        //        });

        //        return "Dirección agregada.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todas las Direcciones
        //public static List<Direccion> FindAll()
        //{
        //    return listaDireccion;
        //}

        ////Metodo para encontrar un objeto
        //public static Direccion FindDireccion(string cod)
        //{

        //    try
        //    {
        //        foreach (Direccion direccion in FindAll())
        //        {
        //            if (direccion.Codigo == int.Parse(cod))
        //            {
        //                return direccion;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}

        ////Metodo para editar direccion

        //public static string EditDireccion(string codigo, string alias, string calleYnum, string depto, string codcomuna, string codregion)
        //{

        //    try
        //    {
        //        Comuna comuna = ComunaController.FindComuna(codcomuna);
        //        Region region = RegionController.FindRegion(codregion);
        //        Direccion direccion = FindDireccion(codigo);
        //        direccion.Alias = alias;
        //        direccion.CalleYnum = calleYnum;
        //        direccion.Depto = depto;
        //        direccion.Comuna = comuna;
        //        direccion.Region = region;

        //        return "";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }


        //}
        //// Metodo para eliminar Dirección

        //public static string RemoveDireccion(string cod)
        //{


        //    listaDireccion.Remove(FindDireccion(cod));

        //    return "Dirección removida de la lista";
        //}

        //public static void CargarDirección()
        //{
        //    ComunaController.CargarComuna();
        //    RegionController.CargarRegion();

        //    if (listaDireccion.Count < 1)
        //    {
        //        AddDireccion("1", "casa", "casa 1", "1", "1", "1");

        //    }
        //}

        //public static int DirAI()
        //{
        //    int cod = listaDireccion[listaDireccion.Count - 1].Codigo + 1;

        //    return cod;
        //}


    }
}