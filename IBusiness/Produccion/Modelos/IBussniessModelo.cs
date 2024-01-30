using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Request.Produccion.Modelo;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Produccion.Modelo;

namespace IBusiness.Produccion.Modelos
{
    public interface IBussniessModelo : IBusinessCrud<RequestModelo, ResponseModelo>
    {
    }
}
