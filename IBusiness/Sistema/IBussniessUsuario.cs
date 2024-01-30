using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Response.Sistema;

namespace IBusiness.Sistema
{
    public interface IBussniessUsuario : IBusinessCrud<RequestVWUsuario,ResponseVWUsuario>
    {
        
    }
}
