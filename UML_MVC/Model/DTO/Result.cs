namespace Model.DTO
{
    public sealed class Result<T>
    {
        public string Error { get; private set; } 
        public bool Ok { get; }
        public T Data { get; }

        private Result(bool ok, T data)
        {
            Ok = ok;
            Data = data;
        }

        public static Result<T> Fail(string message) => 
            new Result<T>(false, default(T))
            {
                Error = message
            };

        public static Result<T> Success(T Data) =>
            new Result<T>(true, Data);
        
    }
}