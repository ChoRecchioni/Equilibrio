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
        public static string AddReseña(string codigo, string codLocal, string puntuacion, string comentario, Usuario usuario)
        {
            Local local = LocalController.FindLocal(codLocal);
            try
            {
                listaReseña.Add(new Reseña()
                {
                    Codigo = int.Parse(codigo),
                    Local = local,
                    Puntuacion = int.Parse(puntuacion),
                    Comentario = comentario,
                    Usuario = usuario,

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

        public static string EditReseña(string codigo, string codLocal, string puntuacion, string comentario)
        {

            try
            {
                Local local = LocalController.FindLocal(codLocal);
                Reseña reseña = FindReseña(codigo);
                reseña.Local = local;
                reseña.Puntuacion = int.Parse(puntuacion);
                reseña.Comentario = comentario;

                return "Reseña Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Reseña

        public static string RemoveReseña(string cod)
        {
            listaReseña.Remove(FindReseña(cod));

            return "Reseña removida de la lista";
        }

        //Metodo para precargar Reseña
        public static void CargarReseña()
        {
            if (listaReseña.Count < 1)
            {
                LocalController.CargarLocales();
                UsuarioController.CargarUsuario();
                
                AddReseña("2", "3", "2", "comentario sobre el local", UsuarioController.listaUsuario[0]);
            }
        }

        //Metodo de auto increment
        public static int ReseñaAI()
        {
            int cod = listaReseña[listaReseña.Count - 1].Codigo + 1;

            return cod;
        }
    }
}