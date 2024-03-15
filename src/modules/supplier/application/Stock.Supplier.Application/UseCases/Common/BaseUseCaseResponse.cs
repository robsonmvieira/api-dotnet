namespace Stock.Supplier.Application.UseCases.Common;

public class BaseUseCaseResponse<T> where T : class?
{
    public bool HasError  { get; }
    
    public bool Successs  { get; }
    
    public DateTime CreatedAt  { get; }
    
    public T data  { get; }
    
    public BaseUseCaseResponse(bool hasError, bool success,  T data = null)
    {
        HasError = hasError;
        Successs = success;
        CreatedAt = DateTime.UtcNow;
        this.data = data;
    }
    
}