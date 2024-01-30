using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwHistorial
{
    public int IdHistorial { get; set; }

    [StringLength(30)]
    public string Usuario { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(25)]
    public string NombreRol { get; set; } = null!;

    public string? TableName { get; set; }

    public string? Detalle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }
}
