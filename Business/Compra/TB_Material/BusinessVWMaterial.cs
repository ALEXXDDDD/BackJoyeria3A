using AutoMapper;
using Business.Produccion;
using DBZapateriaDLopezModel;
using IBusiness.Compra.TB_Material;
using IRepository.Compra.TB_Material;
using Repository.Compra.TB_Material;
using RequestResponseModel.Request.Compra.Material;
using RequestResponseModel.Response.Compra.Material;

namespace Business.Compra.TB_Material
{
    public class BusinessVWMaterial : IBusinessVWMaterial
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryVWMaterial _repositoryVWMaterial;
        private readonly IMapper _mapper;
        public BusinessVWMaterial(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryVWMaterial = new RepositoryVWMaterial();
        }
        #endregion Inyeccion de dependencia

        #region CRUD
        public ResponseVWMaterial Create(RequestVWMaterial entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWMaterial> CreateMultiple(List<RequestVWMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWMaterial> GetAll()
        {
            List<VwMaterial> materials = _repositoryVWMaterial.GetAll();
            List<ResponseVWMaterial> response = _mapper.Map<List<ResponseVWMaterial>>(materials);
            return response;
        }

        public ResponseVWMaterial GetById(object id)
        {
            throw new NotImplementedException();
        }

        public List<RequestVWMaterial> MostrarMaterial()
        {
            throw new NotImplementedException();
        }

        public ResponseVWMaterial Update(RequestVWMaterial entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWMaterial> UpdateMultiple(List<RequestVWMaterial> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
