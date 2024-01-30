using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdOrden", "IdProducto", "Talla")]
[Table("DetalleOrden", Schema = "Venta")]
public partial class DetalleOrden
{
    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [Key]
    public int IdProducto { get; set; }

    public int IdUnidad { get; set; }

    public int Cantidad { get; set; }

    [Key]
    [StringLength(5)]
    public string Talla { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleOrdens")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleOrdens")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("DetalleOrdens")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
