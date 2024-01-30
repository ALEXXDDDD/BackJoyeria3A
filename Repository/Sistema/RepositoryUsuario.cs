using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBZapateriaDLopezModel;
using IRepository.Sistema;
using IRepository.Venta;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Sistema
{
    public class RepositoryUsuario : RepositoryCrud<Usuario>, IRepositoryUsuario
    {
        public ResponseFilterGeneric<Usuario> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
