using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Controller
{
    public class CarroComprasController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<CarroCompras> findAll()
        {

            var car = from c in entidades.CarroCompras
                      select c;

            return car.ToList();
        }

        //Metodo para agregar
        public static CarroCompras AddCarro(string codUser)
        {

            CarroCompras c = new CarroCompras()
            {
                
                fk_usuario = int.Parse(codUser),
            };

            entidades.CarroCompras.Add(c);
            entidades.SaveChanges();

            return c;
        }


        //Metodo para encontrar uno
        public static CarroCompras FindCarroCompras(int codigo)
        {

            return entidades.CarroCompras.SingleOrDefault(c => c.codigo == codigo);
        }


        //Metodo para editar
        public static string editCarro(string codigo, string codUser)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            CarroCompras c = FindCarroCompras(intCod);

            if (c != null)
            {
                c.fk_usuario = int.Parse(codUser);
                entidades.SaveChanges();
                return "Carro modificado";
            }
            else
            {
                return "No se pudo modificar el carro";
            }
        }


        //Metodo para eliminar
        public static string removeCarro(int codigo)
        {

            CarroCompras c = FindCarroCompras(codigo);
            entidades.CarroCompras.Remove(c);
            entidades.SaveChanges();

            return "Carro eliminado";
        }

        // Fin nuevo Controller

        //private static List<CarroCompras> listaCarro = new List<CarroCompras>();

        ////Metodo para agregar Carro
        //public static string AddCarro(string codigo, string CodUsuario, List<Articulo_Carro> ArticuloCarro)
        //{
        //    Usuario usuario = UsuarioController.FindUsuario(CodUsuario);
        //    try
        //    {
        //        listaCarro.Add(new CarroCompras()
        //        {
        //            Codigo = int.Parse(codigo),
        //            user = usuario,
        //            ArtCar = ArticuloCarro,

        //        });

        //        return "Articulo agregado.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todos los carros
        //public static List<CarroCompras> FindAll()
        //{
        //    return listaCarro;
        //}

        ////Metodo para encontrar un objeto
        //public static CarroCompras FindCarro(string cod)
        //{

        //    try
        //    {
        //        foreach (CarroCompras carro in FindAll())
        //        {
        //            if (carro.Codigo == int.Parse(cod))
        //            {
        //                return carro;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}


        //// Metodo para eliminar Carro

        //public static string RemoveCarro(string cod)
        //{
        //    listaCarro.Remove(FindCarro(cod));

        //    return "Carro removido de la lista";
        //}


        //public static void CargarCarro()
        //{
        //    Art_CarroController.CargarArticuloCarro();
        //    UsuarioController.CargarUsuario();
        //    List<Articulo_Carro> listaArticulos = new List<Articulo_Carro>();

        //    if (listaCarro.Count < 1)
        //    {
        //        listaArticulos.Add(Art_CarroController.FindArtCarro("1"));
        //        listaArticulos.Add(Art_CarroController.FindArtCarro("2"));
        //        AddCarro("1", "2", listaArticulos);
        //    }
        //}

        ////Metodo de auto increment
        //public static int CarroAI()
        //{
        //    int cod = listaCarro.Count > 0 ? listaCarro[listaCarro.Count - 1].Codigo + 1 : 1;

        //    return cod;
        //}
    }
}