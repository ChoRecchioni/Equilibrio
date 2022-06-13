using System;
using System.Collections.Generic;
using System.Linq;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class MesaController
    {
        private static List<Mesa> listaMesa = new List<Mesa>();

        //Metodo para agregar mesa
        public static string AddMesa(string codigo, string numMesa, string comensales, Local local)
        {
            try
            {
                listaMesa.Add(new Mesa()
                {
                    Codigo = int.Parse(codigo),
                    NumMesa = numMesa,
                    Comensales = int.Parse(comensales),
                    Local = local,
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

        public static Mesa FindMesa(int codLocal, int comensales, DateTime fecha)
        {
            try
            {
                var mesas = FindAll().Where(m => m.Local.Codigo == codLocal && m.Comensales == comensales);
                var mesasReservadas = ReservaController.FindAll().Where(r => r.Local.Codigo == codLocal && r.FechaHora == fecha);
                var lista = mesas.Where(m => !mesasReservadas.Any(mr => mr.Mesa.Codigo == m.Codigo));

                if (lista.Count() > 0)
                    return lista.FirstOrDefault();

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
                AddMesa("1", "A1", "4", LocalController.FindLocal("1"));
                AddMesa("2", "A2", "4", LocalController.FindLocal("1"));
                AddMesa("3", "A3", "4", LocalController.FindLocal("1"));
                AddMesa("4", "B1", "4", LocalController.FindLocal("1"));
                AddMesa("5", "B2", "4", LocalController.FindLocal("1"));
                AddMesa("6", "B3", "4", LocalController.FindLocal("1"));
                AddMesa("7", "C1", "4", LocalController.FindLocal("1"));
                AddMesa("8", "C2", "4", LocalController.FindLocal("1"));
                AddMesa("9", "C3", "4", LocalController.FindLocal("1"));
                AddMesa("10", "V1", "2", LocalController.FindLocal("1"));
                AddMesa("11", "V2", "2", LocalController.FindLocal("1"));
                AddMesa("12", "V3", "2", LocalController.FindLocal("1"));
                AddMesa("13", "V4", "2", LocalController.FindLocal("1"));
                AddMesa("14", "V5", "2", LocalController.FindLocal("1"));
                AddMesa("15", "V6", "2", LocalController.FindLocal("1"));
                AddMesa("16", "V7", "2", LocalController.FindLocal("1"));

                AddMesa("17", "A1", "4", LocalController.FindLocal("2"));
                AddMesa("18", "A2", "4", LocalController.FindLocal("2"));
                AddMesa("19", "A3", "4", LocalController.FindLocal("2"));
                AddMesa("20", "B1", "4", LocalController.FindLocal("2"));
                AddMesa("21", "B2", "4", LocalController.FindLocal("2"));
                AddMesa("22", "B3", "4", LocalController.FindLocal("2"));
                AddMesa("23", "C1", "4", LocalController.FindLocal("2"));
                AddMesa("24", "C2", "4", LocalController.FindLocal("2"));
                AddMesa("25", "C3", "4", LocalController.FindLocal("2"));
                AddMesa("26", "V1", "2", LocalController.FindLocal("2"));
                AddMesa("27", "V2", "2", LocalController.FindLocal("2"));
                AddMesa("28", "V3", "2", LocalController.FindLocal("2"));
                AddMesa("29", "V4", "2", LocalController.FindLocal("2"));
                AddMesa("30", "V5", "2", LocalController.FindLocal("2"));
                AddMesa("31", "V6", "2", LocalController.FindLocal("2"));
                AddMesa("32", "V7", "2", LocalController.FindLocal("2"));

                AddMesa("33", "A1", "4", LocalController.FindLocal("3"));
                AddMesa("34", "A2", "4", LocalController.FindLocal("3"));
                AddMesa("35", "A3", "4", LocalController.FindLocal("3"));
                AddMesa("36", "B1", "4", LocalController.FindLocal("3"));
                AddMesa("37", "B2", "4", LocalController.FindLocal("3"));
                AddMesa("38", "B3", "4", LocalController.FindLocal("3"));
                AddMesa("39", "C1", "4", LocalController.FindLocal("3"));
                AddMesa("40", "C2", "4", LocalController.FindLocal("3"));
                AddMesa("41", "C3", "4", LocalController.FindLocal("3"));
                AddMesa("42", "V1", "2", LocalController.FindLocal("3"));
                AddMesa("43", "V2", "2", LocalController.FindLocal("3"));
                AddMesa("44", "V3", "2", LocalController.FindLocal("3"));
                AddMesa("45", "V4", "2", LocalController.FindLocal("3"));
                AddMesa("46", "V5", "2", LocalController.FindLocal("3"));
                AddMesa("47", "V6", "2", LocalController.FindLocal("3"));
                AddMesa("48", "V7", "2", LocalController.FindLocal("3"));

                AddMesa("49", "A1", "4", LocalController.FindLocal("4"));
                AddMesa("50", "A2", "4", LocalController.FindLocal("4"));
                AddMesa("51", "A3", "4", LocalController.FindLocal("4"));
                AddMesa("52", "B1", "4", LocalController.FindLocal("4"));
                AddMesa("53", "B2", "4", LocalController.FindLocal("4"));
                AddMesa("54", "B3", "4", LocalController.FindLocal("4"));
                AddMesa("55", "C1", "4", LocalController.FindLocal("4"));
                AddMesa("56", "C2", "4", LocalController.FindLocal("4"));
                AddMesa("57", "C3", "4", LocalController.FindLocal("4"));
                AddMesa("58", "V1", "2", LocalController.FindLocal("4"));
                AddMesa("59", "V2", "2", LocalController.FindLocal("4"));
                AddMesa("60", "V3", "2", LocalController.FindLocal("4"));
                AddMesa("61", "V4", "2", LocalController.FindLocal("4"));
                AddMesa("62", "V5", "2", LocalController.FindLocal("4"));
                AddMesa("63", "V6", "2", LocalController.FindLocal("4"));
                AddMesa("64", "V7", "2", LocalController.FindLocal("4"));

                AddMesa("65", "A1", "4", LocalController.FindLocal("5"));
                AddMesa("66", "A2", "4", LocalController.FindLocal("5"));
                AddMesa("67", "A3", "4", LocalController.FindLocal("5"));
                AddMesa("68", "B1", "4", LocalController.FindLocal("5"));
                AddMesa("69", "B2", "4", LocalController.FindLocal("5"));
                AddMesa("70", "B3", "4", LocalController.FindLocal("5"));
                AddMesa("71", "C1", "4", LocalController.FindLocal("5"));
                AddMesa("72", "C2", "4", LocalController.FindLocal("5"));
                AddMesa("73", "C3", "4", LocalController.FindLocal("5"));
                AddMesa("74", "V1", "2", LocalController.FindLocal("5"));
                AddMesa("75", "V2", "2", LocalController.FindLocal("5"));
                AddMesa("76", "V3", "2", LocalController.FindLocal("5"));
                AddMesa("77", "V4", "2", LocalController.FindLocal("5"));
                AddMesa("78", "V5", "2", LocalController.FindLocal("5"));
                AddMesa("79", "V6", "2", LocalController.FindLocal("5"));
                AddMesa("80", "V7", "2", LocalController.FindLocal("5"));
            }
        }
    }
}