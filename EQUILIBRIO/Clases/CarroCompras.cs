using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class CarroCompras
    {
        private int codigo;
        private Usuario User;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Usuario user
        {
            get { return User; }
            set { User = value; }
        }
    }
}