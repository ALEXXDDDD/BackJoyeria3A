using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("ComprobanteProvedor", Schema = "Compra")]
public partial class ComprobanteProvedor
{
    [Key]
    [StringLength(10)]
    public string IdComprobante { get; set; } = null!;

    public int IdProvedor { get; set; }

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
    public decimal? SubTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoTotal { get; set; }

    [InverseProperty("IdComprobanteNavigation")]
    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    [ForeignKey("IdProvedor")]
    [InverseProperty("ComprobanteProvedors")]
    public virtual Provedor IdProvedorNavigation { get; set; } = null!;
}
