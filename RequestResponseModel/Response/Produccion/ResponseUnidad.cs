using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Produccion
{
    public class ResponseUnidad
    {
        public int IdUnidad { get; set; }

        public string? NombreUnidad { get; set; }

        public string? Descriccion { get; set; }

        //public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

        //public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

        //public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();

        //public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

        //public virtual ICollection<Produccion> Produccions { get; set; } = new List<Produccion>();

        //public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

        //public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
    }
}
