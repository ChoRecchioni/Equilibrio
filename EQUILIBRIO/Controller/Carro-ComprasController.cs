using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class CarroComprasController
    {
        private static List<CarroCompras> listaCarro = new List<CarroCompras>();

        //Metodo para agregar Carro
        public static string AddCarro(string codigo, string CodUsuario, List<Articulo_Carro> ArticuloCarro)
        {
            Usuario usuario = UsuarioController.FindUser(CodUsuario);
            try
            {
                listaCarro.Add(new CarroCompras()
                {
                    Codigo = int.Parse(codigo),
                    user = usuario,
                    ArtCar = ArticuloCarro,

                });

                return "Articulo agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todos los carros
        public static List<CarroCompras> FindAll()
        {
            return listaCarro;
        }

        //Metodo para encontrar un objeto
        public static CarroCompras FindCarro(string cod)
        {

            try
            {
                foreach (CarroCompras carro in FindAll())
                {
                    if (carro.Codigo == int.Parse(cod))
                    {
                        return carro;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }


        // Metodo para eliminar Carro

        public static string RemoveCarro(string cod)
        {
            listaCarro.Remove(FindCarro(cod));

            return "Carro removido de la lista";
        }

        //Metodo de auto increment
        public static int CarroAI()
        {
            int cod = listaCarro[listaCarro.Count - 1].Codigo + 1;

            return cod;
        }
    }
}