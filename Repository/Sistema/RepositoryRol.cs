using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBZapateriaDLopezModel;
using IRepository.Sistema;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Sistema
{
    public class RepositoryRol : RepositoryCrud<Rol>, IRepositoryRol
    {
        public ResponseFilterGeneric<Rol> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
