using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Mesa
    {
        private int codigo;
        private string numMesa;
        private int comensales;
        private Local local;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NumMesa
        {
            get { return numMesa; }
            set { numMesa = value; }
        }

        public int Comensales
        {
            get { return comensales; }
            set { comensales = value; }
        }

        public Local Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}