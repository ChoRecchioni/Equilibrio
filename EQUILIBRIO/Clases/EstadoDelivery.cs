﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class EstadoDelivery
    {
        private int codigo;
        private string nombre;

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

    }
}