using DBZapateriaDLopezModel;
using IRepository.Venta.TB_Cliente;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Venta.TB_Cliente
{
    public class RepositoryCliente : RepositoryCrud<Cliente>, IRepositoryCliente
    {
        public ResponseFilterGeneric<Cliente> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}