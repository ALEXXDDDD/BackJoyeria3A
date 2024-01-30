namespace RequestResponseModel.Response
{
    public class ResponseFilterGeneric<T>
    {
        public int TotalRegistros { get; set; }
        public List<T> Lista { get; set; } = new List<T>();
    }

}