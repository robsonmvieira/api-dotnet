using Stock.Core.Entities;
using Stock.Supplier.Domain.Enums;
using Stock.Supplier.Domain.ValueObjects;

namespace Stock.Supplier.Domain.Entities;

public class Supplier: AggregateRoot
{
    public SupplierType SupplierType { get; private set; }
    
    public string Name { get; private set; }
    
    public string? Document { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public Email Email { get; private set; }
    
    public string? Phone { get; private set; }
    
    public Address Address { get; private set; }

    public IEnumerable<Product> Products { get; private set; }
    
    protected Supplier()
    {
        
    }
    
    public Supplier(
        SupplierType supplierType, 
        string name, 
        string? document, 
        bool? isActive, 
        string email, 
        string? phone, 
        Address address, 
        IEnumerable<Product>? products, 
        Guid id = default, 
        DateTime? createdAt = default, 
        DateTime? updatedAt = default
        )
    {
        Id = id;
        SupplierType = supplierType;
        Name = name;
        Document = document;
        IsActive = isActive ?? true;
        Email = new Email(email);
        Phone = phone;
        Address = address;
        Products = products ?? new List<Product>();
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
    public static Supplier Create(
        SupplierType supplierType, 
        string name, 
        string? document, 
        string email, 
        Address address,
        string phone, 
        bool? isActive 
        
        )
    {
        return new Supplier(supplierType, name, document, isActive, email, phone, address, null);
    }
    
    public void Update(
        SupplierType? supplierType, 
        string? name, 
        string? document, 
        bool? isActive, 
        Email? email, 
        string? phone, 
        Address? address)
    {
        SupplierType = supplierType ?? SupplierType;
        Name = name ?? Name;
        Document = document ?? Document;
        IsActive = isActive ?? IsActive;
        Email = email ?? Email;
        Phone = phone ?? Phone;
        Address = address ?? Address;
    }
    
    public void Activate() => IsActive = true;
    
    public void Deactivate() => IsActive = false;
    
    public string GetName() => Name;
    
    public string? GetDocument() => Document;
    
    public bool GetIsActive() => IsActive;
    
    public string GetEmail() => Email.Value;
    
    public string? GetPhone() => Phone;
    
    public Address GetAddress() => Address;
    
    public IEnumerable<Product> GetProducts() => Products;
    
    public void UpdateName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            Name = name;
        }
    }
    
    public void UpdateDocument(string document)
    {
        if (!string.IsNullOrEmpty(document))
        {
            Document = document;
        }
    }
    
    public void UpdateEmail(string email)
    {
        if (!string.IsNullOrEmpty(email))
        {
            Email = new Email(email);
        }
    }
    
    public void UpdatePhone(string phone)
    {
        if (!string.IsNullOrEmpty(phone))
        {
            Phone = phone;
        }
    }
    
    public void UpdateAddress(Address address)
    {
        Address = address;
    }
    
    public void AddProduct(Product product)
    {
        Products.Append(product);
    }
    
    public void RemoveProduct(Product product)
    {
        Products = Products.Where(p => p.Id != product.Id);
    }
    
}