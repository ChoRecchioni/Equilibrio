using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class HoraController
    {

        private static List<Horas> listaHora = new List<Horas>();

        //Metodo para agregar hora
        public static string AddHora(string codigo, string hora)
        {
            try
            {
                listaHora.Add(new Horas()
                {

                    Codigo = int.Parse(codigo),
                    Hora = hora,
                });

                return "Hora agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las Horas
        public static List<Horas> FindAll()
        {
            return listaHora;
        }

        //Metodo para encontrar un objeto
        public static Horas FindHora(string cod)
        {

            try
            {
                foreach (Horas hora in FindAll())
                {
                    if (hora.Codigo == int.Parse(cod))
                    {
                        return hora;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Hora

        public static string EditHora(string codigo, string hora)
        {

            try
            {
                Horas horas = FindHora(codigo);
                horas.Hora = hora;

                return "Hora Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Hora

        public static string RemoveHora(string cod)
        {


            listaHora.Remove(FindHora(cod));

            return "Hora removida de la lista";
        }
        
        //Metodo para precargar Hora
        public static void CargarHora()
        {

            if (listaHora.Count < 1)
            {
                AddHora("1", "12:00");
                AddHora("2", "14:00");
                AddHora("3", "16:00");
                AddHora("4", "18:00");

            }
        }
    }
}