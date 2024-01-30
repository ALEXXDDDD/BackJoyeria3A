using AutoMapper;
using Business.Sistema;
using DBZapateriaDLopezModel;
using DocumentFormat.OpenXml.Drawing;
using IBusiness;
using IBusiness.Produccion.TB_Empleado;
using IBusiness.Sistema;
using IRepository.Compra;
using IRepository.Produccion.TB_Empleado;
using Repository.Compra;
using Repository.Produccion.TB_Empleado;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Request.Produccion.Empleado;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Produccion.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Business.Produccion.TB_Empleado
{
    public class BusinessVWEmpleado : IBusinessVWEmpleado
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryVWEmpleado _repositoryVWEmpleado;
        private readonly IBusinessEmpleado _businessEmpleado;
        private readonly IBusinessPersona _businessPersona;
        private readonly IRepositoryPersona _repositoryPersona;
        private readonly IMapper _mapper;
        public BusinessVWEmpleado(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryVWEmpleado = new RepositoryVWEmpleado();
            _repositoryPersona = new RepositoryPersona();
            _businessEmpleado = new BusinessEmpleado(mapper);
            _businessPersona = new BusinessPersona(mapper);
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public ResponseEmpleado Create(RequestVWEmpleado entity)
        {
            // Declaracion de varibles locales
            ResponseVWEmpleado resVW = new ResponseVWEmpleado();
            ResponseListEmpleado list = new();
            ResponseEmpleado response = new();
            response.Empleado = new List<ResponseVWEmpleado>();
            RequestPersona reqPersonsa = new();
            ResponsePersona resPersona = new();
            RequestEmpleado reqEmpleado = new();
            // Declaracion de variables temporales
            
            //Creacion de una Persona
            response.Empleado = new List<ResponseVWEmpleado>();
            reqPersonsa = _mapper.Map<RequestPersona>(entity);
            resPersona = _businessPersona.Create(reqPersonsa);

            //Creacion del empleado
            reqEmpleado = _mapper.Map<RequestEmpleado>(entity);
            reqEmpleado.IdPersona = resPersona.IdPersona;
            list = _businessEmpleado.Create(reqEmpleado);

            //Carga de datos a la respuesta
            resVW = _mapper.Map<ResponseVWEmpleado>(resPersona);
            resVW.IdEmpleado= list.IdEmpleado;
            resVW.ApellidoEmp = list.ApellidoEmp;
            resVW.Salario = list.Salario;
            resVW.Estado = list.Estado;
            response.Message = "Empleado fue exitosamente registrado";
            response.Empleado.Add(resVW);
            return response;
        }

        public List<ResponseEmpleado> CreateMultiple(List<RequestVWEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseEmpleado> GetAll()
        {
            List<ResponseEmpleado> respuesta = new List<ResponseEmpleado>();
            List<VwEmpleado> empleado = new List<VwEmpleado>();
            ResponseEmpleado response = new();
            response.Empleado = new List<ResponseVWEmpleado>();

            empleado = _repositoryVWEmpleado.GetAll();
            response.Empleado = _mapper.Map<List<ResponseVWEmpleado>>(empleado);
            response.Message = "Lista de Registros";
            respuesta.Add(response);

            return respuesta;
        }

        public ResponseEmpleado GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseEmpleado Update(RequestVWEmpleado entity)
        {
            //Declaracion de variables
            ResponseVWEmpleado resVW = new ResponseVWEmpleado();
            ResponseListEmpleado list = new();
            ResponseEmpleado response = new();
            response.Empleado = new List<ResponseVWEmpleado>();
            RequestPersona reqPersonsa = new();
            ResponsePersona resPersona = new();
            RequestEmpleado reqEmpleado = new();

            //Busqueda de Id
            list =_businessEmpleado.GetById(entity.IdEmpleado);
            reqPersonsa = _mapper.Map<RequestPersona>(entity);
            reqPersonsa.IdPersona = list.IdPersona;
            resPersona = _businessPersona.Update(reqPersonsa);
            resVW = _mapper.Map<ResponseVWEmpleado>(resPersona);
            resVW.IdEmpleado = entity.IdEmpleado;
            resVW.Salario = entity.Salario;
            resVW.ApellidoEmp = entity.ApellidoEmp;
            resVW.Estado = entity.Estado;
            response.Empleado.Add(resVW);
            return response;
        }

        public List<ResponseEmpleado> UpdateMultiple(List<RequestVWEmpleado> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}
