using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

            return " ";
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
                return " ";
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
            return " ";
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

        public static string GetMD5(string pass)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding codificar = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(codificar.GetBytes(pass));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}