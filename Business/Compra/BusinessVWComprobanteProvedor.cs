using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Compra;
using IRepository.Compra;
using Repository;
using Repository.Compra;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Response.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Compra
{
    public class BusinessVWComprobanteProvedor : IBusinessVWComprobanteProvedor
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryVWComprobanteProvedor _repositoryVWComprobanteProvedor;
        private readonly IRepositoryProvedor _repositoryProvedor;
        private readonly IRepositoryPersona _repositoryPersona;
        private readonly IRepositoryComprobanteProvedor _repositoryComprobanteProvedor;
        private readonly IMapper _mapper;
        public BusinessVWComprobanteProvedor(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryVWComprobanteProvedor = new RepositoryVWComprobanteProvedor();
            _repositoryComprobanteProvedor = new RepositoryComprobanteProvedor();
            _repositoryProvedor = new RepositoryProvedor();
            _repositoryPersona = new RepositoryPersona();
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        public ResponseVWComprobanteProvedor Create(RequestVWComprobanteProvedor entity)
        {
            var total = GetAll().Count;
            total++;
            entity.IdComprobante = (total <= 0)? "C"+1:"C"+total;
            Persona persona = _repositoryPersona.BuscarId(entity.NombrePersona);
            Provedor provedor = _repositoryProvedor.BuscarId(persona.IdPersona);
            ComprobanteProvedor comprobanteProvedor = _mapper.Map<ComprobanteProvedor>(entity);
            comprobanteProvedor.IdProvedor = provedor.IdProvedor;
            comprobanteProvedor = _repositoryComprobanteProvedor.Create(comprobanteProvedor);
            ResponseVWComprobanteProvedor response = _mapper.Map<ResponseVWComprobanteProvedor>(comprobanteProvedor);
            response.NombrePersona = persona.NombrePersona;
            return response;
        }

        public List<ResponseVWComprobanteProvedor> CreateMultiple(List<RequestVWComprobanteProvedor> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWComprobanteProvedor> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWComprobanteProvedor> GetAll()
        {
            List<VwComprobanteProvedor> comprobanteProvedors = _repositoryVWComprobanteProvedor.GetAll();
            List<ResponseVWComprobanteProvedor> response = _mapper.Map<List<ResponseVWComprobanteProvedor>>(comprobanteProvedors);
            return response;
        }

        public ResponseVWComprobanteProvedor GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVWComprobanteProvedor Update(RequestVWComprobanteProvedor entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWComprobanteProvedor> UpdateMultiple(List<RequestVWComprobanteProvedor> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
