using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwComprobanteProvedor
{
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(20)]
    public string TipoComprobante { get; set; } = null!;

    [StringLength(20)]
    public string CodigoComprobante { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaEntrega { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaPedido { get; set; }

    [Column(TypeName = "money")]
    public decimal CosteTransporte { get; set; }

    public int? CantidadTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? SubTotal { get; set; }
}
