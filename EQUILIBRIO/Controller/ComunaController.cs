using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class ComunaController
    {

        private static List<Comuna> listaComuna = new List<Comuna>();

        //Metodo para agregar Comuna
        public static string AddComuna(string codigo, string nombre)
        {
            try
            {
                listaComuna.Add(new Comuna()
                {

                    Codigo = int.Parse(codigo),
                    Nombre = nombre,
                });

                return "Comuna agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las comunas
        public static List<Comuna> FindAll()
        {
            return listaComuna;
        }

        //Metodo para precargar comunas
        public static void CargarComuna()
        {

            if (listaComuna.Count < 1)
            {
                AddComuna("1", "Iquique");
                AddComuna("2", "Santiago");
                AddComuna("3", "Chaitén");
                AddComuna("4", "Concepcion");
                AddComuna("5", "Chillán");
            }
        }

        public static Comuna FindComuna(string cod)
        {

            try
            {
                foreach (Comuna comuna in FindAll())
                {
                    if (comuna.Codigo == int.Parse(cod))
                    {
                        return comuna;
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