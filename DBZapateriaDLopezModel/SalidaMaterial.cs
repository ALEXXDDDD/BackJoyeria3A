using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdMaterial", "IdProduccion")]
[Table("SalidaMaterial", Schema = "Produccion")]
public partial class SalidaMaterial
{
    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [Key]
    public int IdMaterial { get; set; }

    public int IdUnidad { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaSalida { get; set; }

    [ForeignKey("IdMaterial")]
    [InverseProperty("SalidaMaterials")]
    public virtual Material IdMaterialNavigation { get; set; } = null!;

    [ForeignKey("IdProduccion")]
    [InverseProperty("SalidaMaterials")]
    public virtual Produccion IdProduccionNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("SalidaMaterials")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
