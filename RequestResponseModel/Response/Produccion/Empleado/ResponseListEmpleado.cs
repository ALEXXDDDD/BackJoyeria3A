namespace RequestResponseModel.Response.Produccion.Empleado
{
    public class ResponseListEmpleado
    {
        public int IdEmpleado { get; set; }
        public int IdPersona { get; set; }
        public string? ApellidoEmp { get; set; }
        public decimal Salario { get; set; }
        public bool Estado { get; set; }
    }
}