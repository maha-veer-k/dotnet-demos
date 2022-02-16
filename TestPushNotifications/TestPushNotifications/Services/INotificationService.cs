using TestPushNotifications.Models;

namespace TestPushNotifications.Services
{
    public interface INotificationService
    {
        Task<ResponseModel> SendNotificationAsync(NotificationModel notificationModel);
    }
}
