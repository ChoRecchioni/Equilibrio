using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class ReseñaController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Reseña> findAll()
        {

            var res = from r in entidades.Reseña
                      select r;

            return res.ToList();
        }

        //Metodo para agregar
        public static string AddReseña(string codigo, string puntuacion, string comentario, string fecha, string codSede, string codUser)
        {

            Reseña r = new Reseña()
            {
                codigo = int.Parse(codigo),
                puntuacion = int.Parse(puntuacion),
                comentario = comentario,
                fecha = Convert.ToDateTime(fecha),
                fk_sede = int.Parse(codSede),
                fk_usuario = int.Parse(codUser),
            };

            entidades.Reseña.Add(r);
            entidades.SaveChanges();

            return "Reseña agregado.";
        }


        //Metodo para encontrar uno
        public static Reseña FindReseña(int codigo)
        {

            return entidades.Reseña.SingleOrDefault(r => r.codigo == codigo);
        }


        //Metodo para editar
        public static string editReseña(string codigo, string puntuacion, string comentario, string fecha, string codSede, string codUser)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Reseña r = FindReseña(intCod);

            if (r != null)
            {
                r.puntuacion = int.Parse(puntuacion);
                r.comentario = comentario;
                r.fecha = Convert.ToDateTime(fecha);
                r.fk_sede = int.Parse(codSede);
                r.fk_usuario = int.Parse(codUser);
                entidades.SaveChanges();
                return "Reseña modificada";
            }
            else
            {
                return "No se pudo modificar la Reseña";
            }
        }


        //Metodo para eliminar
        public static string removeReseña(int codigo)
        {

            Reseña r = FindReseña(codigo);
            entidades.Reseña.Remove(r);
            entidades.SaveChanges();

            return "Reseña eliminada";
        }

        // Fin nuevo Controller

        //private static List<Reseña> listaReseña = new List<Reseña>();

        ////Metodo para agregar Reseña
        //public static string AddReseña(string codigo, string codLocal, string puntuacion, string comentario, Usuario usuario)
        //{
        //    Local local = LocalController.FindLocal(codLocal);
        //    try
        //    {
        //        listaReseña.Add(new Reseña()
        //        {
        //            Codigo = int.Parse(codigo),
        //            Local = local,
        //            Puntuacion = int.Parse(puntuacion),
        //            Comentario = comentario,
        //            Usuario = usuario,

        //        });

        //        return "Reseña agregada.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todos las Reseñas
        //public static List<Reseña> FindAll()
        //{
        //    return listaReseña;
        //}

        ////Metodo para encontrar un objeto
        //public static Reseña FindReseña(string cod)
        //{

        //    try
        //    {
        //        foreach (Reseña reseña in FindAll())
        //        {
        //            if (reseña.Codigo == int.Parse(cod))
        //            {
        //                return reseña;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}

        ////Metodo para editar Reseña

        //public static string EditReseña(string codigo, string codLocal, string puntuacion, string comentario)
        //{

        //    try
        //    {
        //        Local local = LocalController.FindLocal(codLocal);
        //        Reseña reseña = FindReseña(codigo);
        //        reseña.Local = local;
        //        reseña.Puntuacion = int.Parse(puntuacion);
        //        reseña.Comentario = comentario;

        //        return "Reseña Modificada";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }


        //}
        //// Metodo para eliminar Reseña

        //public static string RemoveReseña(string cod)
        //{
        //    listaReseña.Remove(FindReseña(cod));

        //    return "Reseña removida de la lista";
        //}

        ////Metodo para precargar Reseña
        //public static void CargarReseña()
        //{
        //    if (listaReseña.Count < 1)
        //    {
        //        LocalController.CargarLocales();
        //        UsuarioController.CargarUsuario();
                
        //        AddReseña("2", "3", "2", "comentario sobre el local", UsuarioController.listaUsuario[0]);
        //    }
        //}

        ////Metodo de auto increment
        //public static int ReseñaAI()
        //{
        //    int cod = listaReseña[listaReseña.Count - 1].Codigo + 1;

        //    return cod;
        //}
    }
}