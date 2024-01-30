using AutoMapper;
using Business.Compra;
using IBusiness.Compra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace ApiWeb.Controllers.Compra
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    //[Authorize]
    public class ProveedorController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessVWProvedor _businessProvedor;
        private readonly IMapper _mapper;
        public ProveedorController(IMapper mapper)
        {
            _mapper = mapper;
            _businessProvedor = new BusinessVWProvedor(mapper);
        }
        #endregion Inyeccion de dependencias

        /// <summary>
        /// Lista de provedores que tiene se tiene
        /// </summary>
        /// <returns>Retorna lista de provedores</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ResponseVWProvedor>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]

        public IActionResult GetAll()
        {
            return Ok(_businessProvedor.MostrarProvedor());
        }

        /// <summary>
        /// Crear un nuevo provedore 
        /// </summary>
        /// <param name="request">Datos del provedor</param>
        /// <returns>Retorna un nuevo provedor</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseProvedor))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Create([FromBody] RequestVWProvedor request) => Ok(_businessProvedor.Create(request));

        /// <summary>
        /// Actualiza los datos de un proveedor
        /// </summary>
        /// <param name="request">Nuevos datos</param>
        /// <returns>Los nuevos datos del proveedor</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseProvedor))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Update([FromBody] RequestVWProvedor request) => Ok(_businessProvedor.Update(request));
    }
}
