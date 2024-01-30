using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwOrden
{
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    public bool TipoOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRequerido { get; set; }

    [StringLength(20)]
    public string EstadoOrden { get; set; } = null!;
}
