using DBZapateriaDLopezModel;
using IRepository.Compra.TB_ComprobanteDetalle;
using RequestResponseModel.Request;
using RequestResponseModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Compra.TB_ComprobanteDetalle
{
    public class RepositoryComprobanteDetalle : RepositoryCrud<ComprobanteDetalle>, IRepositoryComprobanteDetalle
    {
        public ResponseFilterGeneric<ComprobanteDetalle> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
