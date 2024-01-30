using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Credito", Schema = "Venta")]
public partial class Credito
{
    public int IdCliente { get; set; }

    [Key]
    public int IdCredito { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoPagado { get; set; }

    [Column(TypeName = "money")]
    public decimal? MontoDeuda { get; set; }

    [StringLength(20)]
    public string? EstadoCredito { get; set; }

    [InverseProperty("IdCreditoNavigation")]
    public virtual ICollection<DetalleCredito> DetalleCreditos { get; set; } = new List<DetalleCredito>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Creditos")]
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
