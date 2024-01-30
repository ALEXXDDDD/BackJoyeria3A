using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwDetalleProduccion
{
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [StringLength(20)]
    public string NombreArea { get; set; } = null!;

    [StringLength(81)]
    public string? NombreCompleto { get; set; }

    public int CantidadProduccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaFinalizacion { get; set; }

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [StringLength(20)]
    public string Estado { get; set; } = null!;
}
