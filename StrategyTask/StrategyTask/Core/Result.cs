namespace StrategyTask.Core;

public class Result
{
    public Result(bool isSuccess, string error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }
    public bool IsSuccess { get; set; }
    public string Error { get; set; } = string.Empty;

    public static Result Success() => new Result(true, "");
    public static Result<T> Success<T>(T value) => new Result<T>(true, value,"");
    public static Result Failure(string error) => new Result(false, error);
    public static Result<T> Failure<T>(string error) => new Result<T>(false, default!, error);
}

public class Result<T> : Result
{
    private T _value;
    public Result(bool isSuccess, T value, string error) : base(isSuccess, error)
    {
        _value = value;
    }

    public T Value =>
        IsSuccess ? _value : throw new InvalidOperationException();
}
