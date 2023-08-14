namespace EnviroBank.Helpers
{
    public class BaseResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; }
        public string Result { get; set; }


    }
}
