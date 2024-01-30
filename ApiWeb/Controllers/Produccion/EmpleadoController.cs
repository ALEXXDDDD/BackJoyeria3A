using AutoMapper;
using Azure.Core;
using Business.Produccion.TB_Empleado;
using IBusiness.Produccion.TB_Empleado;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Produccion.Empleado;

namespace ApiWeb.Controllers.Produccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessVWEmpleado _businessVwEmpleado;
        public EmpleadoController(IMapper mapper)
        {
            _businessVwEmpleado = new BusinessVWEmpleado(mapper);
        }
        #endregion Inyeccion de dependencias
        #region Crud
        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_businessVwEmpleado.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestVWEmpleado request)
        {
            return Ok(_businessVwEmpleado.Create(request));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestVWEmpleado request)
        {
            return Ok(_businessVwEmpleado.Update(request));
        }
        #endregion Crud
    }
}
