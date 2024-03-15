using FluentValidation;

namespace Stock.Supplier.Domain.Validations;

public class CategoryValidation: AbstractValidator<Entities.Category>
{
    public CategoryValidation()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is required");
        RuleFor(x => x.Name).MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");
        RuleFor(x => x.IsActive).IsInEnum().WithMessage("{PropertyName} must be a boolean");
        RuleFor(x => x.Description).MaximumLength(500).WithMessage("Description must not exceed 500 characters");
    }
}
