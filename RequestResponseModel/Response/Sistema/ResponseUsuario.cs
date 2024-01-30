using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Response.Compra;

namespace RequestResponseModel.Response.Sistema
{
    public class ResponseUsuario 
    {
        public string mensajeUsuario = "No se pudo crear el Usuario ";
        public  ResponseVWUsuario?  Usuario { get; set; } =null;
        public ResponsePersona? Persona { get; set; } = null;

        public ResponseRol? Rol { get; set; } = null;
    }
}
