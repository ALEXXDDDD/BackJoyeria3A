using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Orden", Schema = "Venta")]
public partial class Orden
{
    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    public int IdCliente { get; set; }

    public bool TipoOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRequerido { get; set; }

    [StringLength(20)]
    public string EstadoOrden { get; set; } = null!;

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<DetalleCredito> DetalleCreditos { get; set; } = new List<DetalleCredito>();

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<DetalleEnvio> DetalleEnvios { get; set; } = new List<DetalleEnvio>();

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    [InverseProperty("IdOrdenNavigation")]
    public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Ordens")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
