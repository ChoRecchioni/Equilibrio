using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class ComunaController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Comuna> findAll()
        {

            var com = from c in entidades.Comuna
                      select c;

            return com.ToList();
        }

        //Metodo para agregar
        public static string AddComuna(string codigo, string nombre)
        {

            Comuna c = new Comuna()
            {
                codigo = int.Parse(codigo),
                nombre = nombre,
            };

            entidades.Comuna.Add(c);
            entidades.SaveChanges();

            return "Revista agregada.";
        }


        //Metodo para encontrar uno
        public static Comuna FindComuna(int codigo)
        {

            return entidades.Comuna.SingleOrDefault(c => c.codigo == codigo);
        }


        //Metodo para editar
        public static string editComuna(string codigo, string nombre)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Comuna c = FindComuna(intCod);

            if (c != null)
            {
                c.nombre = nombre;
                entidades.SaveChanges();
                return "Comuna modificada";
            }
            else
            {
                return "No se pudo modificar la comuna";
            }
        }


        //Metodo para eliminar
        public static string removeComuna(int codigo)
        {

            Comuna c = FindComuna(codigo);
            entidades.Comuna.Remove(c);
            entidades.SaveChanges();
            return "Comuna eliminada";
        }

        // Fin nuevo Controller


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