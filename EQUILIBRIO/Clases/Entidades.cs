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
        public string Depto { get; set; }
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
        public int Codigo { get; set; }
        public Sede Sede { get; set; }
        public int Puntuacion { get; set; }
        public string Comentario { get; set; }
    }

    public class Reserva
    {
        public int Codigo { get; set; }
        public Sede Sede { get; set; }
        public DateTime Fecha { get; set; }
        public Horas Hora { get; set; }
        public Mesa Mesa { get; set; }
    }

    public class Horas
    {
        public int Codigo { get; set; }


        public string Hora { get; set; }
       
    }

    public class HoraMesa
    {
        public Horas hora { get; set; }
        public Mesa mesa { get; set; }
    }

    public class Mesa
    {
        public int Codigo { get; set; }
        public string NumMesa { get; set; }
        public int Comensales { get; set; }
    }

    public class Usuario
    {
        public Usuario() { }
        public int Codigo { get; set; }
        public string RUT { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Pass { get; set; }
        public Direccion Direccion { get; set; }
        public Role Rol { get; set; }


    }

    public class Role
    {
        public Role() { }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }

    public class Sede
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
}