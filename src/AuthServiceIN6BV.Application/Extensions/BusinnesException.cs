namespace AuthServiceIN6BV.Application.Extensions;

public class BusinnesException : Exception
{
    public string ErrorCode { get;}
    public BusinnesException(string errorCode,string message) : base(message)
    {
        ErrorCode = errorCode;
    }
    public BusinnesException(string errorCode,string message, Exception innerException)
     : base(message, innerException)
    {
        ErrorCode = errorCode;
    }
}