using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Produccion.Empleado
{
    public class ResponseEmpleado
    {
        public string Message { get; set; } = "";
        public List<ResponseVWEmpleado> Empleado { get; set; } = new List<ResponseVWEmpleado>();
    }
}
