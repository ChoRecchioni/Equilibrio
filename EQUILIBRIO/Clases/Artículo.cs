using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Artículo
    {
        private int codigo;
        private string nombre;
        private string precio;
        private string comentario;

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

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
    }
}