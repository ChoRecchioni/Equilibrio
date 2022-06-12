using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Fechas
    {
        private int codigo;
        private DateTime fecha;
        private Local local;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Local Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}