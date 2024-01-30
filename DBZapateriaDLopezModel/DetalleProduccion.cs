using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[PrimaryKey("IdProduccion", "IdOrden", "IdArea", "IdEmpleado")]
[Table("DetalleProduccion", Schema = "Produccion")]
public partial class DetalleProduccion
{
    [Key]
    public int IdArea { get; set; }

    [Key]
    [StringLength(10)]
    public string IdProduccion { get; set; } = null!;

    [Key]
    public int IdEmpleado { get; set; }

    [Key]
    [StringLength(10)]
    public string IdOrden { get; set; } = null!;

    public int IdUnidad { get; set; }

    public int CantidadProduccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaFinalizacion { get; set; }

    [StringLength(20)]
    public string Estado { get; set; } = null!;

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [ForeignKey("IdArea")]
    [InverseProperty("DetalleProduccions")]
    public virtual Area IdAreaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpleado")]
    [InverseProperty("DetalleProduccions")]
    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleProduccions")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdProduccion")]
    [InverseProperty("DetalleProduccions")]
    public virtual Produccion IdProduccionNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("DetalleProduccions")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
