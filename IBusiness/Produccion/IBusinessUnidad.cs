using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Produccion
{
    public interface IBusinessUnidad:IBusinessCrud<RequestUnidad,ResponseUnidad>
    {
        public ResponseUnidad BuscarUnidad(string nombreUnidad);
    }
}
