using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Producto
{
    public class RequestVWProducto
    {
        public int IdProducto { get; set; }

       
        public string? NombreProd { get; set; }

        
        public string? CodigoProd { get; set; }

   
        public decimal? PrecioUnitario { get; set; }

  
        public string? NombreUnidad { get; set; }

        public int Stock { get; set; }

        public bool EstadoProducto { get; set; }

      
        public byte[]? Fotografia { get; set; }
    }
}
