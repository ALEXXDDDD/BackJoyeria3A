using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Produccion.Producto
{
    public class ResponseProducto
    {
        [Key]
        public int IdProducto { get; set; }

        [StringLength(40)]
        public string? NombreProd { get; set; }

        [StringLength(20)]
        public string? CodigoProd { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrecioUnitario { get; set; }

        public int IdUnidad { get; set; }

        public int Stock { get; set; }

        public bool EstadoProducto { get; set; }

        [Column(TypeName = "image")]
        public byte[]? Fotografia { get; set; }

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<DetalleProducto> DetalleProductos { get; set; } = new List<DetalleProducto>();

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("Productos")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();
    }
}
