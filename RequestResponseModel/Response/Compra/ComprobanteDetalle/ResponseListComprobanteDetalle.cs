namespace RequestResponseModel.Response.Compra.ComprobanteDetalle
{
    public class ResponseListComprobanteDetalle
    {
        public string IdComprobante { get; set; } = null!;

        public string NombreMaterial { get; set; } = null!;

        public string? NombreUnidad { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public DateTime? FechaIngreso { get; set; }
    }
}