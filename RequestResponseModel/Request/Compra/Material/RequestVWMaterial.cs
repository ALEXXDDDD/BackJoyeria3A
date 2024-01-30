using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Compra.Material
{
    public class RequestVWMaterial
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
}
