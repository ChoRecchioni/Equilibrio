using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class EstadoDeliveryController
    {
        private static List<EstadoDelivery> listaEstado = new List<EstadoDelivery>();

        //Metodo para agregar Estado
        public static string AddEstado(string codigo, string nombre)
        {
            try
            {
                listaEstado.Add(new EstadoDelivery()
                {
                    Codigo = int.Parse(codigo),
                    Nombre = nombre,


                });

                return "Estado agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todos los Estados
        public static List<EstadoDelivery> FindAll()
        {
            return listaEstado;
        }

        //Metodo para encontrar un objeto
        public static EstadoDelivery FindEstado(string cod)
        {

            try
            {
                foreach (EstadoDelivery estado in FindAll())
                {
                    if (estado.Codigo == int.Parse(cod))
                    {
                        return estado;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Estado

        public static string editEstado(string codigo, string nombre)
        {
            try
            {
                EstadoDelivery estado = FindEstado(codigo);
                estado.Nombre = nombre;

                return "Estado Modificado";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Estado

        public static string RemoveEstado(string cod)
        {
            listaEstado.Remove(FindEstado(cod));

            return "Estado removido de la lista";
        }

        //Metodo para precargar Estados
        public static void CargarEstado()
        {
            if (listaEstado.Count < 1)
            {
                AddEstado("1", "Pendiente");
                AddEstado("2", "Preparación");
                AddEstado("3", "En camino");
                AddEstado("4", "Finalizado");
            }
        }

        //Metodo de auto increment
        public static int EstadoAI()
        {
            int cod = listaEstado[listaEstado.Count - 1].Codigo + 1;

            return cod;
        }

    }
}