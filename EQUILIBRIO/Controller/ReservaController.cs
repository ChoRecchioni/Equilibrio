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
        public static string AddReserva(string codigo, string codSede, DateTime fecha, string codHora, string codMesa)
        {
            Sede sede = SedeController.FindSede(codSede);
            Horas hora = HoraController.FindHora(codHora);
            Mesa mesa = MesaController.FindMesa(codMesa);

            try
            {
                listaReserva.Add(new Reserva()
                {

                    Codigo = int.Parse(codigo),
                    Sede = sede,
                    Fecha = fecha,
                    Hora = hora,
                    Mesa = mesa,
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

        public static string EditReserva(string codigo, DateTime fecha, string codHora, string codMesa)
        {

            try
            {
                Reserva reserva = FindReserva(codigo);
                Horas hora = HoraController.FindHora(codHora);
                Mesa mesa = MesaController.FindMesa(codMesa);

                reserva.Fecha = fecha;
                reserva.Hora = hora;
                reserva.Mesa = mesa;

                return "Reserva Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Reserva

        public static string RemoveMesa(string cod)
        {


            listaReserva.Remove(FindReserva(cod));

            return "Reserva removida de la lista";
        }

        public static void CargarReserva()
        {
            SedeController.CargarSedes();
            MesaController.CargarMesa();
            HoraController.CargarHora();

            if (listaReserva.Count < 1)
            {
                AddReserva("1", "1", DateTime.Now, "1", "17");
            }


        }

        public static int ResAI()
        {
            int cod = listaReserva[listaReserva.Count - 1].Codigo + 1;

            return cod;
        }

    }
}