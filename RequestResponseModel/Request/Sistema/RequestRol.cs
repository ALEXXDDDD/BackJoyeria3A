using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Sistema
{
    public class RequestRol
    {
        [Key]
        [Column("IRol")]
        public int Irol { get; set; }

        [StringLength(25)]
        public string NombreRol { get; set; } = null!;

        public string? Desc { get; set; }
    }
}
