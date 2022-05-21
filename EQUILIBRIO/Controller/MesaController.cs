using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class MesaController
    {
        private static List<Mesa> listaMesa = new List<Mesa>();

        //Metodo para agregar mesa
        public static string AddMesa(string codigo, string numMesa, string comensales)
        {
            try
            {
                listaMesa.Add(new Mesa()
                {

                    Codigo = int.Parse(codigo),
                    NumMesa = numMesa,
                    Comensales = int.Parse(comensales),
                });

                return "Mesa agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las Mesas
        public static List<Mesa> FindAll()
        {
            return listaMesa;
        }

        //Metodo para encontrar un objeto
        public static Mesa FindMesa(string cod)
        {

            try
            {
                foreach (Mesa mesa in FindAll())
                {
                    if (mesa.Codigo == int.Parse(cod))
                    {
                        return mesa;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar mesa

        public static string EditMesa(string codigo, string numMesa, string comensales)
        {

            try
            {
                Mesa mesa = FindMesa(codigo);
                mesa.NumMesa = numMesa;
                mesa.Comensales = int.Parse(comensales);

                return "Mesa Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Mesa

        public static string RemoveMesa(string cod)
        {


            listaMesa.Remove(FindMesa(cod));

            return "Mesa removida de la lista";
        }

        public static void CargarMesa()
        {

            if (listaMesa.Count < 1)
            {
                AddMesa("1", "A1", "4");
                AddMesa("2", "A2", "4");
                AddMesa("3", "A3", "4");
                AddMesa("4", "B1", "4");
                AddMesa("5", "B2", "4");
                AddMesa("6", "B3", "4");
                AddMesa("7", "C1", "4");
                AddMesa("8", "C2", "4");
                AddMesa("9", "C3", "4");
                AddMesa("10", "V1", "2");
                AddMesa("11", "V2", "2");
                AddMesa("12", "V3", "2");
                AddMesa("13", "V4", "2");
                AddMesa("14", "V5", "2");
                AddMesa("15", "V6", "2");
                AddMesa("16", "V7", "2");
                AddMesa("17", "TEST", "1");

            }
        }
    }
}