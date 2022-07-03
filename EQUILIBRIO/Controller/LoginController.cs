using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class LoginController
    {

        //Metodo de Log in
        public static Usuario Login(string username, string password)
        {
            Usuario lgu = UsuarioController.FindUser(username);
            if (lgu != null)
            {
                if (lgu.pass.Equals(password))
                {
                    return lgu;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}