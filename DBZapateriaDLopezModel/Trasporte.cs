using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Trasporte", Schema = "Venta")]
public partial class Trasporte
{
    [Key]
    public int IdTrasporte { get; set; }

    public int IdPersona { get; set; }

    [StringLength(20)]
    public string? NumeroPlaca { get; set; }

    [StringLength(50)]
    public string? LicenciaConductor { get; set; }

    [StringLength(50)]
    public string? TipoAutomovil { get; set; }

    [InverseProperty("IdTrasporteNavigation")]
    public virtual ICollection<DetalleEnvio> DetalleEnvios { get; set; } = new List<DetalleEnvio>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Trasportes")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
