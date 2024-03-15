using FluentValidation;
using Stock.Supplier.Domain.Entities;

namespace Stock.Supplier.Domain.Validations;

public class ProductValidation : AbstractValidator<Product>
{
    
    public ProductValidation()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("The {PropertyName} name cannot be empty");
        
        RuleFor(x => x.Sku)
            .NotEmpty()
            .WithMessage("The {PropertyName} cannot be empty");
        
        RuleFor(x => x.Price)
            .GreaterThan(0)
            .WithMessage("The product price must be greater than 0");
        
        RuleFor(x => x.StockQuantity)
            .GreaterThanOrEqualTo(0)
            .WithMessage("The product stock must be greater than or equal to 0");
        
                
        RuleFor(x => x.StockMaximum)
            .LessThanOrEqualTo(0)
            .WithMessage("The product stock must be less than or equal to 50");
        
        RuleFor(x => x.StockMinimum)
            .GreaterThanOrEqualTo(4)
            .WithMessage("The product stock must be less greater or equal to 4");
        
        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("The {PropertyName} is required");
        
        RuleFor(x => x.SupplierId)
            .NotEmpty().WithMessage("The {PropertyName} is required");
        
        
    }
}