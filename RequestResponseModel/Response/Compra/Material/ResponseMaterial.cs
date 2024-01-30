using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Response.Compra.Material
{
    public class ResponseMaterial
    {
        public string Message { get; set; } = "";
        public List<ResponseVWMaterial> Material { get; set; } = new List<ResponseVWMaterial>();
    }
}
