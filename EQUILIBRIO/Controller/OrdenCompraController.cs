using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;
namespace equilibrio.Controller
{
    public class OrdenCompraController
    {
        private static List<OrdenCompra> listaOrden = new List<OrdenCompra>();

        //Metodo para agregar Articulo
        public static string AddOrden(string codigo, string codCarro, string total, string codLocal)
        {
            CarroCompras carro = CarroComprasController.FindCarro(codCarro);
            Local local = LocalController.FindLocal(codLocal);
            try
            {
                listaOrden.Add(new OrdenCompra()
                {
                    Codigo = int.Parse(codigo),
                    Carro = carro,
                    Total = total,
                    Local = local

                });

                return "Orden agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las Ordenes
        public static List<OrdenCompra> FindAll()
        {
            return listaOrden;
        }

        //Metodo para encontrar un objeto
        public static OrdenCompra FindOrden(string cod)
        {

            try
            {
                foreach (OrdenCompra orden in FindAll())
                {
                    if (orden.Codigo == int.Parse(cod))
                    {
                        return orden;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Orden de compra

        public static string EditOrden(string codigo, string codCarro, string total, string codLocal)
        {
            CarroCompras carro = CarroComprasController.FindCarro(codCarro);
            Local local = LocalController.FindLocal(codLocal);
            try
            {
                OrdenCompra orden = FindOrden(codigo);
                orden.Carro = carro;
                orden.Total = total;
                orden.Local = local;

                return "Orden Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Orden

        public static string RemoveOrden(string cod)
        {
            listaOrden.Remove(FindOrden(cod));

            return "Orden removida de la lista";
        }

        //Metodo para precargar Articulo
        public static void CargarOrden()
        {
            CarroComprasController.CargarCarro();
            LocalController.CargarLocales();

            if (listaOrden.Count < 1)
            {
                AddOrden("1", "1", "1.000", "1");

            }
        }

        //Metodo de auto increment
        public static int OrdenAI()
        {
            int cod = listaOrden[listaOrden.Count - 1].Codigo + 1;

            return cod;
        }

    }
}