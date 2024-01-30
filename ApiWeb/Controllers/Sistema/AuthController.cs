using AutoMapper;
using Business.Sistema;
using DocumentFormat.OpenXml.Spreadsheet;
using IBusiness.Sistema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Response;
using RequestResponseModel.Response.Sistema;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace ApiWeb.Controllers.Sistema
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        #region Inyeccion de dependencias
        private readonly IBusinessLogin _businessLogin;
        public AuthController(IMapper mapper)
        {
            _businessLogin = new BusinessVWUsuario(mapper);
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        /// <summary>
        /// Verificar si el login esta activo
        /// </summary>
        /// <returns>Retorna un True si es corecto</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Boolean))]
        public IActionResult Get() => Ok(true);
        /// <summary>
        /// Verifica un usuario y contraseña en la base de datos
        /// </summary>
        /// <param name="request">Usuario y contraseña</param>
        /// <returns>Response</returns>
        /// <remarks>
        /// Sample request:
        ///     Post/Loguin
        ///     {
        ///         "Usuario": "Bruno123",
        ///         "Password": "123456"
        ///     }
        /// </remarks>
        /// <returns code="200">Una mensaje si es valido</returns>
        /// <returns code="400">El usuario y password no se encontro en la base de datos</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseLogin))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ResponseGeneric))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ResponseGeneric))]
        public IActionResult Login(RequestLogin request)
        {
            ResponseLogin reponse = _businessLogin.Login(request);
            if(reponse.Success)
            {
                reponse.Token = CreateToken(reponse);
                return Ok(reponse);
            }
            else
            {
                return Ok(reponse);
            }
            
        }
        #endregion CRUD
        #region

        /*private string CreateToken(ResponseLogin oLoginResponse)
        {
            //obteniendo información de nuestro archivo appsettings.json
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            //OBTENER EL TIEMPO DE VIDA DEL TOKEN
            int tiempoVida = int.Parse(configurationFile["Jwt:TimeJWTMin"]);
            //01 VAMOS A DETALLAR LOS CLAIMS
            //==> INFORMACIÓN QUE SE PUEDE ALMACENAR DENTRO DEL TOKEN GENERADO

            
              //VAMOS A DECLARAR LOS CLAIMS - LA INFORMACIÓN QUE SE VA A CARGAR DENTRO DEL TOKEN
             
            

            //string stringClaims = JsonConvert.SerializeObject(oLoginResponse);
            //stringClaims = _cripto.AES_encriptar(stringClaims);

            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),// - UTC-0
                        
                        new Claim("IdUsuario", oLoginResponse.VWUsuario.IdUsuario.ToString()),
                        new Claim("NombrePersona",oLoginResponse.VWUsuario.NombrePersona),
                        new Claim("NombreRol",oLoginResponse.VWUsuario.NombreRol)
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(tiempoVida),
                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        */
        private string CreateToken(ResponseLogin responseLogin)
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            int tiempoVida = int.Parse(configurationFile["Jwt:TimeJWTMin"]);

            var tokenHandler = new JwtSecurityTokenHandler();
            var byteKey = Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]);
            var tokenDes = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("IdUsuario", responseLogin.VWUsuario.IdUsuario.ToString()),
                        new Claim("NombrePersona",responseLogin.VWUsuario.NombrePersona),
                        new Claim("NombreRol",responseLogin.VWUsuario.NombreRol)
                }),
                Expires = DateTime.UtcNow.AddMinutes(tiempoVida),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(byteKey),
                                                                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDes);
            return tokenHandler.WriteToken(token);
        }
       
        #endregion
    }
}
