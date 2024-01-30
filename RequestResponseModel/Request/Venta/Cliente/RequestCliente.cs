namespace RequestResponseModel.Request.Venta.Cliente
{
    public class RequestCliente
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool Estado { get; set; }
    }
}