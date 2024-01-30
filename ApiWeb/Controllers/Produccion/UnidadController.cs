using AutoMapper;
using Business.Produccion;
using IBusiness.Produccion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Response;
using RequestResponseModel.Response.Produccion;
using System.Net;

namespace ApiWeb.Controllers.Produccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadController : ControllerBase
    {
        #region Iyeccion de dependencias
        private readonly IBusinessUnidad _businessUnidad;
        private readonly IMapper _mapper;
        public UnidadController(IMapper mapper)
        {
            _mapper = mapper;
            _businessUnidad = new BusinessUnidad(_mapper);
        }
        #endregion Iyeccion de dependencias
        #region CRUD
        /// <summary>
        /// Lista los registros de la tabla Unidad
        /// </summary>
        /// <returns>Lista de Unidades</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK,Type = typeof(List<ResponseUnidad>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult GetAll()
        {
            return Ok(_businessUnidad.GetAll());
        }
        /// <summary>
        /// Crea un nueva Unidad
        /// </summary>
        /// <param name="request">Unidad Nueva</param>
        /// <returns>Unidad Creada</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseUnidad))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Create([FromBody] RequestUnidad request)
        {
            return Ok(_businessUnidad.Create(request));
        }
        /// <summary>
        /// Actualiza la Unidad
        /// </summary>
        /// <param name="request">Unida a Actualizar</param>
        /// <returns>La unidad actualizada</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseUnidad))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Update([FromBody] RequestUnidad request)
        {
            return Ok(_businessUnidad.Update(request));
        }
        #endregion CRUD
    }
}
