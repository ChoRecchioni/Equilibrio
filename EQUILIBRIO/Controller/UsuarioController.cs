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
        public static string AddUsuario(string codigo, string rut, string nombre, string apellido, string telefono, string pass, string codDireccion)
        {
            Direccion direccion = DireccionController.FindDireccion(codDireccion);
            try
            {
                listaUsuario.Add(new Usuario()
                {

                    Codigo = int.Parse(codigo),
                    RUT = rut,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Pass = pass,
                    Direccion = direccion,
                });

                return "Usuario agregado.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
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

                return "Dirección Modificada";
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
    }
}