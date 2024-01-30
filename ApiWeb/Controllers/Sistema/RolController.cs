using AutoMapper;

using Business.Sistema;

using IBusiness.Sistema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using RequestResponseModel.Request.Sistema;

namespace ApiWeb.Controllers.Sistema
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        #region Inyeccion de depencias
        private readonly IBussniessRol _businessRol;
        public RolController(IMapper mapper)
        {
            _businessRol = new BussniessRol(mapper);
        }
        #endregion Inyeccion de depencias
        #region Crud
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_businessRol.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestRol request)
        {
            return Ok(_businessRol.Create(request));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestRol request)
        {
            return Ok(_businessRol.Update(request));
        }
        #endregion Crud
    }
}
