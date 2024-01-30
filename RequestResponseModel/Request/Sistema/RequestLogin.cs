using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Sistema
{
    public class RequestLogin
    {
        [StringLength(30)]
        public string Usuario { get; set; } = null!;

        [StringLength(15)]
        public string Password { get; set; } = null!;
    }
}
