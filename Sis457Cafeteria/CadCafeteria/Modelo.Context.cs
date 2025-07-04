﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadCafeteria
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LabCafeteriaEntities : DbContext
    {
        public LabCafeteriaEntities()
            : base("name=LabCafeteriaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual ObjectResult<paEmpleadoListar_Result> paEmpleadoListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paEmpleadoListar_Result>("paEmpleadoListar", parametroParameter);
        }
    
        public virtual ObjectResult<paProductoListar_Result> paProductoListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paProductoListar_Result>("paProductoListar", parametroParameter);
        }
    
        public virtual ObjectResult<paClienteListar_Result> paClienteListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paClienteListar_Result>("paClienteListar", parametroParameter);
        }
    
        public virtual ObjectResult<paPedidoListar_Result> paPedidoListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paPedidoListar_Result>("paPedidoListar", parametroParameter);
        }
    }
}
