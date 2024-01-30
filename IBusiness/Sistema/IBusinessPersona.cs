using RequestResponseModel.Request.Compra;
using RequestResponseModel.Response.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Sistema
{
    public interface IBusinessPersona:IBusinessCrud<RequestPersona,ResponsePersona>
    {
    }
}
