using RequestResponseModel.Request.Produccion.Area;
using RequestResponseModel.Response.Produccion.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Produccion.TB_Area
{
    public interface IBusinessArea:IBusinessCrud<RequestArea,ResponseArea>
    {
    }
}
