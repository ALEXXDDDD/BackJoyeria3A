using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness.Productos;
using IRepository.Productos;
using Repository.Productos;
using RequestResponseModel.Request.Producto;
using RequestResponseModel.Response.Produccion.Producto;

namespace Business.Produccion.Productos
{
    public class BussniessProducto : IBussniessProducto
    {
        #region INYECCION DE DEPENDENCIAS 
        private readonly IRepositoryProducto _repositoryProducto;
        private readonly IMapper _mapper;

        public BussniessProducto (IMapper mapper)
        {
            _mapper = mapper;
            _repositoryProducto = new RepositoryProducto();
        }
        #endregion 
        public ResponseProducto Create(RequestProducto entity)
        {
           Producto producto = _mapper.Map<Producto>(entity);
            producto = _repositoryProducto.Create(producto);
            ResponseProducto responseProd = _mapper.Map<ResponseProducto>(producto);
            return responseProd;
        }

        public List<ResponseProducto> CreateMultiple(List<RequestProducto> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestProducto> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseProducto> GetAll()
        {
           List<Producto> productos = _repositoryProducto.GetAll();
            List<ResponseProducto> listProducto = _mapper.Map<List<ResponseProducto>>(productos);
            return listProducto;
        }

        public ResponseProducto GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseProducto Update(RequestProducto entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseProducto> UpdateMultiple(List<RequestProducto> lista)
        {
            throw new NotImplementedException();
        }
    }
}
