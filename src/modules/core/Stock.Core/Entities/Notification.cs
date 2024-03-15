namespace Stock.Core.Entities;

public class Notification(string message)
{
    public string Message { get;} = message;
}