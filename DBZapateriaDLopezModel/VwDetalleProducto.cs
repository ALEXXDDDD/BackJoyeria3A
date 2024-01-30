using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Keyless]
public partial class VwDetalleProducto
{
    [StringLength(30)]
    public string? NombreModelo { get; set; }

    [StringLength(40)]
    public string? NombreProd { get; set; }

    [StringLength(15)]
    public string? Color { get; set; }

    [StringLength(20)]
    public string? Categoria { get; set; }

    [StringLength(5)]
    public string Talla { get; set; } = null!;

    [StringLength(30)]
    public string? Material { get; set; }

    public string? Descripcion { get; set; }
}
