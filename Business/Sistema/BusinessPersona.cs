
using AutoMapper;
using DBZapateriaDLopezModel;
using DocumentFormat.OpenXml.Spreadsheet;
using IBusiness.Sistema;
using IRepository.Compra;
using Repository.Compra;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Response.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Sistema
{
    public class BusinessPersona : IBusinessPersona
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryPersona _persona;
        private readonly IMapper _mapper;
        public BusinessPersona(IMapper mapper)
        {
            _mapper = mapper;
            _persona = new RepositoryPersona();
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        public ResponsePersona Create(RequestPersona entity)
        {
            Persona persona = _mapper.Map<Persona>(entity);
            persona = _persona.Create(persona);
            ResponsePersona response = _mapper.Map<ResponsePersona>(persona);
            return response;
        }

        public List<ResponsePersona> CreateMultiple(List<RequestPersona> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestPersona> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponsePersona> GetAll()
        {
           List<Persona> persona = _persona.GetAll();
            List<ResponsePersona> responsePersona = _mapper.Map<List<ResponsePersona>>(persona);
            return responsePersona;
        }


        public ResponsePersona GetById(object id)
        {
            Persona persona = _persona.GetById(id);
            ResponsePersona response = _mapper.Map<ResponsePersona>(persona);
            return response;
        }

        public ResponsePersona Update(RequestPersona entity)
        {
            //Start//
            Persona persona = _mapper.Map<Persona>(entity);
            persona = _persona.Update(persona);
            ResponsePersona response = _mapper.Map<ResponsePersona>(persona);
            return response;
            //End//
        }

        public List<ResponsePersona> UpdateMultiple(List<RequestPersona> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
