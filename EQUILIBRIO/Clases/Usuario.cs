using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Usuario
    {
        private int codigo;
        private string rut;
        private string nombre;
        private string apellido;
        private string telefono;
        private string pass;
        private Direccion direccion;
        private Role rol;
        private Local local; //FK not null

        public Usuario() { }

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

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Role Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public Local Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}