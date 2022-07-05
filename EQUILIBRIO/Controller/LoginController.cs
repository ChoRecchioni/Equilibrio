using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Controller;

namespace equilibrio.Controller
{
    public class LoginController
    {

        //Metodo de Log in
        public static Usuario Login(string username, string password)
        {
            Usuario lgu = UsuarioController.validUser(username);
            string passMD5 = UsuarioController.GetMD5(password);
            if (lgu != null)
            {
                if (lgu.pass.Equals(passMD5))
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