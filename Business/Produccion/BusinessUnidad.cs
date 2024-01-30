using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Produccion;
using IRepository.Produccion;
using Repository.Produccion;
using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Response.Produccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Produccion
{
    public class BusinessUnidad : IBusinessUnidad
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryUnidad _repositoryUnidad;
        private readonly IMapper _mapper;
        public BusinessUnidad (IMapper mapper)
        {
            _mapper = mapper;
            _repositoryUnidad = new RepositoryUnidad();
        }
        #endregion Inyeccion de dependencias

        #region CRUD
        public ResponseUnidad BuscarUnidad(string nombreUnidad)
        {
            Unidad unidad = _repositoryUnidad.BuscarNombre(nombreUnidad);
            ResponseUnidad response = _mapper.Map<ResponseUnidad>(unidad);
            return response;
        }
        public ResponseUnidad Create(RequestUnidad entity)
        {
            Unidad unidad = _mapper.Map<Unidad>(entity);
            unidad = _repositoryUnidad.Create(unidad);
            ResponseUnidad response = _mapper.Map<ResponseUnidad>(unidad);
            return response;
        }

        public List<ResponseUnidad> CreateMultiple(List<RequestUnidad> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestUnidad> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseUnidad> GetAll()
        {
            List<Unidad> unidad = _repositoryUnidad.GetAll();
            List<ResponseUnidad> response = _mapper.Map<List<ResponseUnidad>>(unidad);
            return response;
        }

        public ResponseUnidad GetById(object id)
        {
            Unidad unidad = _repositoryUnidad.GetById(id);
            ResponseUnidad response = _mapper.Map<ResponseUnidad>(unidad);
            return response;
        }

        public ResponseUnidad Update(RequestUnidad entity)
        {
            Unidad unidad = _mapper.Map<Unidad>(entity);
            unidad = _repositoryUnidad.Update(unidad);
            ResponseUnidad response = _mapper.Map<ResponseUnidad>(unidad);
            return response;
        }

        public List<ResponseUnidad> UpdateMultiple(List<RequestUnidad> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
