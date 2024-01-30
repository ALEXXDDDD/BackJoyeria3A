using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Area", Schema = "Produccion")]
public partial class Area
{
    [Key]
    public int IdArea { get; set; }

    [StringLength(20)]
    public string NombreArea { get; set; } = null!;

    public string? Descripcion { get; set; }

    [InverseProperty("IdAreaNavigation")]
    public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();
}
