using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Controller
{
    public class UsuarioController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<Usuario> findAll()
        {

            var user = from u in entidades.Usuario
                      select u;

            return user.ToList();
        }

        //Metodo para agregar
        public static string AddUsuario(string rut, string nombre, string apellido, string telefono, string pass, string codDir, string correo)
        {

            Usuario u = new Usuario()
            {
                rut = rut,
                nombre = nombre,
                apellido = apellido,
                telefono = telefono,
                pass = pass,
                correo = correo,
                fk_direccion = int.Parse(codDir),
                fk_rol = null,
                fk_sede = null,

            };

            entidades.Usuario.Add(u);
            entidades.SaveChanges();

            return "Usuario agregado.";
        }


        //Metodo para encontrar uno
        public static Usuario FindUsuario(int codigo)
        {

            return entidades.Usuario.SingleOrDefault(u => u.codigo == codigo);
        }


        //Metodo para editar
        public static string editUsuario(string codigo, string nombre, string apellido, string telefono)
        {
            int intCod = int.Parse(codigo);
            Usuario u = FindUsuario(intCod);

            if (u != null)
            {
                u.nombre = nombre;
                u.apellido = apellido;
                u.telefono = telefono;
                entidades.SaveChanges();
                return "Usuario modificada";
            }
            else
            {
                return "No se pudo modificar el usuario";
            }
        }


        //Metodo para eliminar
        public static string removeUsuario(int codigo)
        {

            Usuario u = FindUsuario(codigo);
            entidades.Usuario.Remove(u);
            entidades.SaveChanges();
            return "Usuario eliminada";
        }

        //Metodo de validar usuario en la lista
        public static Usuario validUser(string username)
        {
            foreach (Usuario item in findAll())
            {
                if (item.nombre.Equals(username))
                {
                    return item;
                }
            }
            return null;
        }
        public static Usuario validUser(int codigo)
        {
            return null;
        }
        public static Usuario FindUserRut(string rut)
        {
            foreach (Usuario item in findAll())
            {
                if (item.rut.Equals(rut))
                {
                    return item;
                }
            }
            return null;
        }

        // Fin nuevo Controller


        //public static List<Usuario> listaUsuario = new List<Usuario>();

        ////Metodo para agregar Usuario
        //public static string AddUsuario(int codigo, string rut, string nombre, string apellido, string telefono, string pass, string codDireccion, string Codrol, string CodLocal)
        //{
        //    Direccion direccion = DireccionController.FindDireccion(codDireccion);
        //    Role rol = RoleController.FindRole(Codrol);
        //    Local local = LocalController.FindLocal(CodLocal); 
        //    Usuario u = new Usuario()
        //    {
        //        Codigo = codigo,
        //        RUT = rut,
        //        Nombre = nombre,
        //        Apellido = apellido,
        //        Telefono = telefono,
        //        Pass = pass,
        //        Direccion = direccion,
        //        Rol = rol,
        //        Local = local,

        //    };
        //    listaUsuario.Add(u);

        //    return "Ok";
        //}

        ////Metodo para listar todos los usuarios
        //public static List<Usuario> FindAll()
        //{
        //    return listaUsuario;
        //}

        ////Metodo para encontrar un objeto
        //public static Usuario FindUsuario(string cod)
        //{
        //    try
        //    {
        //        foreach (Usuario usuario in FindAll())
        //        {
        //            if (usuario.Codigo == int.Parse(cod))
        //            {
        //                return usuario;
        //            }
        //        }
        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }
        //}

        ////Metodo de validar usuario en la lista
        //public static Usuario FindUser(string username)
        //{
        //    foreach (Usuario item in listaUsuario)
        //    {
        //        if (item.Nombre.Equals(username))
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
        //public static Usuario FindUser(int codigo)
        //{
        //    return null;
        //}
        //public static Usuario FindUserRut(string rut)
        //{
        //    foreach (Usuario item in listaUsuario)
        //    {
        //        if (item.RUT.Equals(rut))
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}

        ////Metodo para editar Usuario
        //public static string EditUsuario(string codigo, string nombre, string apellido, string telefono)
        //{
        //    try
        //    {
                
        //        Usuario usuario = FindUsuario(codigo);
        //        usuario.Nombre = nombre;
        //        usuario.Apellido = apellido;
        //        usuario.Telefono = telefono;

        //        return "";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}

        //// Metodo para eliminar Usuario
        //public static string RemoveUsuario(string cod)
        //{
        //    listaUsuario.Remove(FindUsuario(cod));

        //    return "Usuario removido de la lista";
        //}

        

        ////Metodo para precargar Admin y Cliente
        //public static void CargarUsuario()
        //{
        //    RoleController.CargarRoles();
        //    DireccionController.CargarDirección();
        //    LocalController.CargarLocales();
        //    if (listaUsuario.Count < 1)
        //    {
        //        AddUsuario(1, "101", "admin", "admin", "569", "admin", "1", "1", "1");
        //        AddUsuario(2, "202", "cliente", "cliente", "569", "cliente", "1", "2", "");
        //        AddUsuario(3, "25929867-9", "sofia", "sofia", "5691111", "sofia", "1", "2", "");
        //    }
        //}

        ////Metodo de auto increment
        //public static int UserAI()
        //{
        //    int cod = listaUsuario[listaUsuario.Count - 1].Codigo + 1;

        //    return cod;
        //}
    }
}