using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Local
    {
        private int codigo;
        private string nombre;
        private Direccion direccion;
        private string telefono;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}