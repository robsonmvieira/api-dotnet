namespace Stock.Supplier.Application.useCases.Address.CreateAddressUseCase.Dtos;

public class AddressOutput
{
    public string Id { get; set; }

    public DateTime? CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
    public string  Street  { get; private set; }
    
    public string  Number  { get; private set; }
    
    public string?  Complement  { get; private set; }
    
    public string  District  { get; private set; }
    
    public string  City  { get; private set; }
    
    public string  State  { get; private set; }
    
    public string  Country  { get; private set; }
    
    public string  ZipCode  { get; private set; }
    
    public AddressOutput(
        string id, 
        string street, 
        string number, 
        string? complement, 
        string district, 
        string city, 
        string state, 
        string country, 
        string zipCode,
        DateTime createdAt, 
        DateTime? updatedAt)
    {
        Id = id;
        Street = street;
        Number = number;
        Complement = complement;
        District = district;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipCode;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt ?? null;
    }

}