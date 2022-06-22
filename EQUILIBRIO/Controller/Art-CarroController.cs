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
        public static string AddArtCarro(string codigo, string codArticulo, string codCarroCompras, int cantidad, string precio)
        {
            Artículo articulo = ArticuloController.FindArticulo(codArticulo);
            CarroCompras carro = CarroComprasController.FindCarro(codCarroCompras);
            try
            {
                listaArtCarro.Add(new Articulo_Carro()
                {
                    Codigo = int.Parse(codigo),
                    Artículo = articulo,
                    Carro = carro,
                    Cantidad = cantidad,
                    Precio = precio,


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
        public static string EditArtCarro(string codigo, int cantidad, string precio)
        {
            try
            {
                Articulo_Carro ArtCarro = FindArtCarro(codigo);
                ArtCarro.Cantidad = cantidad;
                ArtCarro.Precio = precio;

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
            int cod = listaArtCarro[listaArtCarro.Count - 1].Codigo + 1;

            return cod;
        }
    }
}