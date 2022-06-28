using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class DeliveryController
    {
        private static List<Delivery> listaDelivery = new List<Delivery>();

        //Metodo para agregar Delivery
        public static string AddDelivery(string codigo, string codOrden, string codEstado, string numPed)
        {
            OrdenCompra orden = OrdenCompraController.FindOrden(codOrden);
            if (EstadoDeliveryController.FindEstado(codEstado) == null)
            {
                EstadoDeliveryController.CargarEstado();
            }
            EstadoDelivery estado = EstadoDeliveryController.FindEstado(codEstado);
            try
            {
                listaDelivery.Add(new Delivery()
                {
                    Codigo = int.Parse(codigo),
                    Orden = orden,
                    Estado = estado,
                    NumPedido = int.Parse(numPed),

                });

                return "Delivery agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todos los Delivery
        public static List<Delivery> FindAll()
        {
            return listaDelivery;
        }

        //Metodo para encontrar un objeto
        public static Delivery FindDelivery(string cod)
        {

            try
            {
                foreach (Delivery delivery in FindAll())
                {
                    if (delivery.Codigo == int.Parse(cod))
                    {
                        return delivery;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Delivery

        public static string EditDelivery(string codigo, string codOrden, string codEstado, string numPed)
        {
            OrdenCompra orden = OrdenCompraController.FindOrden(codOrden);
            EstadoDelivery estado = EstadoDeliveryController.FindEstado(codEstado);
            try
            {
                Delivery delivery = FindDelivery(codigo);
                delivery.Orden = orden;
                delivery.Estado = estado;
                delivery.NumPedido = int.Parse(numPed);

                return "Delivery Modificado";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Delivery

        public static string RemoveDelivery(string cod)
        {
            listaDelivery.Remove(FindDelivery(cod));

            return "Delivery removido de la lista";
        }

        //Metodo para precargar Delivery
        public static void CargarDelivery()
        {
            OrdenCompraController.CargarOrden();
            EstadoDeliveryController.CargarEstado();

            if (listaDelivery.Count < 1)
            {
                AddDelivery("1", "1", "1", "1");
            }
        }

        //Metodo de auto increment
        public static int DeliveryAI()
        {
            int cod = listaDelivery.Count > 0 ? listaDelivery[listaDelivery.Count - 1].Codigo + 1 : 1;

            return cod;
        }

        public static int numPedidoAI()
        {
            int numP = listaDelivery.Count > 0 ? listaDelivery[listaDelivery.Count - 1].Codigo + 12345 : 1;

            return numP;
        }
    }
}