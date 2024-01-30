using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Compra
{
    public class ResponsePersona
    {
        public int IdPersona { get; set; }

        public string NombrePersona { get; set; } = null!;

        public string TipoPersona { get; set; } = null!;

        public string TipoDocumento { get; set; } = null!;

        public string NumeroDocumento { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string? CodigoUbigeo { get; set; }

        public string? Direccion { get; set; }

    }
}
