using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdOrden", "IdCredito")]
[Table("DetalleCredito", Schema = "Venta")]
public partial class DetalleCredito
{
    [Key]
    public int IdCredito { get; set; }

    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal MontoAmortizacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaAmortizacion { get; set; }

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(50)]
    public string? RelacionCliente { get; set; }

    [ForeignKey("IdCredito")]
    [InverseProperty("DetalleCreditos")]
    public virtual Credito IdCreditoNavigation { get; set; } = null!;

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleCreditos")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;
}
