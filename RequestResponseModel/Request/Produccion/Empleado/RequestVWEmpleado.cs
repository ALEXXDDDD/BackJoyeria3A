﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Produccion.Empleado
{
    public class RequestVWEmpleado
    {
        public int IdEmpleado { get; set; }
        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;
        [StringLength(30)]
        public string? ApellidoEmp { get; set; }
        [StringLength(30)]
        public string TipoPersona { get; set; } = null!;
        [StringLength(15)]
        public string TipoDocumento { get; set; } = null!;
        [StringLength(20)]
        public string NumeroDocumento { get; set; } = null!;
        [StringLength(15)]
        public string Telefono { get; set; } = null!;
        [StringLength(10)]
        public string? CodigoUbigeo { get; set; }
        [StringLength(50)]
        public string? Direccion { get; set; }
        public decimal Salario { get; set; }
        public bool Estado { get; set; }
    }
}
