using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Produccion.TB_Empleado;
using IRepository.Produccion.TB_Empleado;
using Repository.Produccion.TB_Empleado;
using RequestResponseModel.Request.Produccion.Empleado;
using RequestResponseModel.Response.Produccion.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Produccion.TB_Empleado
{
    public class BusinessEmpleado : IBusinessEmpleado
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryEmpleado _repositoryEmpleado;
        private readonly IMapper _mapper;
        public BusinessEmpleado(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryEmpleado = new RepositoryEmpleado();
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public ResponseListEmpleado Create(RequestEmpleado entity)
        {
            Empleado empleado = _mapper.Map<Empleado>(entity);
            empleado = _repositoryEmpleado.Create(empleado);
            ResponseListEmpleado response = _mapper.Map<ResponseListEmpleado>(empleado);
            return response;
        }

        public List<ResponseListEmpleado> CreateMultiple(List<RequestEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestEmpleado> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseListEmpleado> GetAll()
        {

            throw new NotImplementedException();
        }

        public ResponseListEmpleado GetById(object id)
        {

            Empleado empleado =_repositoryEmpleado.GetById(id);
            ResponseListEmpleado response = _mapper.Map<ResponseListEmpleado>(empleado);
            return response;
        }

        public ResponseListEmpleado Update(RequestEmpleado entity)
        {
            Empleado empleado = _mapper.Map<Empleado>(entity);
            empleado = _repositoryEmpleado.Update(empleado);
            ResponseListEmpleado response = _mapper.Map<ResponseListEmpleado>(empleado);
            return response;
        }

        public List<ResponseListEmpleado> UpdateMultiple(List<RequestEmpleado> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}
