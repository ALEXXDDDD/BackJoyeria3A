using AutoMapper;
using Business.Produccion.Productos;
using IBusiness.Productos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RequestDecompression;
using RequestResponseModel.Request.Producto;

namespace ApiWeb.Controllers.Productos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        #region Declaracion de Varialbles
        private readonly IBussniessProducto _bussniessProducto;
        private readonly IMapper _mapper;
        public ProductoController (IMapper mapper)
        {
            _mapper = mapper;
            _bussniessProducto = new BussniessProducto(_mapper);
        }
        #endregion
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bussniessProducto.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody]RequestProducto request)
        {
            return Ok(_bussniessProducto.Create(request));
        }
        
    }
}
