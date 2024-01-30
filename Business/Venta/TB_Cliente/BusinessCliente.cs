using AutoMapper;
using Azure;
using DBZapateriaDLopezModel;
using IBusiness.Venta.TB_Cliente;
using IRepository.Venta.TB_Cliente;
using Repository.Venta.TB_Cliente;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Request.Venta.Cliente;
using RequestResponseModel.Response.Venta.Cliente;

namespace Business.Venta.TB_Cliente
{
    public class BusinessCliente : IBusinessCliente
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryCliente _repositoryCliente;
        private readonly IMapper _mapper;
        public BusinessCliente(IMapper mapper){
            _mapper = mapper;
            _repositoryCliente = new RepositoryCliente();
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public ResponseCliente Create(RequestUsuario entity)
        {
            Cliente cliente = _mapper.Map<Cliente>(entity);
            cliente = _repositoryCliente.Create(cliente);
            ResponseCliente response = _mapper.Map<ResponseCliente>(cliente);
            return response;
        }

      

        public List<ResponseCliente> CreateMultiple(List<RequestUsuario> lista)
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

        public List<ResponseCliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseCliente GetById(object id)
        {
            Cliente cliente = _repositoryCliente.GetById(id);
            ResponseCliente response = _mapper.Map<ResponseCliente>(cliente);
            return response;
        }

        public ResponseCliente Update(RequestUsuario entity)
        {
            Cliente cliente = _mapper.Map<Cliente>(entity);
            cliente = _repositoryCliente.Update(cliente);
            ResponseCliente response = _mapper.Map<ResponseCliente>(cliente);
            return response;
        }

        

        public List<ResponseCliente> UpdateMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        
        #endregion Crud
    }
}