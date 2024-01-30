using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwMaterial
{
    public int IdMaterial { get; set; }

    [StringLength(50)]
    public string NombreMaterial { get; set; } = null!;

    [StringLength(30)]
    public string? NombreUnidad { get; set; }

    public int Stock { get; set; }

    public string? Descripcion { get; set; }

    [StringLength(50)]
    public string? Marca { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }
}
