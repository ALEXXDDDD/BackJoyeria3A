using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DBZapateriaDLopezModel;
using IBusiness;
using IBusiness.Sistema;
using IRepository.Venta;
using IRepository.Venta.TB_Cliente;
using Repository.Sistema;
using Repository.Venta.TB_Cliente;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Response.Sistema;
using RequestResponseModel.Response.Venta.Cliente;

namespace Business.Venta.Usuario1
{
    public class BussniessVUsuario : IBussniessVUsuario
    {
        private readonly IRepositoryUsuario _repositoryCliente;
        private readonly IMapper _mapper;
        public BussniessVUsuario(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryCliente = new RepositoryUsuario();
        }
        public ResponseListUsuario Create(RequestUsuario entity)
        {
            Usuario usuario = _mapper.Map<Usuario>(entity);
            usuario = _repositoryCliente.Create(usuario);
            ResponseListUsuario response = _mapper.Map<ResponseListUsuario>(usuario);
            return response;
        }

        public List<ResponseListUsuario> CreateMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseListUsuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseUsuario GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseListUsuario Update(RequestUsuario entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseListUsuario> UpdateMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        ResponseListUsuario IBusinessCrud<RequestUsuario, ResponseListUsuario>.GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
