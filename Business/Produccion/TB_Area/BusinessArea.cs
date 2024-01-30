using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Produccion.TB_Area;
using IRepository.Produccion.TB_Area;
using Repository.Produccion.TB_Area;
using RequestResponseModel.Request.Produccion.Area;
using RequestResponseModel.Response.Produccion.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Produccion.TB_Area
{
    public class BusinessArea : IBusinessArea
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryArea _repositoryArea;
        private readonly IMapper _mapper;
        public BusinessArea(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryArea = new RepositoryArea();
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public ResponseArea Create(RequestArea entity)
        {
            Area area = _mapper.Map<Area>(entity);
            area = _repositoryArea.Create(area);
            ResponseArea response = _mapper.Map<ResponseArea>(area);
            return response;
        }

        public List<ResponseArea> CreateMultiple(List<RequestArea> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestArea> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseArea> GetAll()
        {
            //Carga de datos a mostrar
            List<Area> area = _repositoryArea.GetAll();
            List<ResponseArea> response = _mapper.Map<List<ResponseArea>>(area);
            return response;
        }

        public ResponseArea GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseArea Update(RequestArea entity)
        {
            Area area = _mapper.Map<Area>(entity);
            area = _repositoryArea.Update(area);
            ResponseArea response = _mapper.Map<ResponseArea>(area);
            return response;
        }

        public List<ResponseArea> UpdateMultiple(List<RequestArea> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}
