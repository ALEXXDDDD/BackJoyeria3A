using AutoMapper;
using Business.Produccion;
using DBZapateriaDLopezModel;
using IBusiness.Compra.TB_Material;
using IBusiness.Produccion;
using IRepository.Compra.TB_Material;
using Repository.Compra.TB_Material;
using RequestResponseModel.Request.Compra.Materiald;
using RequestResponseModel.Response.Compra.Material;
using RequestResponseModel.Response.Produccion;

namespace Business.Compra.TB_Material
{
    public class BusinessMaterial : IBusinessMaterial
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryMaterial _repositoryMaterial;
        private readonly IBusinessVWMaterial _businessVwMaterial;
        private readonly IBusinessUnidad _businessUnidad;
        private readonly IMapper _mapper;
        public BusinessMaterial(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryMaterial = new RepositoryMaterial();
            _businessVwMaterial = new BusinessVWMaterial(mapper);
            _businessUnidad = new BusinessUnidad(mapper);
        }
        #endregion Inyeccion de dependencias
        #region CRUD

        public ResponseListMaterial BuscarMaterial(string nameMaterial)
        {
            Material material = _repositoryMaterial.BuscarMaterial(nameMaterial);
            ResponseListMaterial response = _mapper.Map<ResponseListMaterial>(material);
            return response;
        }
        public ResponseMaterial Create(RequestMaterial entity)
        
        {
            ResponseMaterial response = new();
            response.Material = new List<ResponseVWMaterial>();
            ResponseUnidad unidad = _businessUnidad.BuscarUnidad(entity.NombreUnidad);
            Material material = _mapper.Map<Material>(entity);
            material.IdUnidad = unidad.IdUnidad;
            material = _repositoryMaterial.Create(material);
            ResponseVWMaterial cargar = _mapper.Map<ResponseVWMaterial>(material);
            cargar.NombreUnidad = unidad.NombreUnidad;
            response.Material.Add(cargar);
            response.Message = "Registro Creado";
            return response;
        }

        public List<ResponseMaterial> CreateMultiple(List<RequestMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestMaterial> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseMaterial> GetAll()
        {
            //Declaracion de variables locales
            ResponseMaterial response = new();
            List<ResponseMaterial> respuesta = new();
            response.Material = new List<ResponseVWMaterial>();

            //Cargar Material
            response.Material = _businessVwMaterial.GetAll();
            response.Message = "Lista de registros";
            respuesta.Add(response);
            return respuesta;
        }

        public ResponseMaterial GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseMaterial Update(RequestMaterial entity)
        {
            ResponseMaterial response = new();
            response.Material = new List<ResponseVWMaterial>();
            ResponseUnidad unidad = _businessUnidad.BuscarUnidad(entity.NombreUnidad);
            Material material = _mapper.Map<Material>(entity);
            material.IdUnidad = unidad.IdUnidad;
            material = _repositoryMaterial.Update(material);
            ResponseVWMaterial cargar = _mapper.Map<ResponseVWMaterial>(material);
            cargar.NombreUnidad = unidad.NombreUnidad;
            response.Material.Add(cargar);
            response.Message = "Registro Actualizado";
            return response;
        }

        public List<ResponseMaterial> UpdateMultiple(List<RequestMaterial> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
