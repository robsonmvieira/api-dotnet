namespace Stock.Core.Entities;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    
    public DateTime? CreatedAt { get; protected set; }
    
    public DateTime? UpdatedAt { get; protected set; }
    
    public bool IsDeleted { get; private set; }
    
    public DateTime? DeletedAt { get; private set; }
    
    public Entity(Guid id = default, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        Id = id == Guid.Empty ? Guid.NewGuid(): id;
        CreatedAt = createdAt ?? DateTime.UtcNow;
        UpdatedAt = updatedAt;
    }
}