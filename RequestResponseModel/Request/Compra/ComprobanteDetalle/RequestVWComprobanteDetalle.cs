using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Produccion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Compra.ComprobanteDetalle
{
    public class RequestVWComprobanteDetalle
    {
        [StringLength(10)]
        public string IdComprobante { get; set; } = null!;
        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;
        [StringLength(30)]
        public string? NombreUnidad { get; set; } = "";

        public int Cantidad { get; set; } = 0;

        public decimal PrecioUnitario { get; set; } = 0;

        public DateTime? FechaIngreso { get; set; }

    }
}
