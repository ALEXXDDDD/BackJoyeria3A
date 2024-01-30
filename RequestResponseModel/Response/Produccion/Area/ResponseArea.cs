using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Produccion.Area
{
    public class ResponseArea
    {
        public int IdArea { get; set; }
        public string NombreArea { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
