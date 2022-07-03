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

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<EstadoDelivery> findAll()
        {

            var est = from e in entidades.EstadoDelivery
                      select e;

            return est.ToList();
        }

        //Metodo para agregar
        public static string AddEstadoDeli(string codigo, string nombre)
        {

            EstadoDelivery e = new EstadoDelivery()
            {
                codigo = int.Parse(codigo),
                nombre = nombre,
            };

            entidades.EstadoDelivery.Add(e);
            entidades.SaveChanges();

            return "Estado Delivery agregado.";
        }


        //Metodo para encontrar uno
        public static EstadoDelivery FindEstadoDeli(int codigo)
        {

            return entidades.EstadoDelivery.SingleOrDefault(e => e.codigo == codigo);
        }


        //Metodo para editar
        public static string editEstadoDeli(string codigo, string nombre)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            EstadoDelivery e = FindEstadoDeli(intCod);

            if (e != null)
            {
                e.nombre = nombre;
                entidades.SaveChanges();
                return "Estado modificado";
            }
            else
            {
                return "No se pudo modificar el estado";
            }
        }


        //Metodo para eliminar
        public static string removeEstadoDeli(int codigo)
        {

            EstadoDelivery e = FindEstadoDeli(codigo);
            entidades.EstadoDelivery.Remove(e);
            entidades.SaveChanges();

            return "Estado eliminado";
        }

        // Fin nuevo Controller

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