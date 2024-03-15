using FluentValidation;
using Stock.Supplier.Domain.Entities;

namespace Stock.Supplier.Domain.Validations;

public class AddressValidation : AbstractValidator<Address>
{
    public AddressValidation()
    {
        RuleFor(x => x.Street).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(200).WithMessage("{PropertyName} must not exceed 100 characters");
        RuleFor(x => x.Number).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(20).WithMessage("{PropertyName} must not exceed 10 characters");
        RuleFor(x => x.Complement).MaximumLength(200).WithMessage("{PropertyName} must not exceed 100 characters");
        RuleFor(x => x.District).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");
        
        RuleFor(x => x.City).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");
        
        RuleFor(x => x.State).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");
        RuleFor(x => x.Country).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters");
        RuleFor(x => x.ZipCode).NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(20).WithMessage("{PropertyName} must not exceed 10 characters");
    }
}