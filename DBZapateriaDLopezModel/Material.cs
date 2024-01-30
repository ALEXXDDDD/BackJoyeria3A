using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Material", Schema = "Compra")]
public partial class Material
{
    [Key]
    public int IdMaterial { get; set; }

    [StringLength(50)]
    public string NombreMaterial { get; set; } = null!;

    public int IdUnidad { get; set; }

    public int Stock { get; set; }

    public string? Descripcion { get; set; }

    [StringLength(50)]
    public string? Marca { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }

    [InverseProperty("IdMaterialNavigation")]
    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    [ForeignKey("IdUnidad")]
    [InverseProperty("Materials")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    [InverseProperty("IdMaterialNavigation")]
    public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
}
