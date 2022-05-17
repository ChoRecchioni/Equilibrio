using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class SedeController
    {
        private static List<Sede> listaSede = new List<Sede>();

        //Metodo de registrar Sede

        public static string AddSede(string codigo, string nombre)
        {
            try
            {
                listaSede.Add(new Sede()
                {

                    Codigo = int.Parse(codigo),
                    Nombre = nombre,
                });

                return "Sede agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las regiones
        public static List<Sede> FindAll()
        {
            return listaSede;
        }

        //Metodo para precargar regiones
        public static void CargarSedes()
        {

            if (listaSede.Count < 1)
            {
                AddSede("1", "LA FLORIDA");
                AddSede("2", "SANTIAGO CENTRO");
                AddSede("3", "VIÑA DEL MAR");
                AddSede("4", "MAIPU");
                AddSede("5", "PROVIDENCIA");
            }
        }

        public static Sede FindSede(string cod)
        {

            try
            {
                foreach (Sede sede in FindAll())
                {
                    if (sede.Codigo == int.Parse(cod))
                    {
                        return sede;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}