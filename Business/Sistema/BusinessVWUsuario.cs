using AutoMapper;
using DBZapateriaDLopezModel;
using DocumentFormat.OpenXml.InkML;
using IBusiness;
using IBusiness.Sistema;
using IRepository.Compra;
using IRepository.Sistema;
using Repository.Compra;
using Repository.Sistema;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Sistema
{
    public class BusinessVWUsuario : IBusinessLogin
    {
        #region Inyeccion de dependencias
        private readonly IRepositorVWUsuario _repositorVWUsuario;
        private readonly IRepositoryPersona _repositoryPersona;
        private readonly IMapper _mapper;
        public BusinessVWUsuario(IMapper mapper)
        {
            _mapper = mapper;
            _repositorVWUsuario = new RepositoryVWUsuario();
            _repositoryPersona = new RepositoryPersona();
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        public ResponseLogin Login(RequestLogin login)
        {
            // Declaracion de variables Locales
            ResponseLogin result = new ResponseLogin();
            Persona persona = new Persona();
            // Verificacion de Usuario
            VwUsuario usuario = _repositorVWUsuario.OptenerUsuario(login.Usuario);
            if(usuario == null) return result;
            string newPassword = login.Password;
            if(newPassword != usuario.Password) return result;
            // Carga de datos a resultado
            result.Success = true;
            result.Mensaje = "Loguin Correcto";
            //Busque de persona
            persona = _repositoryPersona.BuscarId(usuario.NombrePersona);
            //Cargar a la repuesta
            result.VWUsuario = new();
            result.VWUsuario = _mapper.Map<ResponseVWUsuario>(usuario);
            result.Persona = new();
            result.Persona = _mapper.Map<ResponsePersona>(persona);

            //Retorna el resultado
            return result;
        }
        #endregion CRUD
    }
}
