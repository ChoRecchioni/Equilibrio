using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Articulo_Carro
    {
        private int codigo;
        private Artículo articulo;
        private CarroCompras carro;
        private int cantidad;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Artículo Artículo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public CarroCompras Carro
        {
            get { return carro; }
            set { carro = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}