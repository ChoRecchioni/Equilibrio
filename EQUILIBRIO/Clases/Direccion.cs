using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace equilibrio.Clases
{
    public class Direccion
    {
        private int codigo;
        private string alias;
        private string calleYnum;
        private string depto;
        private Comuna comuna;
        private Region region;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public string CalleYnum
        {
            get { return calleYnum; }
            set { calleYnum = value; }
        }

        public string Depto
        {
            get { return depto; }
            set { depto = value; }
        }

        public Comuna Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }

        public Region Region
        {
            get { return region; }
            set { region = value; }
        }
    }
}