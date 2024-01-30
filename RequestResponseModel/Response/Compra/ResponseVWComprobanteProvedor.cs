using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Compra
{
    public class ResponseVWComprobanteProvedor
    {
        public string IdComprobante { get; set; } = null!;

        public string NombrePersona { get; set; } = null!;

        public string TipoComprobante { get; set; } = null!;

        public string CodigoComprobante { get; set; } = null!;

        public DateTime FechaEntrega { get; set; }

        public DateTime FechaPedido { get; set; }

        public decimal CosteTransporte { get; set; }

        public int? CantidadTotal { get; set; }

        public decimal? MontoTotal { get; set; }

        public decimal? SubTotal { get; set; }
    }
}
