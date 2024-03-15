using Stock.Core.Entities;

namespace Stock.Supplier.Domain.Entities;

public class Category : Entity
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public bool IsActive { get; private set; }

    public IEnumerable<Product> Products { get; private set; }
    
    

    protected Category()
    {
        
    }

    public Category(
        string name, 
        string? description, 
        bool? isActive, 
        Guid id = default, 
        DateTime? createdAt = default, 
        DateTime? updatedAt = default) 
        
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive ?? true;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        Products = new List<Product>();
        
    }

    public void Update(string? name, string? description,  bool? isActive)
    {
        Name = name ?? Name;
        Description = description ?? Description;
        IsActive = isActive ?? IsActive;
        
    }
    
    public static Category Create(string name, string? description, bool isActive, Guid id = default)
    {
        return new Category(name, description, isActive, id);
    }

   
    
    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;
    
    public string GetDescription() => Description;
    public string GetName() => Name;
    public bool GetIsActive() => IsActive;

    public void UpdateName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            Name = name;
        }
    }
    
    // public void CreatedEvent()
    // {
    //     AddDomainEvent(new SavedCategoryEvent(Id, Name));
    // }

    public void UpdateDescription(string description)
    {
        Description = description;
    }

    public void UpdateIsActive(bool isActive) => IsActive = isActive;
    
}
