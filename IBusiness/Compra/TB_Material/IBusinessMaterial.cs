using RequestResponseModel.Request.Compra.Materiald;
using RequestResponseModel.Response.Compra.Material;

namespace IBusiness.Compra.TB_Material
{
    public interface IBusinessMaterial : IBusinessCrud<RequestMaterial, ResponseMaterial>
    {
        public ResponseListMaterial BuscarMaterial(string nameMaterial);
    }
}
