using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Region
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }

    public class Comuna
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }

    public class Carta
    {

    }
    public class CarroCompras
    {

    }
    public class Delivery
    {

    }
    public class Direccion
    {
        public int Codigo { get; set; }
        public string Alias { get; set; }
        public string CalleYnum { get; set; }
        public Comuna Comuna { get; set; }
        public Region Region { get; set; }
    }
    public class Empleado
    {

    }
    public class Nomina
    {

    }
    public class Reseña
    {

    }
    public class Reservas
    {

    }
    public class Usuario
    {
        public string Codigo;
        public string RUT;
        public string Nombre;
        public string Apellido;
        public string Telefono;
        public string Pass;
    }

}