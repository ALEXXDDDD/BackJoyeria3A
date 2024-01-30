using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Compra
{
    public class ResponseVWProvedor
    {
        public int IdProvedor { get; set; }

        public string NombrePersona { get; set; } = null!;

        public string TipoPersona { get; set; } = null!;

        public string TipoDocumento { get; set; } = null!;

        public string Numerodocumento { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string? CodigoUbigeo { get; set; }

        public string? Direccion { get; set; }
    }
}
