using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Modelo", Schema = "Venta")]
public partial class Modelo
{
    [Key]
    [StringLength(10)]
    public string IdModelo { get; set; } = null!;

    [StringLength(30)]
    public string? NombreModelo { get; set; }

    [StringLength(10)]
    public string? CodigoModelo { get; set; }

    [StringLength(100)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdModeloNavigation")]
    public virtual ICollection<DetalleProducto> DetalleProductos { get; set; } = new List<DetalleProducto>();
}
