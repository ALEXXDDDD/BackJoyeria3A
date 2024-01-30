namespace RequestResponseModel.Response.Venta.Cliente
{
    public class ResponseCliente
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool Estado { get; set; }
    }
}