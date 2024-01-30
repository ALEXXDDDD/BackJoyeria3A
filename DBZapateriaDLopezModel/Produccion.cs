using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Produccion", Schema = "Produccion")]
public partial class Produccion
{
    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    public int IdUnidad { get; set; }

    public int Meta { get; set; }

    public int? CantidadFaltante { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaFinalizacion { get; set; }

    [StringLength(20)]
    public string EstadoProduccion { get; set; } = null!;

    [InverseProperty("IdProduccionNavigation")]
    public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

    [ForeignKey("IdUnidad")]
    [InverseProperty("Produccions")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    [InverseProperty("IdProduccionNavigation")]
    public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();

    [InverseProperty("IdProduccionNavigation")]
    public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
}
