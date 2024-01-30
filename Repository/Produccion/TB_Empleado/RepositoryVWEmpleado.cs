using DBZapateriaDLopezModel;
using IRepository;
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
    public class RepositoryVWEmpleado : RepositoryCrud<VwEmpleado>, IRepositoryVWEmpleado
    {
        public ResponseFilterGeneric<VwEmpleado> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
