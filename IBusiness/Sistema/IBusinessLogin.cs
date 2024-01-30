using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Response.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Sistema
{
    public interface IBusinessLogin
    {
        ResponseLogin Login(RequestLogin login);

    }
}
