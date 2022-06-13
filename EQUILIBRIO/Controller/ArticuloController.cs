using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class ArticuloController
    {
        private static List<Artículo> listaArticulo = new List<Artículo>();

        //Metodo para agregar Articulo
        public static string AddAarticulo(string codigo, string nombre, string precio, string comentario)
        {
            try
            {
                listaArticulo.Add(new Artículo()
                {
                    Codigo = int.Parse(codigo),
                    Nombre = nombre,
                    Precio = precio,
                    Comentario = comentario,

                });

                return "Articulo agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todos los Articulo
        public static List<Artículo> FindAll()
        {
            return listaArticulo;
        }

        //Metodo para encontrar un objeto
        public static Artículo FindArticulo(string cod)
        {

            try
            {
                foreach (Artículo artículo in FindAll())
                {
                    if (artículo.Codigo == int.Parse(cod))
                    {
                        return artículo;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Articulo

        public static string EditReseña(string codigo, string nombre, string precio, string comentario)
        {

            try
            {
                Artículo artículo = FindArticulo(codigo);
                artículo.Nombre = nombre;
                artículo.Precio = precio;
                artículo.Comentario = comentario;

                return "Articulo Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Articulo

        public static string RemoveArticulo(string cod)
        {
            listaArticulo.Remove(FindArticulo(cod));

            return "Articulo removido de la lista";
        }

        //Metodo para precargar Articulo
        public static void CargarArticulo()
        {
            if (listaArticulo.Count < 1)
            {

                AddAarticulo("1", "papas fritas", "10.000", "Ricas papas fritas de huerto sabor natural 100% real no fake");
                AddAarticulo("2", "pescado", "15.000", "Pescado de tierra");
            }
        }

        //Metodo de auto increment
        public static int ArticuloAI()
        {
            int cod = listaArticulo[listaArticulo.Count - 1].Codigo + 1;

            return cod;
        }
    }
}