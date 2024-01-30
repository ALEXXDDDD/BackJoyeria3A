namespace RequestResponseModel.Response.Venta.Cliente
{
    public class ResponseVWCliente
    {
        public string Message { get; set; } = "";
        public List<ResponseListCliente>? Cliente { get; set; } = null;
    }
}