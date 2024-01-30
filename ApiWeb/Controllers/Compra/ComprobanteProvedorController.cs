using AutoMapper;
using Business.Compra;
using IBusiness.Compra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Response;
using RequestResponseModel.Response.Compra;
using System.Net;

namespace ApiWeb.Controllers.Compra
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteProvedorController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessVWComprobanteProvedor _businessVWComprobanteProvedor;
        private readonly IMapper _mapper;
        public ComprobanteProvedorController(IMapper mapper)
        {
            _mapper = mapper;
            _businessVWComprobanteProvedor = new BusinessVWComprobanteProvedor(_mapper);
        }
        #endregion Inyeccion de dependencias

        /// <summary>
        /// Lista de los comprobantes de los provedores
        /// </summary>
        /// <returns>Lista de comprobantes</returns>
        #region CRUD
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ResponseVWComprobanteProvedor>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]

        public IActionResult GetAll() => Ok(_businessVWComprobanteProvedor.GetAll());

        /// <summary>
        /// Crear un nuevo comprobante de compra de materiales
        /// </summary>
        /// <param name="request">Informacion del comprobante</param>
        /// <returns>Retorna la informacion del nuevo comprobante</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseVWComprobanteProvedor))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Create([FromBody] RequestVWComprobanteProvedor request) => 
            Ok(_businessVWComprobanteProvedor.Create(request));
        #endregion CRUD
    }
}
