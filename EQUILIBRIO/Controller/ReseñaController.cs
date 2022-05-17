using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class ReseñaController
    {
        private static List<Reseña> listaReseña = new List<Reseña>();

        //Metodo para agregar Reseña
        public static string AddReseña(string codigo, string codSede, string puntuacion, string comentario)
        {
            Sede sede = SedeController.FindSede(codSede);
            try
            {
                listaReseña.Add(new Reseña()
                {

                    Codigo = int.Parse(codigo),
                    Sede = sede,
                    Puntuacion = int.Parse(puntuacion),
                    Comentario = comentario,
                });

                return "Reseña agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todos las Reseñas
        public static List<Reseña> FindAll()
        {
            return listaReseña;
        }

        //Metodo para encontrar un objeto
        public static Reseña FindReseña(string cod)
        {

            try
            {
                foreach (Reseña reseña in FindAll())
                {
                    if (reseña.Codigo == int.Parse(cod))
                    {
                        return reseña;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar Reseña

        public static string EditReseña(string codigo, string codSede, string puntuacion, string comentario)
        {

            try
            {
                Sede sede = SedeController.FindSede(codSede);
                Reseña reseña = FindReseña(codigo);
                reseña.Sede = sede;
                reseña.Puntuacion = int.Parse(puntuacion);
                reseña.Comentario = comentario;

                return "Reseña Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Usuario

        public static string RemoveUsuario(string cod)
        {


            listaReseña.Remove(FindReseña(cod));

            return "Reseña removida de la lista";
        }
    }
}