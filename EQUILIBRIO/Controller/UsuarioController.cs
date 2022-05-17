using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class UsuarioController
    {
        private static List<Usuario> listaUsuario = new List<Usuario>();

        //Metodo para agregar Usuario

        public static string AddUsuario(int codigo, string rut, string nombre, string apellido, string telefono, string pass, string codDireccion, string Codrol)
        {

            Direccion direccion = DireccionController.FindDireccion(codDireccion);
            Role rol = RoleController.FindRole(Codrol);
            Usuario u = new Usuario()
            {
                Codigo = codigo,
                RUT = rut,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Pass = pass,
                Direccion = direccion,
                Rol = rol,
            };
            listaUsuario.Add(u);

            return "Ok";
        }

        //Metodo para listar todos los usuarios
        public static List<Usuario> FindAll()
        {
            return listaUsuario;
        }

        //Metodo para encontrar un objeto
        public static Usuario FindUsuario(string cod)
        {

            try
            {
                foreach (Usuario usuario in FindAll())
                {
                    if (usuario.Codigo == int.Parse(cod))
                    {
                        return usuario;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }


        //Metodo para editar Usuario

        public static string EditUsuario(string codigo, string rut, string nombre, string apellido, string telefono, string pass, string codDireccion)
        {

            try
            {
                Direccion direccion = DireccionController.FindDireccion(codDireccion);
                   Usuario usuario = FindUsuario(codigo);
                    usuario.RUT = rut;
                    usuario.Nombre = nombre;
                     usuario.Apellido = apellido;
                    usuario.Telefono = telefono;
                    usuario.Pass = pass;
                    usuario.Direccion = direccion;

                return "Usuario Modificado";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Usuario

        public static string RemoveUsuario(string cod)
        {


            listaUsuario.Remove(FindUsuario(cod));

            return "Usuario removido de la lista";
        }

        //Metodo de validar usuario
        public static Usuario FindUser(string username)
        {

            foreach (Usuario item in listaUsuario)
            {
                if (item.Nombre.Equals(username))
                {
                    return item;
                }
            }
            return null;

        }
        public static Usuario FindUser(int codigo)
        {
            return null;
        }

        //Metodo para precargar Admin y Cliente
        public static void CargarUsuario()
        {

            if (listaUsuario.Count < 1)
            {
                AddUsuario(1, "101", "admin", "admin", "569", "admin", "0", "1");
                AddUsuario(2, "202", "cliente", "cliente", "569", "cliente", "0", "2");
            }
        }

        //Metodo de auto increment
        public static int UserAI()
        {
              int cod = listaUsuario[listaUsuario.Count - 1].Codigo + 1;

            return cod;
        }
    }
}