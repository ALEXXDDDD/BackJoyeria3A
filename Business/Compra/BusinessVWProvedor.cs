using AutoMapper;
using Business.Sistema;
using DBZapateriaDLopezModel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using IBusiness.Compra;
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

namespace Business.Compra
{
    public class BusinessVWProvedor : IBusinessVWProvedor
    {
        #region Inyeccion de dependencias

        private readonly IRepositorVWProvedor _repositoryVWProvedor;
        private readonly IBusinessPersona _businessPersona;
        private readonly IRepositoryProvedor _repositoryProvedor;
        private readonly IMapper _mapper;
        public BusinessVWProvedor(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryVWProvedor = new RepositoryVWProvedor();
            _businessPersona = new BusinessPersona(mapper);
            _repositoryProvedor = new RepositoryProvedor();
        }

        #endregion Inyeccion de dependencias
        #region CRUD

        public ResponseProvedor Create(RequestVWProvedor entity)
        {
            //Start Variable locales//
            ResponseProvedor VWProvedor = new();
            Provedor provedor = new();
            VWProvedor.Persona = new();
            //End Variable Locales//
           
            //Start Crear Persona//
            RequestPersona persona = _mapper.Map<RequestPersona>(entity);
            if (persona == null)
            {
                VWProvedor.Message = "Los Datos no son validos";
                return VWProvedor;
            }
            VWProvedor.Persona = _businessPersona.Create(persona);
            //End Crear Persona//

            //Start Crear Proveedor//
            if (VWProvedor.Persona.IdPersona == 0)
            {
                VWProvedor.Message = "Persona Registra Pero No EL Provedor";
                return VWProvedor;
            }
                
            provedor.IdPersona = VWProvedor.Persona.IdPersona;
            provedor = _repositoryProvedor.Create(provedor);
            //End Crear Proveedro//

            //Start Cargar Resultado//
            VWProvedor.Message = "Registro de Provedor";
            VWProvedor.IdProvedor = provedor.IdProvedor;
            //End Cargar Resultado//

            return VWProvedor;
        }

        public List<ResponseProvedor> CreateMultiple(List<RequestVWProvedor> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWProvedor> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseProvedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseProvedor GetById(object id)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWProvedor> MostrarProvedor()
        {
            List<VwProveedor> provedor = _repositoryVWProvedor.GetAll();
            List<ResponseVWProvedor> response = _mapper.Map<List<ResponseVWProvedor>>(provedor);
            return response;
        }

        public ResponseProvedor Update(RequestVWProvedor entity)
        {
            //Start Variable Locales//
            ResponseProvedor vwprovedor = new();
            vwprovedor.Persona = new();
            //End Variables Locales//

            //Start Buscar Provedor//
            Provedor provedor = _repositoryProvedor.GetById(entity.IdProvedor);
            if(provedor == null)
            {
                vwprovedor.Message = "No se encontro el Provedor";
                return vwprovedor;
            }
            //End Buscar Provedor//

            //Start Cargar Persona//
            vwprovedor.Persona = _mapper.Map<ResponsePersona>(entity);
            vwprovedor.Persona.IdPersona = provedor.IdPersona;
            RequestPersona request = _mapper.Map<RequestPersona>(vwprovedor.Persona);
            //End Cargar Persona//

            //Start Actulizar Persona//
            vwprovedor.Persona = _businessPersona.Update(request);
            vwprovedor.Message = "Se Actualizo correctamente el provedor";
            vwprovedor.IdProvedor = entity.IdProvedor;
            return vwprovedor;
            //End Actualizar Persona//
           
        }

        public List<ResponseProvedor> UpdateMultiple(List<RequestVWProvedor> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
