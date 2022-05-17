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