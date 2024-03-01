using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

public partial class _dbTramiteDocumentarioContext : DbContext
{
    public _dbTramiteDocumentarioContext()
    {
    }

    public _dbTramiteDocumentarioContext(DbContextOptions<_dbTramiteDocumentarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ComprobanteDetalle> ComprobanteDetalles { get; set; }

    public virtual DbSet<ComprobanteProvedor> ComprobanteProvedors { get; set; }

    public virtual DbSet<Credito> Creditos { get; set; }

    public virtual DbSet<DetalleCredito> DetalleCreditos { get; set; }

    public virtual DbSet<DetalleEnvio> DetalleEnvios { get; set; }

    public virtual DbSet<DetalleOrden> DetalleOrdens { get; set; }

    public virtual DbSet<DetalleProduccion> DetalleProduccions { get; set; }

    public virtual DbSet<DetalleProducto> DetalleProductos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Historial> Historials { get; set; }

    public virtual DbSet<IngresoProducto> IngresoProductos { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Produccion> Produccions { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Provedor> Provedors { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<SalidaMaterial> SalidaMaterials { get; set; }

    public virtual DbSet<Trasporte> Trasportes { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VwCliente> VwClientes { get; set; }

    public virtual DbSet<VwComprobanteProvedor> VwComprobanteProvedors { get; set; }

    public virtual DbSet<VwCredito> VwCreditos { get; set; }

    public virtual DbSet<VwDetalleComprovante> VwDetalleComprovantes { get; set; }

    public virtual DbSet<VwDetalleCredito> VwDetalleCreditos { get; set; }

    public virtual DbSet<VwDetalleEnvio> VwDetalleEnvios { get; set; }

    public virtual DbSet<VwDetalleOrden> VwDetalleOrdens { get; set; }

    public virtual DbSet<VwDetalleProduccion> VwDetalleProduccions { get; set; }

    public virtual DbSet<VwDetalleProducto> VwDetalleProductos { get; set; }

    public virtual DbSet<VwEmpleado> VwEmpleados { get; set; }

    public virtual DbSet<VwErrro> VwErrros { get; set; }

    public virtual DbSet<VwHistorial> VwHistorials { get; set; }

    public virtual DbSet<VwIngresoProducto> VwIngresoProductos { get; set; }

    public virtual DbSet<VwMaterial> VwMaterials { get; set; }

    public virtual DbSet<VwOrden> VwOrdens { get; set; }

    public virtual DbSet<VwProduccion> VwProduccions { get; set; }

    public virtual DbSet<VwProducto> VwProductos { get; set; }

    public virtual DbSet<VwProveedor> VwProveedors { get; set; }

    public virtual DbSet<VwSalidaMaterial> VwSalidaMaterials { get; set; }

    public virtual DbSet<VwTrasporte> VwTrasportes { get; set; }

    public virtual DbSet<VwUsuario> VwUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=IHR80PBAB12\\MSSQLSERVER1;Initial Catalog=ZapatertiaDLopez;Integrated Security=True;Trusted_Connection=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.IdArea).HasName("XPKArea");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("XPKCliente");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientePersona");
        });

        modelBuilder.Entity<ComprobanteDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdComprobante, e.IdMaterial }).HasName("XPKComprobanteDetalle");

            entity.HasOne(d => d.IdComprobanteNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteDetalleComprovanteProvedor");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteDetalleMaterial");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteDetalleUnidad");
        });

        modelBuilder.Entity<ComprobanteProvedor>(entity =>
        {
            entity.HasKey(e => e.IdComprobante).HasName("XPKComprobanteProvedor");

            entity.HasOne(d => d.IdProvedorNavigation).WithMany(p => p.ComprobanteProvedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobanteProvedorProvedor");
        });

        modelBuilder.Entity<Credito>(entity =>
        {
            entity.HasKey(e => e.IdCredito).HasName("XPKCredito");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Creditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditoCliente");
        });

        modelBuilder.Entity<DetalleCredito>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.IdCredito }).HasName("XPKDetalleCredito");

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.DetalleCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCreditoCredito");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCreditoOrden");
        });

        modelBuilder.Entity<DetalleEnvio>(entity =>
        {
            entity.HasKey(e => new { e.IdTrasporte, e.IdOrden }).HasName("XPKDetalleEnvio");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleEnvios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleEnvioOrden");

            entity.HasOne(d => d.IdTrasporteNavigation).WithMany(p => p.DetalleEnvios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleEnvioTrasporte");
        });

        modelBuilder.Entity<DetalleOrden>(entity =>
        {
            entity.HasKey(e => new { e.IdOrden, e.IdProducto, e.Talla }).HasName("XPKDetalleOrden");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleOrdenOrden");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleOrdenProducto");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleOrdenUnidad");
        });

        modelBuilder.Entity<DetalleProduccion>(entity =>
        {
            entity.HasKey(e => new { e.IdProduccion, e.IdOrden, e.IdArea, e.IdEmpleado }).HasName("XPKDetalleProduccion");

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProduccionArea");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProduccionEmpleado");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProduccionOrden");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProduccionProduccion");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProduccionUnidad");
        });

        modelBuilder.Entity<DetalleProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdModelo, e.IdProducto, e.Talla }).HasName("XPKDetalleProducto");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.DetalleProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProductoModelo");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleProductoProducto");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("XPKEmpleado");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Empleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoPersona");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.IdError).HasName("XPKError");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Errors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ErrorPersona");
        });

        modelBuilder.Entity<Historial>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("XPKHistorial");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Historials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialUsuario");
        });

        modelBuilder.Entity<IngresoProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdProduccion, e.IdProducto }).HasName("XPKIngresoProducto");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngresoProductoProduccion");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngresoProductoProducto");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngresoProductoUnidad");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.IdMaterial).HasName("XPKMaterial");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Materials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialUnidad");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("XPKModelo");
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.HasKey(e => e.IdOrden).HasName("XPKOrden");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Ordens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCliente");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("XPKPersona");
        });

        modelBuilder.Entity<Produccion>(entity =>
        {
            entity.HasKey(e => e.IdProduccion).HasName("XPKProduccion");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Produccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProduccionUnidad");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("XPKProducto");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoUnidad");
        });

        modelBuilder.Entity<Provedor>(entity =>
        {
            entity.HasKey(e => e.IdProvedor).HasName("XPKProvedor");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Provedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProvedorPersona");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Irol).HasName("XPKRol");
        });

        modelBuilder.Entity<SalidaMaterial>(entity =>
        {
            entity.HasKey(e => new { e.IdMaterial, e.IdProduccion }).HasName("XPKSalidaMaterial");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalidaMaterialMaterial");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalidaMaterialProduccion");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalidaMaterialUnidad");
        });

        modelBuilder.Entity<Trasporte>(entity =>
        {
            entity.HasKey(e => e.IdTrasporte).HasName("XPKTrasporte");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Trasportes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrasportePersona");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.IdUnidad).HasName("XPKUnidad");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("XPKUsuario");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioPersona");

            entity.HasOne(d => d.IrolNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol");
        });

        modelBuilder.Entity<VwCliente>(entity =>
        {
            entity.ToView("VW_Cliente", "Venta");
        });

        modelBuilder.Entity<VwComprobanteProvedor>(entity =>
        {
            entity.ToView("VW_ComprobanteProvedor", "Compra");
        });

        modelBuilder.Entity<VwCredito>(entity =>
        {
            entity.ToView("VW_Credito", "Venta");
        });

        modelBuilder.Entity<VwDetalleComprovante>(entity =>
        {
            entity.ToView("VW_DetalleComprovante", "Compra");
        });

        modelBuilder.Entity<VwDetalleCredito>(entity =>
        {
            entity.ToView("VW_DetalleCredito", "Venta");
        });

        modelBuilder.Entity<VwDetalleEnvio>(entity =>
        {
            entity.ToView("VW_DetalleEnvio", "Venta");
        });

        modelBuilder.Entity<VwDetalleOrden>(entity =>
        {
            entity.ToView("VW_DetalleOrden", "Venta");
        });

        modelBuilder.Entity<VwDetalleProduccion>(entity =>
        {
            entity.ToView("VW_DetalleProduccion", "Produccion");
        });

        modelBuilder.Entity<VwDetalleProducto>(entity =>
        {
            entity.ToView("VW_DetalleProducto", "Venta");
        });

        modelBuilder.Entity<VwEmpleado>(entity =>
        {
            entity.ToView("VW_Empleado", "Produccion");
        });

        modelBuilder.Entity<VwErrro>(entity =>
        {
            entity.ToView("VW_Errro", "Sistema");
        });

        modelBuilder.Entity<VwHistorial>(entity =>
        {
            entity.ToView("VW_Historial", "Sistema");
        });

        modelBuilder.Entity<VwIngresoProducto>(entity =>
        {
            entity.ToView("VW_IngresoProducto", "Produccion");
        });

        modelBuilder.Entity<VwMaterial>(entity =>
        {
            entity.ToView("VW_Material", "Compra");
        });

        modelBuilder.Entity<VwOrden>(entity =>
        {
            entity.ToView("VW_Orden", "Venta");
        });

        modelBuilder.Entity<VwProduccion>(entity =>
        {
            entity.ToView("VW_Produccion", "Produccion");
        });

        modelBuilder.Entity<VwProducto>(entity =>
        {
            entity.ToView("VW_Producto", "Venta");
        });

        modelBuilder.Entity<VwProveedor>(entity =>
        {
            entity.ToView("VW_Proveedor", "Compra");
        });

        modelBuilder.Entity<VwSalidaMaterial>(entity =>
        {
            entity.ToView("VW_SalidaMaterial", "Produccion");
        });

        modelBuilder.Entity<VwTrasporte>(entity =>
        {
            entity.ToView("VW_Trasporte", "Venta");
        });

        modelBuilder.Entity<VwUsuario>(entity =>
        {
            entity.ToView("VW_Usuario", "Sistema");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
