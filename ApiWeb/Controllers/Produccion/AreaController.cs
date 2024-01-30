using AutoMapper;
using Business.Produccion.TB_Area;
using IBusiness.Produccion.TB_Area;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Produccion.Area;

namespace ApiWeb.Controllers.Produccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        #region Inyeccion de depencias
        private readonly IBusinessArea _businessArea;
        public AreaController(IMapper mapper)
        {
            _businessArea = new BusinessArea(mapper);
        }
        #endregion Inyeccion de depencias
        #region Crud
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_businessArea.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestArea request)
        {
            return Ok(_businessArea.Create(request));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestArea request) 
        {
            return Ok(_businessArea.Update(request));
        }
        #endregion Crud
    }
}
