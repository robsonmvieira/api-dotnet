namespace Stock.Core.Entities;

public class NotificationService: INotificatorService
{
    private List<Notification> _notifications;
    
    public NotificationService()
    {
        _notifications = new List<Notification>();
    }
    public bool HasNotification()
    {
        return _notifications.Any();
    }

    public List<Notification> GetNotifications()
    {
        return _notifications;
    }

    public void Handle(Notification notification)
    {
        _notifications.Add(notification);
    }
}