using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Compra.TB_ComprobanteDetalle;
using IRepository.Compra.TB_ComprobanteDetalle;
using Repository.Compra.TB_ComprobanteDetalle;
using RequestResponseModel.Request.Compra.ComprobanteDetalle;
using RequestResponseModel.Response.Compra.ComprobanteDetalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Compra.TB_ComprobanteDetalle
{
    public class BusinessComprobanteDetalle : IBusinessComprobanteDetalle
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryComprobanteDetalle _repositoryComprobanteDetalle;
        private readonly IMapper _mapper;
        public BusinessComprobanteDetalle(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryComprobanteDetalle = new RepositoryComprobanteDetalle();
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        public ResponseComprobanteDetalle Create(RequestComprobanteDetalle entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseComprobanteDetalle> CreateMultiple(List<RequestComprobanteDetalle> lista)
        {
            List<ComprobanteDetalle> comprobantedetalle = _mapper.Map<List<ComprobanteDetalle>>(lista);
            comprobantedetalle = _repositoryComprobanteDetalle.CreateMultiple(comprobantedetalle);
            List<ResponseComprobanteDetalle> response = _mapper.Map<List<ResponseComprobanteDetalle>>(comprobantedetalle);
            return response;
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseComprobanteDetalle> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseComprobanteDetalle GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseComprobanteDetalle Update(RequestComprobanteDetalle entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseComprobanteDetalle> UpdateMultiple(List<RequestComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
