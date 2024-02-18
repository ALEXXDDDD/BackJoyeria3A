using AutoMapper;
using Business.Produccion.DetalleProduccion;
using IBusiness.Produccion.DetalleProduccion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers.Produccion
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleProduccionController : ControllerBase
    {
        #region Declaracion de Variables 
        private readonly IMapper _mapper;
        private readonly IBussniessDetalleProduccion _bussniessDetalleProduccion;

        public DetalleProduccionController (IMapper mapper)
        {
            _mapper = mapper;
            _bussniessDetalleProduccion = new BusniessDetalleProduccion (mapper);
        }
        #endregion Fin de Declaracion de Variables 

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bussniessDetalleProduccion.GetAll());
        }
    }
}
