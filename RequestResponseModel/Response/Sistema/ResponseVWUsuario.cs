using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Sistema
{
    public class ResponseVWUsuario
    {
        public int IdUsuario { get; set; }


        public string NombrePersona { get; set; } = null!;

        public string NombreRol { get; set; } = null!;

        public string UsuarioV { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Estado { get; set; } = null!;


   
    }
}
