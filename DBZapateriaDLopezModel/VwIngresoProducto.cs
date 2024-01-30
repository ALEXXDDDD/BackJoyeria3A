using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwIngresoProducto
{
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [StringLength(40)]
    public string? NombreProd { get; set; }

    [StringLength(30)]
    public string? NombreUnidad { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }
}
