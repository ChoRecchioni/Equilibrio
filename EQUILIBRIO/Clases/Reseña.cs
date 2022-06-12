using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Reseña
    {
        private int codigo;
        private Sede sede;
        private int puntuacion;
        private string comentario;
        private Usuario usuario;
        private DateTime fecha;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Sede Sede
        {
            get { return sede; }
            set { sede = value; }
        }

        public int Puntuacion
        {
            get { return puntuacion; }
            set { puntuacion = value; }
        }
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}