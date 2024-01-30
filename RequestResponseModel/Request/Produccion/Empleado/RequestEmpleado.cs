using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Produccion.Empleado
{
    public class RequestEmpleado
    {
        public int IdEmpleado { get; set; }
        public int IdPersona { get; set; }
        [StringLength(30)]
        public string? ApellidoEmp { get; set; }
        public decimal Salario { get; set; }
        public bool Estado { get; set; }
    }
}
