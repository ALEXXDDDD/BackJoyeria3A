using AutoMapper;
using Business.Compra.TB_Material;
using IBusiness.Compra.TB_Material;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Compra.Materiald;
using RequestResponseModel.Response;
using RequestResponseModel.Response.Compra.Material;
using System.Net;

namespace ApiWeb.Controllers.Compra
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessMaterial _businessMaterial;
        private readonly IMapper _mapper;
        public MaterialController(IMapper mapper)
        {
            _mapper = mapper;
            _businessMaterial = new BusinessMaterial(mapper);
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        /// <summary>
        /// Lista de Materiales de Compra
        /// </summary>
        /// <returns>Lista de Materiales</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ResponseMaterial>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Get()
        {
            return Ok(_businessMaterial.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestMaterial request)
        {
            return Ok(_businessMaterial.Create(request));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestMaterial request)
        {
            return Ok(_businessMaterial.Update(request));
        }
        #endregion CRUD
    }
}
