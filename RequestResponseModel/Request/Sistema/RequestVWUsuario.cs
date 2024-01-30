using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Sistema
{
    public class RequestVWUsuario
    {
        public int IdUsuario { get; set; }

        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        //[StringLength(25)]
        //public string NombreRol { get; set; } = null!;
       
        public string TipoPersona { get; set; } = null!;

        [StringLength(15)]
        public string TipoDocumento { get; set; } = null!;

        [StringLength(20)]
        public string NumeroDocumento { get; set; } = null!;

        [StringLength(15)]
        public string Telefono { get; set; } = null!;

        [StringLength(10)]
        public string? CodigoUbigeo { get; set; }

        [StringLength(50)]
        public string? Direccion { get; set; }

        [StringLength(30)]
        public string UsuarioV { get; set; } = null!;

        [StringLength(15)]
        public string Password { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(20)]
        public string Estado { get; set; } = null!;
    }
}
