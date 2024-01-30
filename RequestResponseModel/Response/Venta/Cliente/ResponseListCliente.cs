namespace RequestResponseModel.Response.Venta.Cliente
{
    public class ResponseListCliente
    {
        public int IdCliente { get; set; } = 0;
        public string NombrePersona { get; set; } = null!;
        public string TipoPersona { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NumeroDocumento { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string? CodigoUbigeo { get; set; } = "";
        public string? Direccion { get; set; } = "";
        public DateTime? FechaNacimiento { get; set; } = DateTime.Now;
        public bool Estado { get; set; } = false;
    }
}