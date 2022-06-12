using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Reserva
    {
        private int codigo;
        private Local local;
        private DateTime fechaHora;
        private Mesa mesa;
        private Usuario usuario;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Local Local
        {
            get { return local; }
            set { local = value; }
        }
        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        public Mesa Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}