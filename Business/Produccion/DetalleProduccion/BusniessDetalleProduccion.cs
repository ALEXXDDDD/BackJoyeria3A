using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Produccion.DetalleProduccion;
using IRepository.Produccion.DetalleProduccion;
using Repository.Produccion.DetalleProduccion;
using RequestResponseModel.Request.Produccion.DetalleProduccion;
using RequestResponseModel.Response.Produccion.DetalleProduccion;

namespace Business.Produccion.DetalleProduccion
{
    public class BusniessDetalleProduccion  : IBussniessDetalleProduccion
    {
        #region Declaracion de Variables 
        private readonly IMapper _mapper;
        private readonly IRepositoryDetalleProduccion _repositoryDetalleProduccion;

        public BusniessDetalleProduccion(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryDetalleProduccion = new RepositotyDetalleProduccion();

        }

        public ResponseVwDetalleProduccion Create(RequestVWDetalleProduccion entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVwDetalleProduccion> CreateMultiple(List<RequestVWDetalleProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWDetalleProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVwDetalleProduccion> GetAll()
        {
            List<VwDetalleProduccion> detalleProduccion = _repositoryDetalleProduccion.GetAll();
            List<ResponseVwDetalleProduccion> responseDetalleProduccion = _mapper.Map<List<ResponseVwDetalleProduccion>>(detalleProduccion);
            return responseDetalleProduccion;
        }

        public ResponseVwDetalleProduccion GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVwDetalleProduccion Update(RequestVWDetalleProduccion entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVwDetalleProduccion> UpdateMultiple(List<RequestVWDetalleProduccion> lista)
        {
            throw new NotImplementedException();
        }



        #endregion Fin de la Declaracion de Variables 
    }
}
