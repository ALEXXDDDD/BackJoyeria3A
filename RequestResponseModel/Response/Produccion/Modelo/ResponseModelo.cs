using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Produccion.Modelo
{
    public class ResponseModelo
    {
        public string? IdModelo { get; set; } = null;
        public string? NombreModelo { get; set; }
        public string? CodigoModelo { get; set; }
        public string? Descripcion { get; set; }

        //[InverseProperty("IdModeloNavigation")]
        //public virtual ICollection<DetalleProducto> DetalleProductos { get; set; } = new List<DetalleProducto>();
    }
}
