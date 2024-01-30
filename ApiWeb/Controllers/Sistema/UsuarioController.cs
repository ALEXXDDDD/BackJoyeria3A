using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Produccion.Modelo;
using RequestResponseModel.Response.Produccion.Modelo;
using RequestResponseModel.Response;
using IBusiness.Sistema;
using AutoMapper;
using Business.Venta.Usuario1;
using RequestResponseModel.Request.Sistema;

namespace ApiWeb.Controllers.Sistema
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region  Inyeccion de dependencias 
        private readonly IBussniessUsuario _bussniessUsuario;
        public UsuarioController (IMapper mapper)
        {   
               _bussniessUsuario = new BussniessUsuario (mapper);
        }   
        #endregion Fin de Inyeccion de Dependencias 
        [HttpGet]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ResponseModelo>))]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult GetAll()
        {
            return Ok(_bussniessUsuario.GetAll());
        }
        /// <summary>
        /// Crea un nueva Usuario
        /// </summary>
        /// <param name="request">Modelo Nueva</param>
        /// <returns>Usuario Creada</returns>
        [HttpPost]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseModelo))]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Create([FromBody] RequestVWUsuario request)
        
        
        
        
        {
            return Ok(_bussniessUsuario.Create(request));
        }
        /// <summary>
        /// Actualiza la Usuario
        /// </summary>
        /// <param name="request">Usuario a Actualizar</param>
        /// <returns>El Usuario actualizada</returns>
        [HttpPut]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseModelo))]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Update([FromBody] RequestVWUsuario request)
        {
            return Ok(true);
        }
    }
}
