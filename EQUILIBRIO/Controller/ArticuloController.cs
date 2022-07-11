using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Controller
{
    public class ArticuloController
    {
        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Artículo> findAll()
        {

            var art = from a in entidades.Artículo
                      select a;

            return art.ToList();
        }

        //Metodo para agregar
        public static string AddArticulo(string nombre, string precio, string comentario, string codCat)
        {

            Artículo ar = new Artículo()
            {
                
                nombre = nombre,
                precio = precio,
                comentario = comentario,
                fk_categoria = int.Parse(codCat),
            };

            entidades.Artículo.Add(ar);
            entidades.SaveChanges();

            return " ";
        }


        //Metodo para encontrar uno
        public static Artículo FindArticulo(int codigo)
        {

            return entidades.Artículo.SingleOrDefault(ar => ar.codigo == codigo);
        }


        //Metodo para editar
        public static string editArticulo(string codigo, string nombre, string precio, string comentario, string categoria)

        {
            int intCod = int.Parse(codigo);
            Artículo ar = FindArticulo(intCod);
            Categoria ca = CategoriaController.FindCategoria(int.Parse(categoria));
            if (ar != null)
            {
                ar.nombre = nombre;
                ar.precio = precio;
                ar.comentario = comentario;
                ar.fk_categoria = ca.codigo;
                entidades.SaveChanges();
                return "Artículo modificado";
            }
            else
            {
                return "No se pudo modificar el artículo";
            }
        }


        //Metodo para eliminar
        public static string removeArticulo(int codigo)
        {
            Artículo ar = FindArticulo(codigo);
            entidades.Artículo.Remove(ar);
            entidades.SaveChanges();
            return "Artículo eliminado";
        }

        //private static List<Artículo> listaArticulo = new List<Artículo>();

        ////Metodo para agregar Articulo
        //public static string AddAarticulo(string codigo, string nombre, string precio, string comentario, string Codcategoria)
        //{
        //    Categoria cat = CategoriaController.FindCategoria(Codcategoria);
        //    try
        //    {
        //        listaArticulo.Add(new Artículo()
        //        {
        //            Codigo = int.Parse(codigo),
        //            Nombre = nombre,
        //            Precio = precio,
        //            Comentario = comentario,
        //            Categoria = cat,

        //        });

        //        return "Articulo agregado.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todos los Articulo
        //public static List<Artículo> FindAll()
        //{
        //    return listaArticulo;
        //}

        ////Metodo para encontrar un objeto
        //public static Artículo FindArticulo(string cod)
        //{

        //    try
        //    {
        //        foreach (Artículo artículo in FindAll())
        //        {
        //            if (artículo.Codigo == int.Parse(cod))
        //            {
        //                return artículo;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}

        ////Metodo para editar Articulo

        //public static string EditArticulo(string codigo, string nombre, string precio, string comentario, string Codcategoria)
        //{
        //    Categoria cat = CategoriaController.FindCategoria(Codcategoria);
        //    try
        //    {
        //        Artículo artículo = FindArticulo(codigo);
        //        artículo.Nombre = nombre;
        //        artículo.Precio = precio;
        //        artículo.Comentario = comentario;
        //        artículo.Categoria = cat;

        //        return "Articulo Modificada";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }


        //}
        //// Metodo para eliminar Articulo

        //public static string RemoveArticulo(string cod)
        //{
        //    listaArticulo.Remove(FindArticulo(cod));

        //    return "Articulo removido de la lista";
        //}

        ////Metodo para precargar Articulo
        //public static void CargarArticulo()
        //{
        //    if (listaArticulo.Count < 1)
        //    {

        //        AddAarticulo("1", "papas fritas", "10.000", "Ricas papas fritas de huerto sabor natural 100% real no fake", "1");
        //        AddAarticulo("2", "tomates", "10.000", "Huerto sabor natural 100% real no fake", "1");
        //        AddAarticulo("3", "pescado", "15.000", "Pescado de tierra", "2");
        //        AddAarticulo("4", "pescado diferente", "15.000", "Pollo de tierra", "2");
        //        AddAarticulo("5", "pescado", "15.000", "Pescado de tierra", "2");
        //        AddAarticulo("6", "pescado diferente", "15.000", "Pollo de tierra", "2");
        //    }
        //}

        ////Metodo de auto increment
        //public static int ArticuloAI()
        //{
        //    int cod = listaArticulo[listaArticulo.Count - 1].Codigo + 1;

        //    return cod;
        //}
    }
}