using DBZapateriaDLopezModel;
using IRepository.Compra.TB_Material;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Compra.TB_Material
{
    public class RepositoryVWMaterial : RepositoryCrud<VwMaterial>, IRepositoryVWMaterial
    {
        public ResponseFilterGeneric<VwMaterial> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
