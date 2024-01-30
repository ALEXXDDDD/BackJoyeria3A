using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel.Request.Compra
{
    public class RequestProvedor
    {
        public int IdProvedor { get; set; }

        public int IdPersona { get; set; }

        //public virtual ICollection<ComprobanteProvedor> ComprobanteProvedors { get; set; } = new List<ComprobanteProvedor>();

        // public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
