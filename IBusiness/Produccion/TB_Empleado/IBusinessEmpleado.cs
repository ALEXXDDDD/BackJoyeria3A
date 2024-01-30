using RequestResponseModel.Request.Produccion.Empleado;
using RequestResponseModel.Response.Produccion.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Produccion.TB_Empleado
{
    public interface IBusinessEmpleado:IBusinessCrud<RequestEmpleado,ResponseListEmpleado>
    {
    }
}
