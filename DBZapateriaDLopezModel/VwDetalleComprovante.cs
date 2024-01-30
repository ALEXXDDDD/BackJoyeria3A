using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwDetalleComprovante
{
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    [StringLength(50)]
    public string? NombreMaterial { get; set; }

    [StringLength(30)]
    public string? NombreUnidad { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }
}
