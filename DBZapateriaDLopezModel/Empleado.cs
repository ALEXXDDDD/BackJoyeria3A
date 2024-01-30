using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Empleado", Schema = "Produccion")]
public partial class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }

    public int IdPersona { get; set; }

    [StringLength(30)]
    public string? ApellidoEmp { get; set; }

    [Column(TypeName = "money")]
    public decimal Salario { get; set; }

    public bool Estado { get; set; }

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Empleados")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
