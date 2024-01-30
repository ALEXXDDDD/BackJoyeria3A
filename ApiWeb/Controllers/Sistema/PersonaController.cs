using AutoMapper;
using Business.Sistema;
using IBusiness.Sistema;
using IRepository.Compra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers.Sistema
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IRepositoryPersona _repositoryPersona;
        private readonly IBusinessPersona _busniessPersona;
        private readonly IMapper mapper;
        public PersonaController (IMapper mapper )
        {
            _busniessPersona = new BusinessPersona(mapper);
        }

        #endregion Fin de Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_busniessPersona.GetAll());
        }
    }
}
