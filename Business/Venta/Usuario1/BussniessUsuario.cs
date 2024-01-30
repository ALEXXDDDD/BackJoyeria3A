using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Azure;
using Business.Sistema;
using Business.Venta.TB_Cliente;
using DBZapateriaDLopezModel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Vml.Office;
using IBusiness.Sistema;
using IBusiness.Venta.TB_Cliente;
using IRepository.Compra;
using IRepository.Sistema;
using IRepository.Venta;
using Repository.Compra;
using Repository.Sistema;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Request.Produccion.Empleado;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Request.Venta.Cliente;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Produccion.Empleado;
using RequestResponseModel.Response.Sistema;
using RequestResponseModel.Response.Venta.Cliente;
using SecurityUtility;

namespace Business.Venta.Usuario1
{
    public class BussniessUsuario :IBussniessUsuario
    {
        #region Declaracion de Varibales
        private readonly IBusinessPersona _bussniessPersona;
        private readonly IRepositoryUsuario _repositoryUsuario;
        private readonly IBussniessVUsuario _bussniessVUsuario;
        private readonly IBusinessCliente _bussniessCliente;
        private readonly IBussniessRol _bussniessRol;
        private readonly IMapper _mapper;
        private readonly UtilEncriptarDesencriptar _cripto;

        public BussniessUsuario(IMapper mapper)
        {
            
            _bussniessPersona = new BusinessPersona(mapper);
            _repositoryUsuario = new RepositoryUsuario();
            _bussniessCliente = new BusinessCliente(mapper);
            _bussniessVUsuario = new BussniessVUsuario(mapper);
            _bussniessRol = new BussniessRol(mapper);
            _mapper = mapper;
            _cripto = new UtilEncriptarDesencriptar();

        }
        #endregion

        public List<ResponseVWUsuario> GetAll()
        {
            List<Usuario> usuario = _repositoryUsuario.GetAll();
            List<ResponseVWUsuario> responseUsuario = _mapper.Map<List<ResponseVWUsuario>>(usuario);
            return responseUsuario;


        }

        public ResponseVWUsuario GetById(object id)
        {
            //ResponseVWCliente response = new();
            //response.Cliente = new();
            //ResponseListCliente list = new();
            //RequestPersona reqPersona = new();
            //ResponsePersona resPersona = new();
            //RequestCliente reqCliente = new();
            //ResponseCliente resCliente = new();

            //reqPersona = _mapper.Map<RequestPersona>(entity);
            //resPersona = _businessPersona.Create(reqPersona);

            //reqCliente = _mapper.Map<RequestCliente>(entity);
            //reqCliente.IdPersona = resPersona.IdPersona;
            //resCliente = _businessCliente.Create(reqCliente);

            //entity.IdCliente = resCliente.IdCliente;
            //list = _mapper.Map<ResponseListCliente>(entity);
            //response.Message = "El Cliente Fue Registrado Exitosamente";
            //response.Cliente.Add(list);
            //return response;
            throw new NotImplementedException();
        }

        public ResponseVWUsuario Create(RequestVWUsuario entity)
        {
            if (entity == null)
            {
                return null;
            }
            else
            { 
              //CREACION DE LA PERSONA 
                ResponseVWUsuario result = new ResponseVWUsuario();


                RequestPersona requestPersona = _mapper.Map<RequestPersona>(entity);
                ResponsePersona responsePersona = _bussniessPersona.Create(requestPersona);

                //ROL
                RequestRol requestRol = _mapper.Map<RequestRol>(entity);
                //ResponseRol responseRol = _bussniessRol.Create(requestRol);

                //USUARIO
                if (responsePersona.TipoPersona == "Cliente")
                 {
                    requestRol.Irol = 2;

                    RequestUsuario requestUsuario = _mapper.Map<RequestUsuario>(entity);
                    requestUsuario.IdPersona = responsePersona.IdPersona; 
                
                    requestUsuario.Irol = requestRol.Irol;


                    RequestCliente requestCliente = _mapper.Map<RequestCliente>(entity);
                    requestCliente.IdPersona = requestPersona.IdPersona;
                    ResponseCliente responseCliente = _bussniessCliente.Create(requestUsuario);
                    //entity.Password = _cripto.AES_encriptar(entity.Password);
                    //entity.Password = requestUsuario.Password;
                    ResponseListUsuario responseUsuario = _bussniessVUsuario.Create(requestUsuario);

                    /**
                     * CREACUON EN LA TABLA DE CLUENTE
                     * 
                     * */
                     
                  
                    //ResponseVWUsuario data = _mapper.Map<ResponseVWUsuario>(entity);
                    //data.IdUsuario = responseUsuario.IdUsuario;
                    result.mensajeUsuario = "Se registro el Usuario  Correctamente";
                    return result;
                 } else
                   if (responsePersona.TipoPersona == "Administrador")
                    {
                       requestRol.Irol = 1;

                       RequestUsuario requestUsuario = _mapper.Map<RequestUsuario>(entity);
                       requestUsuario.IdPersona = responsePersona.IdPersona;

                       requestUsuario.Irol = requestRol.Irol;
                       entity.Password = _cripto.AES_encriptar(entity.Password);
                       entity.Password = requestUsuario.Password;
                       ResponseListUsuario responseUsuario = _bussniessVUsuario.Create(requestUsuario);
                       
                       //ResponseVWUsuario data = _mapper.Map<ResponseVWUsuario>(entity);
                                //data.IdUsuario = responseUsuario.IdUsuario;

                    
                       result.mensajeUsuario = "Se registro el Usuario  Correctamente";
                       return result;
                   }
            return result;
            
            }
          
            //requestUsuario.Irol = responseRol.Irol               
       }

        public List<ResponseVWUsuario> CreateMultiple(List<RequestVWUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public ResponseVWUsuario Update(RequestVWUsuario entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWUsuario> UpdateMultiple(List<RequestVWUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
    }
    }
