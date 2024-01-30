using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwDetalleOrden
{
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [StringLength(40)]
    public string? NombreProd { get; set; }

    [StringLength(30)]
    public string? NombreUnidad { get; set; }

    public int Cantidad { get; set; }

    [StringLength(5)]
    public string Talla { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }
}
