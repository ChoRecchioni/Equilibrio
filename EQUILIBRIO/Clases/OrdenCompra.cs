using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class OrdenCompra
    {

        private int codigo;
        private CarroCompras carro;
        private string total;
        private Local local;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public CarroCompras Carro
        {
            get { return carro; }
            set { carro = value; }
        }

        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        public Local Local
        {
            get { return local; }
            set { local = value; }
        }

    }
}