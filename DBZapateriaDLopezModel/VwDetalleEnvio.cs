using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwDetalleEnvio
{
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnvio { get; set; }

    [StringLength(10)]
    public string? CodigoUbigeo { get; set; }

    [StringLength(50)]
    public string? Direccion { get; set; }
}
