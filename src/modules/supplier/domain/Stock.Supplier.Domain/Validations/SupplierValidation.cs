using FluentValidation;

namespace Stock.Supplier.Domain.Validations;

public class SupplierValidation:  AbstractValidator<Entities.Supplier>
{
    public SupplierValidation()
    {
        RuleFor(s => s.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("Name must be less than 100 characters");

        RuleFor(s => s.Document)
            .NotEmpty().WithMessage("Document is required")
            .MaximumLength(14).WithMessage("Document must be less than 14 characters");

        RuleFor(s => s.Email.Value)
            .EmailAddress()
            .NotEmpty().WithMessage("{PropertyName} is required")
            .MaximumLength(100).WithMessage("{PropertyName} must be less than 100 characters");

        RuleFor(s => s.Phone)
            .NotEmpty().WithMessage("Phone is required")
            .MaximumLength(20).WithMessage("Phone must be less than 20 characters");

        RuleFor(s => s.Address)
            .SetValidator(new AddressValidation()).WithMessage("{PropertyName} is required");
    }
    
}