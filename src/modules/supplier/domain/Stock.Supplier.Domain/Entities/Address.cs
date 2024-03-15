using Stock.Core.Entities;

namespace Stock.Supplier.Domain.Entities;
public class Address: Entity
{
    public string  Street  { get; private set; }
    public string  Number  { get; private set; }
    public string?  Complement  { get; private set; }
    public string  District  { get; private set; }
    public string  City  { get; private set; }
    public string  State  { get; private set; }
    public string  Country  { get; private set; }
    public string  ZipCode  { get; private set; }
    
    protected Address()
    {
        
    }
    
    public Address(
        string street, 
        string number, 
        
        string district, 
        string city, 
        string state, 
        string country, 
        string zipCode,
        string? complement,
        Guid id = default, 
        DateTime createdAt = default, 
        DateTime? updatedAt = default)
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
        UpdatedAt = updatedAt;
    }
    
    public static Address Create(
        string street, 
        string number, 
        string district, 
        string city, 
        string state, 
        string country, 
        string zipCode, 
        string? complement, 
        Guid id = default)
    {
        return new Address(street, number, district, city, state, country, zipCode, complement, id);
    }
    
    public void Update(
        string? street, 
        string? number, 
        string? complement, 
        string? district, 
        string? city, 
        string? state, 
        string? country, 
        string? zipCode)
    {
        Street = street ?? Street;
        Number = number ?? Number;
        Complement = complement ?? Complement;
        District = district ?? District;
        City = city ?? City;
        State = state ?? State;
        Country = country ?? Country;
        ZipCode = zipCode ?? ZipCode;
    }
    
    public string GetStreet() => Street;
    
    public string GetNumber() => Number;
    
    public string? GetComplement() => Complement;
    
    public string GetDistrict() => District;
    
    public string GetCity() => City;
    
    public string GetState() => State;
    
    public string GetCountry() => Country;
    
    public string GetZipCode() => ZipCode;
    
   public void UpdateStreet(string street)
   {
       if (!string.IsNullOrEmpty(street))
       {
           Street = street;
       }
   }
   
   public void UpdateNumber(string number)
   {
       if (!string.IsNullOrEmpty(number))
       {
           Number = number;
       }
   }
   
   public void UpdateComplement(string? complement)
   {
       Complement = complement;
   }
   
   public void UpdateDistrict(string district)
   {
       if (!string.IsNullOrEmpty(district))
       {
           District = district;
       }
   }
   
   public void UpdateCity(string city)
   {
       if (!string.IsNullOrEmpty(city))
       {
           City = city;
       }
   }
   
   public void UpdateState(string state)
   {
       if (!string.IsNullOrEmpty(state))
       {
           State = state;
       }
   }
   
   public void UpdateCountry(string country)
   {
       if (!string.IsNullOrEmpty(country))
       {
           Country = country;
       }
   }
   
   public void UpdateZipCode(string zipCode)
   {
       if (!string.IsNullOrEmpty(zipCode))
       {
           ZipCode = zipCode;
       }
   }
}