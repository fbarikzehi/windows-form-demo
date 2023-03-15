namespace Nojan.Data;

public class CommandResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}


public class CommandResponse<TData> : CommandResponse where TData : new()
{
    public TData? Data { get; set; } = new TData();
}
