using DBZapateriaDLopezModel;
using IRepository.Compra.TB_Material;
using RequestResponseModel.Request;
using RequestResponseModel.Response;

namespace Repository.Compra.TB_Material
{
    public class RepositoryMaterial : RepositoryCrud<Material>, IRepositoryMaterial
    {
        public Material BuscarMaterial(string nameMaterial)
        {
            Material? material = db.Materials.Where(x=> x.NombreMaterial == nameMaterial).FirstOrDefault();
            return material;
        }

        public ResponseFilterGeneric<Material> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
