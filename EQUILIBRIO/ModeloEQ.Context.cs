﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EQEntidades : DbContext
    {
        public EQEntidades()
            : base("name=EQEntidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artículo> Artículo { get; set; }
        public virtual DbSet<ArticuloCarro> ArticuloCarro { get; set; }
        public virtual DbSet<CarroCompras> CarroCompras { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Comuna> Comuna { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EstadoDelivery> EstadoDelivery { get; set; }
        public virtual DbSet<Mesa> Mesa { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Reseña> Reseña { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
