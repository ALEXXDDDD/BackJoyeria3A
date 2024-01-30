using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Produccion.Area
{
    public class RequestArea
    {
        public int IdArea { get; set; }
        [StringLength(20)]
        public string NombreArea { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
