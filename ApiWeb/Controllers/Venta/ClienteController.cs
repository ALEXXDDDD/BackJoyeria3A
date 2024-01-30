using AutoMapper;
using Business.Venta.TB_Cliente;
using IBusiness.Venta.TB_Cliente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Venta.Cliente;

namespace ApiWeb.Controllers.Venta
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessVWCliente _businessVWCliente;
        private readonly IBusinessCliente _businessCliente;
        public ClienteController(IMapper mapper)
        {
            _businessVWCliente = new BusinessVWCliente(mapper);
            _businessCliente = new BusinessCliente(mapper); 
        }
        #endregion Inyeccion de dependencias
        #region Crud
        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_businessVWCliente.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestVWCliente request)
        {
            return Ok(_businessVWCliente.Create(request));
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestVWCliente request)
        {
            return Ok(_businessVWCliente.Update(request));
        }
        #endregion Crud
    }
}
