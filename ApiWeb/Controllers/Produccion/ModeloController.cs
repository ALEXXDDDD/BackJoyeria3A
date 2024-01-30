using AutoMapper;
using Business.Produccion;
using IBusiness.Produccion;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response;
using IBusiness.Produccion.Modelos;
using Business.Produccion.Modelos;
using RequestResponseModel.Response.Produccion.Modelo;
using RequestResponseModel.Request.Produccion.Modelo;

namespace ApiWeb.Controllers.Produccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        #region Iyeccion de dependencias
        private readonly IBussniessModelo _businessModelo;
        private readonly IMapper _mapper;
        public ModeloController(IMapper mapper)
        {
            _mapper = mapper;
            _businessModelo = new BussniessModelo(_mapper);
        }
        #endregion Iyeccion de dependencias
        #region CRUD
        /// <summary>
        /// Lista los registros de la tabla Modelo
        /// </summary>
        /// <returns>Lista de Modeloes</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ResponseModelo>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult GetAll()
        {
            return Ok(_businessModelo.GetAll());
        }
        /// <summary>
        /// Crea un nueva Modelo
        /// </summary>
        /// <param name="request">Modelo Nueva</param>
        /// <returns>Modelo Creada</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseModelo))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Create([FromBody] RequestModelo request)
        {
            return Ok(_businessModelo.Create(request));
        }
        /// <summary>
        /// Actualiza la Modelo
        /// </summary>
        /// <param name="request">Unida a Actualizar</param>
        /// <returns>La Modelo actualizada</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseModelo))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Update([FromBody] RequestModelo request)
        {
            return Ok(_businessModelo.Update(request));
        }
        #endregion CRUD
    }
}
