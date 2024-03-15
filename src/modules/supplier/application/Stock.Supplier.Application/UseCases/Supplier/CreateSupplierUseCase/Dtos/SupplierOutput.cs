using Stock.Supplier.Application.useCases.Address.CreateAddressUseCase.Dtos;

namespace Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;

public class SupplierOutput
{
    public string Id { get; }

    public DateTime CreatedAt { get; }
    
    public DateTime? UpdatedAt { get; }
    
    public string Name { get; }
    
    public string Document { get; }
    
    public string Email { get; }
    
    public string Phone { get; }
    
    public AddressOutput Address { get; }
    
    public string SupplierType { get; }

    public bool IsActive { get; }
    
    public SupplierOutput(
        string id, 
        string name, 
        string document, 
        string email, 
        string phone, 
        AddressOutput address, 
        string supplierType, 
        bool isActive, 
        DateTime createdAt, 
        DateTime? updatedAt)
    {
        Id = id;
        Name = name;
        Document = document;
        Email = email;
        Phone = phone;
        Address = address;
        SupplierType = supplierType;
        IsActive = isActive;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
}