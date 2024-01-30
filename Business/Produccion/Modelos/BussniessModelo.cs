using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Produccion.Modelos;
using IRepository.Produccion;
using IRepository.Produccion.Modelos;
using Repository.Produccion;
using Repository.Produccion.Modelos;
using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Request.Produccion.Modelo;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Produccion.Modelo;

namespace Business.Produccion.Modelos
{
    public class BussniessModelo :IBussniessModelo   
    {
        #region Inyeccion de dependencias
        private readonly IReqpositoryModelo _repositoryModelo;
        private readonly IMapper _mapper;
        public BussniessModelo(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryModelo = new RepositoryModelo();
        }
        #endregion Inyeccion de dependencias

        #region CRUD
        
        public ResponseModelo Create(RequestModelo entity)
        {
            Modelo Modelo = _mapper.Map<Modelo>(entity);
            Modelo = _repositoryModelo.Create(Modelo);
            ResponseModelo response = _mapper.Map<ResponseModelo>(Modelo);
            return response;
        }

        public List<ResponseModelo> CreateMultiple(List<RequestModelo> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestModelo> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseModelo> GetAll()
        {
            List<Modelo> Modelo = _repositoryModelo.GetAll();
            List<ResponseModelo> response = _mapper.Map<List<ResponseModelo>>(Modelo);
            return response;
        }

        public ResponseModelo GetById(object id)
        {
            Modelo Modelo = _repositoryModelo.GetById(id);
            ResponseModelo response = _mapper.Map<ResponseModelo>(Modelo);
            return response;
        }

        public ResponseModelo Update(RequestModelo entity)
        {
            Modelo Modelo = _mapper.Map<Modelo>(entity);
            Modelo = _repositoryModelo.Update(Modelo);
            ResponseModelo response = _mapper.Map<ResponseModelo>(Modelo);
            return response;
        }

        public List<ResponseModelo> UpdateMultiple(List<RequestModelo> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
