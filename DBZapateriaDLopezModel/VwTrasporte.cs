using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwTrasporte
{
    public int IdTrasporte { get; set; }

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(30)]
    public string TipoPersona { get; set; } = null!;

    [StringLength(15)]
    public string TipoDocumento { get; set; } = null!;

    [StringLength(20)]
    public string NumeroDocumento { get; set; } = null!;

    [StringLength(15)]
    public string Telefono { get; set; } = null!;

    [StringLength(10)]
    public string? CodigoUbigeo { get; set; }

    [StringLength(50)]
    public string? Direccion { get; set; }

    [StringLength(20)]
    public string? NumeroPlaca { get; set; }

    [StringLength(50)]
    public string? LicenciaConductor { get; set; }

    [StringLength(50)]
    public string? TipoAutomovil { get; set; }
}
