using FluentValidation;
using FluentValidation.Results;

namespace Stock.Core.Entities;

public abstract class BaseValidation
{
    protected readonly INotificatorService _notificatorService;
    
    public BaseValidation(INotificatorService notificatorService)
    {
        _notificatorService = notificatorService;
    }
    
    protected void AddNotification(string message)
    {
        _notificatorService.Handle(new Notification(message));
    }
    
    protected void AddNotification(ValidationResult validationResult)
    {
        foreach (var error in validationResult.Errors)
        {
            AddNotification(error.ErrorMessage);
        }   
        // _notificatorService.Handle(new Notification(message));
    }
    
    
    protected bool ExecuteValidation<TV, TE>(TV validationEntity, TE domainEntity)
        where TV : AbstractValidator<TE> where TE : Entity
    {
        var validator = validationEntity.Validate(domainEntity);

        if (!validator.IsValid)
        {
            AddNotification(validator);
            return false;
        };
        
        return true;
        
    }
     
}