using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Compra.Material;

namespace RequestResponseModel.Response.Compra.ComprobanteDetalle
{
    public class ResponseVWDetalleComprobante
    {
        public string message { get; set; } = "";
        public List<ResponseListComprobanteDetalle> Detalle {get; set;} = new List<ResponseListComprobanteDetalle>();
    }
}
