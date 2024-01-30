using RequestResponseModel.Response.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Sistema
{
    public class ResponseLogin
    {
        public bool Success { get; set; } = false;
        public string Mensaje { get; set; } = "Usuario y/o password incorrecto";
        public string Token { get; set; } = "";
        public string TokenExpira { get; set; } = "";
        public ResponseVWUsuario? VWUsuario {get; set; } = null;
        public ResponsePersona? Persona { get; set; } = null;
        //public UsuarioLoginResponse? Usuario { get; set; } = null;
        //public RolResponse? Rol { get; set; } = null;
        //public PersonaResponse? Persona { get; set; } = null;

    }
}
