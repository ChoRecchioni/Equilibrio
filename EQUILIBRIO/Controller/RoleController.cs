using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class RoleController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Rol> findAll()
        {

            var rol = from r in entidades.Rol
                      select r;

            return rol.ToList();
        }

        //Metodo para agregar
        public static string AddRol(string codigo, string nombre)
        {

            Rol r = new Rol()
            {
                codigo = int.Parse(codigo),
                nombre = nombre,
            };

            entidades.Rol.Add(r);
            entidades.SaveChanges();

            return "Rol agregado.";
        }


        //Metodo para encontrar uno
        public static Rol FindRol(int codigo)
        {

            return entidades.Rol.SingleOrDefault(r => r.codigo == codigo);
        }


        //Metodo para editar
        public static string editRol(string codigo, string nombre)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            Rol r = FindRol(intCod);

            if (r != null)
            {
                r.nombre = nombre;
                entidades.SaveChanges();
                return "Rol modificado";
            }
            else
            {
                return "No se pudo modificar el rol";
            }
        }


        //Metodo para eliminar
        public static string removeRol(int codigo)
        {

            Rol r = FindRol(codigo);
            entidades.Rol.Remove(r);
            entidades.SaveChanges();

            return "Rol eliminado";
        }

        // Fin nuevo Controller

        private static List<Role> listaRoles = new List<Role>();


        //Metodo para agregar Rol
        public static string AddRole(int codigo, string nombre)
        {
            Role r = new Role()
            {
                Codigo = codigo,
                Nombre = nombre,
            };
            listaRoles.Add(r);

            return "Ok";
        }

        //Metodo para listar Roles
        public static List<Role> FindAll()
        {
            return listaRoles;
        }

        //Metodo para encontrar un objeto
        public static Role FindRole(string cod)
        {

            try
            {
                foreach (Role rol in FindAll())
                {
                    if (rol.Codigo == int.Parse(cod))
                    {
                        return rol;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para precargar Roles
        public static void CargarRoles()
        {

            if (listaRoles.Count < 1)
            {
                AddRole(1, "Administrador");
                AddRole(2, "Cliente");
            }
        }
    }
}