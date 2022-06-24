using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class Art_CarroController
    {
        public static List<Articulo_Carro> listaArtCarro = new List<Articulo_Carro>();

        //Metodo para agregar Articulo-Carro
        public static string AddArtCarro(string codigo, string codArticulo, string cantidad, string precio)
        {
            Artículo articulo = ArticuloController.FindArticulo(codArticulo);
            try
            {
                listaArtCarro.Add(new Articulo_Carro()
                {
                    Codigo = int.Parse(codigo),
                    Artículo = articulo,
                    Cantidad = int.Parse(cantidad),
                });

                return "ArtCarro agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todos los Articulo-Carro
        public static List<Articulo_Carro> FindAll()
        {
            return listaArtCarro;
        }

        //Metodo para encontrar un objeto
        public static Articulo_Carro FindArtCarro(string cod)
        {
            try
            {
                foreach (Articulo_Carro ArtCarro in FindAll())
                {
                    if (ArtCarro.Codigo == int.Parse(cod))
                    {
                        return ArtCarro;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        //Metodo para editar Usuario
        public static string EditArtCarro(string codigo, int cantidad)
        {
            try
            {
                Articulo_Carro ArtCarro = FindArtCarro(codigo);
                ArtCarro.Cantidad = cantidad;

                return "Articulo-Carro Modificado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Metodo para eliminar Articulo-Carro
        public static string RemoveArtCarro(string cod)
        {
            listaArtCarro.Remove(FindArtCarro(cod));

            return "Usuario removido de la lista";
        }

        //Metodo de auto increment
        public static int ArtCarroAI()
        {

            int cod = listaArtCarro.Count > 0 ? listaArtCarro[listaArtCarro.Count - 1].Codigo + 1 : 1;

            return cod;
        }
    }
}