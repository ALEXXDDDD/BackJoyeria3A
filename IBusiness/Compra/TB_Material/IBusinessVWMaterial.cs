using RequestResponseModel.Request.Compra.Material;
using RequestResponseModel.Response.Compra.Material;

namespace IBusiness.Compra.TB_Material
{
    public interface IBusinessVWMaterial : IBusinessCrud<RequestVWMaterial, ResponseVWMaterial>
    {
        public List<RequestVWMaterial> MostrarMaterial();
    }
}
