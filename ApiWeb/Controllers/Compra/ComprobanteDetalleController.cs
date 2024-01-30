using AutoMapper;
using Business.Compra.TB_ComprobanteDetalle;
using IBusiness.Compra.TB_ComprobanteDetalle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel.Request.Compra.ComprobanteDetalle;

namespace ApiWeb.Controllers.Compra
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteDetalleController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessVWDetalleComprobante _businessVwDetalleComprobante;
        private readonly IMapper _mapper;
        public ComprobanteDetalleController(IMapper mapper)
        {
            _mapper = mapper;
            _businessVwDetalleComprobante = new BusinessVWDetalleComprobante(mapper);
        }
        #endregion Inyeccion de dependencias
        #region Crud
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_businessVwDetalleComprobante.GetAll());
        }
        [HttpPost]
        public IActionResult CreateMultiple([FromBody]List<RequestVWComprobanteDetalle> request)
        {
            return Ok(_businessVwDetalleComprobante.CreateMultiple(request));
        }
        #endregion Crud
    }
}
