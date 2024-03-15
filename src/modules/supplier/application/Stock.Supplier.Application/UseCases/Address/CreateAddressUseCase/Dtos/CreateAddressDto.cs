namespace Stock.Supplier.Application.useCases.Address.CreateAddressUseCase.Dtos;

public class CreateAddressDto
{
    public string  Street  { get; private set; }
    
    public string  Number  { get; private set; }
    
    public string?  Complement  { get; private set; }
    
    public string  District  { get; private set; }
    
    public string  City  { get; private set; }
    
    public string  State  { get; private set; }
    
    public string  Country  { get; private set; }
    
    public string  ZipCode  { get; private set; }
    
    public CreateAddressDto(string street, string number, string district, string city, string state, string country, string zipCode, string? complement)
    {
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipCode;
        Complement = complement;
    }   
}