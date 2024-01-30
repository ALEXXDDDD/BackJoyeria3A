using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Sistema
{
    public class ResponseListUsuario
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public int Irol { get; set; }
        public string UsuarioV { get; set; } = null!;

        public string Password { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
