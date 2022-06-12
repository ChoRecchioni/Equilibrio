using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Horas
    {
        private int codigo;
        private string hora;
        private Fechas fechas;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public Fechas Fechas
        {
            get { return fechas; }
            set { fechas = value; }
        }
    }
}