using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Delivery
    {

        private int codigo;
        private OrdenCompra orden;
        private EstadoDelivery estado;
        private int numPedido;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public OrdenCompra Orden
        {
            get { return orden; }
            set { orden = value; }
        }

        public EstadoDelivery Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int NumPedido
        {
            get { return numPedido; }
            set { numPedido = value; }
        }

    }
}