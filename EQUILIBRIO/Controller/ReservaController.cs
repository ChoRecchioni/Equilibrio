using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class ReservaController
    {
        private static List<Reserva> listaReserva = new List<Reserva>();

        //Metodo para agregar Reserva
        public static string AddReserva(string codigo, string codMesa, DateTime fecha, string codLocal, string codUsuario)
        {
            Mesa mesa = MesaController.FindMesa(codMesa);

            try
            {
                listaReserva.Add(new Reserva()
                {
                    Codigo = int.Parse(codigo),
                    Mesa = mesa,
                    FechaHora = fecha,
                    Local = LocalController.FindLocal(codLocal),
                    Usuario = UsuarioController.FindUsuario(codUsuario)
                });

                return "Reserva agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las Reservas
        public static List<Reserva> FindAll()
        {
            return listaReserva;
        }

        //Metodo para encontrar un objeto
        public static Reserva FindReserva(string cod)
        {

            try
            {
                foreach (Reserva reserva in FindAll())
                {
                    if (reserva.Codigo == int.Parse(cod))
                    {
                        return reserva;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Reserva

        public static string EditReserva(string codigo, string codMesa, DateTime fecha, string codLocal )
        {
            try
            {
                Reserva reserva = FindReserva(codigo);
                reserva.FechaHora = fecha;
                reserva.Local = LocalController.FindLocal(codLocal);
                reserva.Mesa = MesaController.FindMesa(codMesa);

                return "Reserva Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Reserva

        public static string RemoveReserva(string cod)
        {
            listaReserva.Remove(FindReserva(cod));

            return "Reserva removida de la lista";
        }

        public static void CargarReserva()
        {
            UsuarioController.CargarUsuario();
            LocalController.CargarLocales();
            MesaController.CargarMesa();

            if (listaReserva.Count < 1)
            {
                AddReserva("1", "16", new DateTime(2022, 8, 3, 13, 0, 0), "1", "2");
                AddReserva("2", "2", new DateTime(2022, 8, 5, 12, 0, 0), "1", "2");
                AddReserva("3", "2", new DateTime(2022, 8, 7, 12, 0, 0), "1", "2");
                AddReserva("4", "2", new DateTime(2022, 8, 10, 12, 0, 0), "1", "2");
                AddReserva("5", "2", new DateTime(2022, 8, 10, 12, 0, 0), "1", "2");
                AddReserva("6", "2", new DateTime(2022, 8, 10, 12, 0, 0), "1", "1");
                AddReserva("7", "2", new DateTime(2022, 8, 10, 12, 0, 0), "1", "1");
                AddReserva("8", "4", new DateTime(2022, 8, 10, 13, 0, 0), "1", "1");
                AddReserva("9", "4", new DateTime(2022, 8, 10, 13, 0, 0), "1", "1");
                AddReserva("10", "3", new DateTime(2022, 8, 10, 13, 0, 0), "1", "1");
                AddReserva("11", "1", new DateTime(2022, 8, 10, 13, 0, 0), "1", "1");
                AddReserva("12", "1", new DateTime(2022, 8, 26, 12, 0, 0), "1", "1");
                AddReserva("13", "1", new DateTime(2022, 8, 30, 16, 0, 0), "1", "1");
            }
        }

        public static int ResAI()
        {
            int cod = listaReserva[listaReserva.Count - 1].Codigo + 1;

            return cod;
        }

    }
}