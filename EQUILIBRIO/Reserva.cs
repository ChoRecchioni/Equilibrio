//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace equilibrio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int codigo { get; set; }
        public System.DateTime fecha { get; set; }
        public int fk_sede { get; set; }
        public Nullable<int> fk_mesa { get; set; }
        public Nullable<int> fk_usuario { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        public virtual Mesa Mesa { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
