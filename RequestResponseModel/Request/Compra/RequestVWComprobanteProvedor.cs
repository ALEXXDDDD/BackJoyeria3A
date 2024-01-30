using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Compra
{
    public class RequestVWComprobanteProvedor
    {
        [StringLength(10)]
        public string IdComprobante { get; set; } = null!;

        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        [StringLength(20)]
        public string TipoComprobante { get; set; } = null!;

        [StringLength(20)]
        public string CodigoComprobante { get; set; } = null!;

        public DateTime FechaEntrega { get; set; }

        public DateTime FechaPedido { get; set; }

        public decimal CosteTransporte { get; set; }

        public int? CantidadTotal { get; set; }

        public decimal? MontoTotal { get; set; }

        public decimal? SubTotal { get; set; }
    }
}
