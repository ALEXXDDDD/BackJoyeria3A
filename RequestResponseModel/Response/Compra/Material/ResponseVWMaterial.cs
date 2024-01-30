using RequestResponseModel.Response.Produccion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Compra.Material
{
    public class ResponseVWMaterial
    {
        public int IdMaterial { get; set; }
        public string NombreMaterial { get; set; } = null!;
        public string? NombreUnidad { get; set; }
        public int Stock { get; set; }
        public string? Descripcion { get; set; }
        public string? Marca { get; set; }
        public string? Estado { get; set; }
    }
}
