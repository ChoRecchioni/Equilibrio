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
        private static List<Categoria> listaCategoria = new List<Categoria>();

            public static string AddCategoria(string codigo, string nombre)
        {
            try
            {
                listaCategoria.Add(new Categoria()
                {
                    Codigo = int.Parse(codigo),
                    Nombre = nombre,

                });

                return "Categoria agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public static List<Categoria> FindAll()
        {
            return listaCategoria;
        }

        //Metodo para encontrar un objeto
        public static Categoria FindCategoria(string cod)
        {

            try
            {
                foreach (Categoria categoria in FindAll())
                {
                    if (categoria.Codigo == int.Parse(cod))
                    {
                        return categoria;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public static string EditCategoria(string codigo, string nombre)
        {

            try
            {
                Categoria categoria = FindCategoria(codigo);
                categoria.Nombre = nombre;

                return "Categoria Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }

        public static string RemoveCategoria(string cod)
        {
            listaCategoria.Remove(FindCategoria(cod));

            return "Categoria removida de la lista";
        }


        public static void CargarCategoria()
        {
            if (listaCategoria.Count < 1)
            {

                AddCategoria("1", "Almuerzos");
                AddCategoria("2", "pescado");
            }
        }

        //Metodo de auto increment
        public static int CategoriaAI()
        {
            int cod = listaCategoria[listaCategoria.Count - 1].Codigo + 1;

            return cod;
        }
    }
}