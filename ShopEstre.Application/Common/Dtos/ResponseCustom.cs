namespace ShopEstre.Application.Common.Dtos
{
    public class ResponseCustom<T> where T : class
    {
        public string Message { get; set; } = string.Empty;
        public int Status { get; set; }
        public T Data { get; set; }
        public ResponseCustom(string message, int status, T data) {
            Message = message;
            Status = status;
            Data = data;
        }

        public ResponseCustom(string message, int status)
        {
            Message = message;
            Status = status;
        }

        public ResponseCustom(string message)
        {
            Message = message;
        }
    }
}
