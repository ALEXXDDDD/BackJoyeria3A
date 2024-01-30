using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Sistema;

namespace RequestResponseModel.Request.Sistema
{
    public class RequestUsuario
    {
        public int IdUsuario { get; set; }

        public int IdPersona { get; set; }

        public int Irol { get; set; }

        [StringLength(30)]
        public string UsuarioV { get; set; } = null!;

        [StringLength(15)]
        public string Password { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(20)]
        public string Estado { get; set; } = null!;

        public byte[]? Fotografia { get; set; }


        public RequestVWUsuario? VWUsuario { get; set; } = null;
        public RequestPersona? Persona { get; set; } = null;

        public RequestRol? Rol { get; set; } = null;

        //public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

        //public virtual ICollection<Historial> Historials { get; set; } = new List<Historial>();

        //public virtual Persona IdPersonaNavigation { get; set; } = null!;

        //public virtual Rol IrolNavigation { get; set; } = null!
    }
}
