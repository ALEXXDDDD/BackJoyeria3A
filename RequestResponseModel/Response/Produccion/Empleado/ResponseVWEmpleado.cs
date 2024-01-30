using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Produccion.Empleado
{ 
    public class ResponseVWEmpleado
    {
        public int IdEmpleado { get; set; }
        public string NombrePersona { get; set; } = null!;
        public string? ApellidoEmp { get; set; }
        public string TipoPersona { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NumeroDocumento { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string? CodigoUbigeo { get; set; }
        public string? Direccion { get; set; }
        public decimal Salario { get; set; }
        public bool Estado { get; set; }
    }
}
