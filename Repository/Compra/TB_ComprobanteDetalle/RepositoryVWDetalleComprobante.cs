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
    public class RepositoryVWDetalleComprobante : RepositoryCrud<VwDetalleComprovante>, IRepositoryVWDetalleComprobante
    {
        public ResponseFilterGeneric<VwDetalleComprovante> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
