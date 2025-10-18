namespace WebApi.Comman;

public class ApiResponse<T>
{
    public int StatusCode { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }

    public ApiResponse(int statusCode, string message, T? data = default)
    {
        StatusCode = statusCode;
        Message = message;
        Data = data;
    }

    public static ApiResponse<T> Success(T? data, string message = "Success", int statusCode = 200)
        => new(statusCode, message, data);

    public static ApiResponse<T> Success(string message = "Success", int statusCode = 200)
        => new(statusCode, message, default);

    public static ApiResponse<T> Fail(string message, int statusCode = 400)
        => new(statusCode, message);
}