using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Compra.ComprobanteDetalle
{
    public class RequestComprobanteDetalle
    {
        [StringLength(10)]
        public string IdComprobante { get; set; } = null!;

        public int IdMaterial { get; set; }

        public int IdUnidad { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public DateTime? FechaIngreso { get; set; }

        //public virtual ComprobanteProvedor IdComprobanteNavigation { get; set; } = null!;

        //public virtual Material IdMaterialNavigation { get; set; } = null!;

        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    }
}
