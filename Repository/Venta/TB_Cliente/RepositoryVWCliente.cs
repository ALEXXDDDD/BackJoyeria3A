using DBZapateriaDLopezModel;
using IRepository.Venta.TB_Cliente;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Venta.TB_Cliente
{
    public class RepositoryVWCliente : RepositoryCrud<VwCliente>, IRepositoryVWCliente
    {
        public ResponseFilterGeneric<VwCliente> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}