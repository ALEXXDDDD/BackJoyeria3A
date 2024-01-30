using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwProduccion
{
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [StringLength(30)]
    public string? NombreUnidad { get; set; }

    public int Meta { get; set; }

    public int? CantidadFaltante { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaFinalizacion { get; set; }

    [StringLength(20)]
    public string EstadoProduccion { get; set; } = null!;
}
