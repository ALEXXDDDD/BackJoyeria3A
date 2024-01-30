using AutoMapper;
using Azure;
using Business.Sistema;
using DBZapateriaDLopezModel;
using IBusiness.Sistema;
using IBusiness.Venta.TB_Cliente;
using IRepository.Venta.TB_Cliente;
using Repository.Venta.TB_Cliente;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Request.Venta.Cliente;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Venta.Cliente;

namespace Business.Venta.TB_Cliente
{
    public class BusinessVWCliente : IBusinessVWCliente
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryVWCliente _repositoryVWCliente;
        private readonly IBusinessCliente _businessCliente;
        private readonly IBusinessPersona _businessPersona;
        private readonly IRepositoryCliente _repositoryCliente;
        private readonly IMapper _mapper;
        public BusinessVWCliente(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryVWCliente = new RepositoryVWCliente();
            _repositoryCliente = new RepositoryCliente();
            _businessCliente = new BusinessCliente(mapper);
            _businessPersona = new BusinessPersona(mapper);
        }
        #endregion Inyeccion de dependencias
        #region Crud
        public ResponseVWCliente Create(RequestVWCliente entity)
        {
            ResponseVWCliente response = new();
            response.Cliente = new();
            ResponseListCliente list = new();
            RequestPersona reqPersona = new();
            ResponsePersona resPersona = new();
            RequestUsuario reqCliente = new();
            ResponseCliente resCliente = new();

            reqPersona = _mapper.Map<RequestPersona>(entity);
            resPersona = _businessPersona.Create(reqPersona);

            reqCliente = _mapper.Map<RequestUsuario>(entity);
            reqCliente.IdPersona = resPersona.IdPersona;
            resCliente = _businessCliente.Create(reqCliente);

            entity.IdCliente = resCliente.IdCliente;
            list = _mapper.Map<ResponseListCliente>(entity);
            response.Message = "El Cliente Fue Registrado Exitosamente";
            response.Cliente.Add(list);
            return response;
        }

        public List<ResponseVWCliente> CreateMultiple(List<RequestVWCliente> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWCliente> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWCliente> GetAll()
        {
            List<ResponseVWCliente> response = new List<ResponseVWCliente>();
            ResponseVWCliente cliente = new();
            cliente.Cliente = new List<ResponseListCliente>();

            List<VwCliente> clientes =_repositoryVWCliente.GetAll();
            cliente.Cliente = _mapper.Map<List<ResponseListCliente>>(clientes);
            cliente.Message = "Lista de registros";
            response.Add(cliente);
            return response;
        }

        public ResponseVWCliente GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVWCliente Update(RequestVWCliente entity)
        {
            ResponseVWCliente response = new();
            response.Cliente = new();
            ResponseListCliente list = new();
            RequestPersona reqPersona = new();
            ResponsePersona resPersona = new();
            RequestUsuario reqCliente = new();
            ResponseCliente resCliente = new();

            Cliente c = _repositoryCliente.GetById(entity.IdCliente);

            reqCliente = _mapper.Map<RequestUsuario>(entity);
            reqCliente.IdPersona= c.IdPersona;
            resCliente = _businessCliente.Update(reqCliente);

            reqPersona = _mapper.Map<RequestPersona>(entity);
            reqPersona.IdPersona = c.IdPersona;
            resPersona = _businessPersona.Update(reqPersona);

            list = _mapper.Map<ResponseListCliente>(entity);
            response.Message = "Cliente se actualizo correctamente";
            response.Cliente.Add(list);
            return response;
        }

        public List<ResponseVWCliente> UpdateMultiple(List<RequestVWCliente> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Crud
    }
}