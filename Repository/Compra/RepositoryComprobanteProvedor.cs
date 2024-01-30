using DBZapateriaDLopezModel;
using IRepository.Compra;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Compra
{
    public class RepositoryComprobanteProvedor : RepositoryCrud<ComprobanteProvedor>, IRepositoryComprobanteProvedor
    {
        public ResponseFilterGeneric<ComprobanteProvedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
