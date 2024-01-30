using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwProducto
{
    public int IdProducto { get; set; }

    [StringLength(40)]
    public string? NombreProd { get; set; }

    [StringLength(20)]
    public string? CodigoProd { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrecioUnitario { get; set; }

    [StringLength(30)]
    public string? NombreUnidad { get; set; }

    public int Stock { get; set; }

    public bool EstadoProducto { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Fotografia { get; set; }
}
