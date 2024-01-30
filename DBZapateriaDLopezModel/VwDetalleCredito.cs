using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwDetalleCredito
{
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal MontoAmortizacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaAmortizacion { get; set; }

    [StringLength(50)]
    public string PersonaAmortiza { get; set; } = null!;

    [StringLength(50)]
    public string? RelacionCliente { get; set; }
}
