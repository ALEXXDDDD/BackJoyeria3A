﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBZapateriaDLopezModel;

[Table("Rol", Schema = "Sistema")]
public partial class Rol
{
    [Key]
    [Column("IRol")]
    public int Irol { get; set; }

    [StringLength(25)]
    public string NombreRol { get; set; } = null!;

    public string? Descripción { get; set; }
    [InverseProperty("IrolNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
