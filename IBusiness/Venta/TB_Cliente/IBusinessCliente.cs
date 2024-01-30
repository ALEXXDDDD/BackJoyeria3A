using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Request.Venta.Cliente;
using RequestResponseModel.Response.Venta.Cliente;

namespace IBusiness.Venta.TB_Cliente
{
    public interface IBusinessCliente:IBusinessCrud<RequestUsuario,ResponseCliente>
    {
    }
}