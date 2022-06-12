using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class FechaController
    {
        private static List<Fechas> listaFechas = new List<Fechas>();

        public static string AddFecha(string codigo, string fecha)
        {
            try
            {
                listaFechas.Add(new Fechas()
                {

                    Codigo = int.Parse(codigo),
                    Fecha = fecha,
                });

                return "Fecha agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public static List<Fechas> FindAll()
        {
            return listaFechas;
        }

        public static Fechas FindFechas(string cod)
        {

            try
            {
                foreach (Fechas fechas in FindAll())
                {
                    if (fechas.Codigo == int.Parse(cod))
                    {
                        return fechas;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public static void CargarFecha()
        {
            if (listaFechas.Count < 1)
            {
                AddFecha("1", "30/08/2022");
                AddFecha("2", "30/08/2022");
                AddFecha("3", "28/08/2022");
                AddFecha("4", "27/08/2022");
            }
        }

    }
}