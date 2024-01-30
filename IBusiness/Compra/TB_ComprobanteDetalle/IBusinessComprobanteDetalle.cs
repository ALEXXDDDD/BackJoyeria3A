using RequestResponseModel.Request.Compra.ComprobanteDetalle;
using RequestResponseModel.Response.Compra.ComprobanteDetalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Compra.TB_ComprobanteDetalle
{
    public interface IBusinessComprobanteDetalle:IBusinessCrud<RequestComprobanteDetalle,ResponseComprobanteDetalle>
    {
    }
}
