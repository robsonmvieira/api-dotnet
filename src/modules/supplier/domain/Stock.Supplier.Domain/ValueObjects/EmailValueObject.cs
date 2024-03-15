namespace Stock.Supplier.Domain.ValueObjects;
public class Email
{
    public string  Value { get; private set; }
    
    public Email(string value)
    {
        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid email address");
        }
        Value = value;
    }
    
    private static bool IsValid(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}