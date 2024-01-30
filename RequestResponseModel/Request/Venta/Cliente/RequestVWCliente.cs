using System.ComponentModel.DataAnnotations;

namespace RequestResponseModel.Request.Venta.Cliente
{
    public class RequestVWCliente
    {
        public int IdCliente { get; set; } = 0;
        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;
        [StringLength(30)]
        public string TipoPersona { get; set; } = null!;
        [StringLength(15)]
        public string TipoDocumento { get; set; } = null!;
        [StringLength(20)]
        public string NumeroDocumento { get; set; } = null!;
        [StringLength(15)]
        public string Telefono { get; set; } = null!;
        [StringLength(10)]
        public string? CodigoUbigeo { get; set; } = "";
        [StringLength(50)]
        public string? Direccion { get; set; } = "";
        public DateTime? FechaNacimiento { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = false;
    }
}