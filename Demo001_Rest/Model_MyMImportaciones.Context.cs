//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo001_Rest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FACTURACION_MYMEntities : DbContext
    {
        public FACTURACION_MYMEntities()
            : base("name=FACTURACION_MYMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<CUERPO_FACTURA> CUERPO_FACTURA { get; set; }
        public virtual DbSet<ENCABEZADO_FACT> ENCABEZADO_FACT { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
    }
}
