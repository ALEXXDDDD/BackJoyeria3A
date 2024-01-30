using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwCredito
{
    public int IdCredito { get; set; }

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? MontoDeuda { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoPagado { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoTotal { get; set; }

    [StringLength(20)]
    public string? EstadoCredito { get; set; }
}
