using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Empleado
    {
        public int codigo;
        public string rut;
        public string nombre;
        public string apellido;
        public string telefono;
        public Direccion Direccion;
        public Role Role;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string RUT
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Direccion direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public Role role
        {
            get { return Role; }
            set { Role = value; }
        }
    }
}