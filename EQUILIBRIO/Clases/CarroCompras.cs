using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class CarroCompras
    {
        private int codigo;
        private Usuario User;
        private List<Articulo_Carro> artCar;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Usuario user
        {
            get { return User; }
            set { User = value; }
        }
        public List<Articulo_Carro> ArtCar
        {
            get { return artCar; }
            set { artCar = value; }
        }
    }
}