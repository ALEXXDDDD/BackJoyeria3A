using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Request.Producto;
using RequestResponseModel.Response.Produccion.Producto;

namespace IBusiness.Productos
{
    public interface IBussniessProducto : IBusinessCrud<RequestProducto,ResponseProducto>
    {
    }
}
