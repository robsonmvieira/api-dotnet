namespace Stock.Core.Entities;

public interface INotificatorService
{
    bool HasNotification();
    
    List<Notification> GetNotifications();
    
    void Handle(Notification notification);
}