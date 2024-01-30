using DBZapateriaDLopezModel;
using IRepository.Produccion.TB_Empleado;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Produccion.TB_Empleado
{
    public class RepositoryEmpleado : RepositoryCrud<Empleado>, IRepositoryEmpleado
    {
        public ResponseFilterGeneric<Empleado> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
