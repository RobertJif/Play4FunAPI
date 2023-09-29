namespace Play4Fun.Models.Responses
{
    class ErrorResponse
    {
        public string ErrorCode { set; get; }
        public string ErrorMessage { set; get; }
        public string PropertyName { get; set; }
    }
}