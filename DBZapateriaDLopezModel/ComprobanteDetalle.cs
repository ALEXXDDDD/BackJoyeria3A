using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdComprobante", "IdMaterial")]
[Table("ComprobanteDetalle", Schema = "Compra")]
public partial class ComprobanteDetalle
{
    [Key]
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    [Key]
    public int IdMaterial { get; set; }

    public int IdUnidad { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }

    [ForeignKey("IdComprobante")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual ComprobanteProvedor IdComprobanteNavigation { get; set; } = null!;

    [ForeignKey("IdMaterial")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual Material IdMaterialNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
