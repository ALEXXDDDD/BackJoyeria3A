using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness;
using IBusiness.Sistema;
using IRepository.Compra;
using IRepository.Sistema;
using Repository.Compra;
using Repository.Sistema;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Sistema;

namespace Business.Sistema
{
    public class BussniessRol : IBussniessRol
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryRol _Rol;
        private readonly IMapper _mapper;
        public BussniessRol(IMapper mapper)
        {
            _mapper = mapper;
            _Rol = new RepositoryRol();
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        public ResponseRol Create(RequestRol entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _Rol.Create(Rol);
            ResponseRol response = _mapper.Map<ResponseRol>(Rol);
            return response;
        }

        public List<ResponseRol> CreateMultiple(List<RequestRol> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestRol> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseRol> GetAll()
        {
            List<Rol> rol = _Rol.GetAll();
            List<ResponseRol> response = _mapper.Map<List<ResponseRol>>(rol);
            return response;
        }

        public ResponseRol GetById(object id)
        {
            Rol Rol = _Rol.GetById(id);
            ResponseRol response = _mapper.Map<ResponseRol>(Rol);
            return response;
        }

        public ResponseRol Update(RequestRol entity)
        {
            //Start//
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _Rol.Update(Rol);
            ResponseRol response = _mapper.Map<ResponseRol>(Rol);
            return response;
            //End//
        }

        public List<ResponseRol> UpdateMultiple(List<RequestRol> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }

    }
