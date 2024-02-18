using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Request.Produccion.DetalleProduccion;
using RequestResponseModel.Response.Produccion.DetalleProduccion;

namespace IBusiness.Produccion.DetalleProduccion
{
    public interface IBussniessDetalleProduccion : IBusinessCrud<RequestVWDetalleProduccion, ResponseVwDetalleProduccion>
    {
    }
}
