using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdModelo", "IdProducto", "Talla")]
[Table("DetalleProducto", Schema = "Venta")]
public partial class DetalleProducto
{
    [Key]
    [StringLength(10)]
    public string IdModelo { get; set; } = null!;

    [Key]
    public int IdProducto { get; set; }

    [Key]
    [StringLength(5)]
    public string Talla { get; set; } = null!;

    [StringLength(15)]
    public string? Color { get; set; }

    [StringLength(20)]
    public string? Categoria { get; set; }

    [StringLength(30)]
    public string? Material { get; set; }

    public string? Descripcion { get; set; }

    [ForeignKey("IdModelo")]
    [InverseProperty("DetalleProductos")]
    public virtual Modelo IdModeloNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleProductos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
