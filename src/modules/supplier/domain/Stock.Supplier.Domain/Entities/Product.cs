
using Stock.Core.Entities;

namespace Stock.Supplier.Domain.Entities;

public class Product: Entity
{
    public Guid CategoryId  { get; private set; }
    
    public Category Category { get; private set; }

    public Guid SupplierId { get; private set; }
    
    public Supplier Supplier { get; private set; }
    
    public string Name  { get; private set; }
    
    public string? Description  { get; private set; }
    
    public decimal Price  { get; private set; }
    
    public bool IsActive  { get; private set; }
    
    public string? Image  { get; private set; }
    
    public string? Brand  { get; private set; }
    
    public string? Model  { get; private set; }
    
    public string? Color  { get; private set; }
    
    public string? Size  { get; private set; }
    
    public string? Weight  { get; private set; }
    
    public string? Dimensions  { get; private set; }
    
    public string? Material  { get; private set; }
    
    public string? Warranty  { get; private set; }
    
    public string? TechnicalSpecifications  { get; private set; }
    
    public string? AdditionalInformation  { get; private set; }
    
    public string? Sku  { get; private set; }
    
    public string? Barcode  { get; private set; }
    
    public string? Origin  { get; private set; }
    
    public string? Tax  { get; private set; }
    
    public string? Discount  { get; private set; }
    
    public string? Shipping  { get; private set; }
    
    public string? StockLocation  { get; private set; }
    
    public string? StockControl  { get; private set; }
    
    public string? StockAlert  { get; private set; }
    
    public int? StockMinimum  { get; private set; }
    
    public int? StockMaximum  { get; private set; }
    
    public int StockQuantity  { get; private set; }
    
    public int? StockQuantityReserved  { get; private set; }
    
    public int? StockQuantityBlocked  { get; private set; }
    
    public int? StockQuantityReturned  { get; private set; }
    
    public string? StockQuantityAvailable  { get; private set; }
    
    public string? StockQuantityInTransit  { get; private set; }
    
    
    
    
    protected Product()
    {
        
    }

    public Product(
        Guid categoryId,
        Guid supplierId,
        string name,
        decimal price,
        string sku,
        int stockQuantity,
        int stockMinimum,
        int stockMaximum,
        string? description,
        bool? isActive,
        string? image,
        string? brand,
        string? model,
        string? color,
        string? size,
        string? weight,
        string? dimensions,
        string? material,
        string? warranty,
        string? technicalSpecifications,
        string? additionalInformation,
        string? barcode,
        string? origin,
        string? tax,
        string? discount,
        string? shipping,
        string? stockLocation,
        string? stockControl,
        string? stockAlert,
        string? stockQuantityAvailable,
        string? stockQuantityInTransit,
        Guid id = default,
        DateTime? createdAt = default,
        DateTime? updatedAt = default
        )
    {
        Id = id;
        CategoryId = categoryId;
        SupplierId = supplierId;
        Name = name;
        Description = description;
        Price = price;
        IsActive = isActive ?? true;
        Image = image;
        Brand = brand;
        Model = model;
        Color = color;
        Size = size;
        Weight = weight;
        Dimensions = dimensions;
        Material = material;
        Warranty = warranty;
        TechnicalSpecifications = technicalSpecifications;
        AdditionalInformation = additionalInformation;
        Sku = sku;
        Barcode = barcode;
        Origin = origin;
        Tax = tax;
        Discount = discount;
        Shipping = shipping;
        StockLocation = stockLocation;
        StockControl = stockControl;
        StockAlert = stockAlert;
        StockQuantity = stockQuantity;
        StockMinimum = stockMinimum;
        StockMaximum = stockMaximum;
        StockQuantityAvailable = stockQuantityAvailable;
        StockQuantityInTransit = stockQuantityInTransit;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
    public static Product Create(
        Guid categoryId,
        Guid supplierId,
        string name,
        decimal price,
        string sku,
        int stockQuantity,
        int stockMinimum,
        int stockMaximum,
        string? description,
        bool? isActive,
        string? image,
        string? brand,
        string? model,
        string? color,
        string? size,
        string? weight,
        string? dimensions,
        string? material,
        string? warranty,
        string? technicalSpecifications,
        string? additionalInformation,
        string? barcode,
        string? origin,
        string? tax,
        string? discount,
        string? shipping,
        string? stockLocation,
        string? stockControl,
        string? stockAlert,
        string? stockQuantityAvailable,
        string? stockQuantityInTransit,
        Guid id = default,
        DateTime? createdAt = default,
        DateTime? updatedAt = default
        )
    {
        return new Product(
            categoryId,
            supplierId,
            name,
            price,
            sku,
            stockQuantity,
            stockMinimum,
            stockMaximum,
            description,
            isActive,
            image,
            brand,
            model,
            color,
            size,
            weight,
            dimensions,
            material,
            warranty,
            technicalSpecifications,
            additionalInformation,
            barcode,
            origin,
            tax,
            discount,
            shipping,
            stockLocation,
            stockControl,
            stockAlert,
            stockQuantityAvailable,
            stockQuantityInTransit,
            id,
             createdAt,
             updatedAt
            );
    }

    
    public void UpdatePrice(decimal price)
    {
        if (price  > 0)
        {
            Price = price;
        }
        
    }

}