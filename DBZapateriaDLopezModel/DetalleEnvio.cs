using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdTrasporte", "IdOrden")]
[Table("DetalleEnvio", Schema = "Venta")]
public partial class DetalleEnvio
{
    [Key]
    public int IdTrasporte { get; set; }

    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnvio { get; set; }

    [StringLength(10)]
    public string? CodigoUbigeo { get; set; }

    [StringLength(50)]
    public string? Direccion { get; set; }

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleEnvios")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdTrasporte")]
    [InverseProperty("DetalleEnvios")]
    public virtual Trasporte IdTrasporteNavigation { get; set; } = null!;
}
