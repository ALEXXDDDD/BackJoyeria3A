using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Compra
{
    public class ResponseProvedor
    {

        public int IdProvedor { get; set; } = 0;

        public string Message { get; set; } = "";

        public ResponsePersona? Persona { get; set; } = null; 

    }
}
