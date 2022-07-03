using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class CategoriaController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Categoria> findAll()
        {

            var cat = from c in entidades.Categoria
                      select c;

            return cat.ToList();
        }

        //Metodo para agregar
        public static string AddCategoria(string codigo, string nombre)
        {

            Categoria c = new Categoria()
            {
                codigo = int.Parse(codigo),
                nombre = nombre,    
            };

            entidades.Categoria.Add(c);
            entidades.SaveChanges();

            return "Categoria agregado.";
        }


        //Metodo para encontrar uno
        public static Categoria FindCategoria(int codigo)
        {

            return entidades.Categoria.SingleOrDefault(c => c.codigo == codigo);
        }


        //Metodo para editar
        public static string editCategoria(string codigo, string nombre)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Categoria c = FindCategoria(intCod);

            if (c != null)
            {
                c.nombre = nombre;
                entidades.SaveChanges();
                return "Categoria modificada";
            }
            else
            {
                return "No se pudo modificar la Categoria";
            }
        }


        //Metodo para eliminar
        public static string removeCategoria(int codigo)
        {

            Categoria c = FindCategoria(codigo);
            entidades.Categoria.Remove(c);
            entidades.SaveChanges();

            return "Categoria eliminada";
        }

        // Fin nuevo Controller

        //private static List<Categoria> listaCategoria = new List<Categoria>();

        //    public static string AddCategoria(string codigo, string nombre)
        //{
        //    try
        //    {
        //        listaCategoria.Add(new Categoria()
        //        {
        //            Codigo = int.Parse(codigo),
        //            Nombre = nombre,

        //        });

        //        return "Categoria agregado.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        //public static List<Categoria> FindAll()
        //{
        //    return listaCategoria;
        //}

        ////Metodo para encontrar un objeto
        //public static Categoria FindCategoria(string cod)
        //{

        //    try
        //    {
        //        foreach (Categoria categoria in FindAll())
        //        {
        //            if (categoria.Codigo == int.Parse(cod))
        //            {
        //                return categoria;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}

        //public static string EditCategoria(string codigo, string nombre)
        //{

        //    try
        //    {
        //        Categoria categoria = FindCategoria(codigo);
        //        categoria.Nombre = nombre;

        //        return "Categoria Modificada";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }


        //}

        //public static string RemoveCategoria(string cod)
        //{
        //    listaCategoria.Remove(FindCategoria(cod));

        //    return "Categoria removida de la lista";
        //}


        //public static void CargarCategoria()
        //{
        //    if (listaCategoria.Count < 1)
        //    {

        //        AddCategoria("1", "Almuerzos");
        //        AddCategoria("2", "pescado");
        //    }
        //}

        ////Metodo de auto increment
        //public static int CategoriaAI()
        //{
        //    int cod = listaCategoria[listaCategoria.Count - 1].Codigo + 1;

        //    return cod;
        //}
    }
}