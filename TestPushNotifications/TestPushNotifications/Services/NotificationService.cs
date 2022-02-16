using CorePush.Google;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using TestPushNotifications.Models;
using static TestPushNotifications.Models.GoogleNotification;

namespace TestPushNotifications.Services
{
    public class NotificationService : INotificationService
    {
        private readonly FcmNotificationSetting _fcmNotificationSetting;
        private object fcmSettings;

        public NotificationService(IOptions<FcmNotificationSetting> settings)
        {
            _fcmNotificationSetting = settings.Value;
        }

        public async Task<ResponseModel> SendNotificationAsync(NotificationModel notificationModel)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                if (notificationModel.IsAndroidDevice)
                {
                    FcmSettings settings = new FcmSettings()
                    {
                        SenderId = _fcmNotificationSetting.SenderId,
                        ServerKey = _fcmNotificationSetting.ServerKey
                    };
                    HttpClient httpClient = new HttpClient();

                    string authorizationKey = string.Format("key={0}",settings.ServerKey);
                    string deviceToken = notificationModel.DeviceId;

                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authorizationKey);
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    DataPayLoad dataPayLoad = new DataPayLoad();
                    dataPayLoad.Title = notificationModel.Title;
                    dataPayLoad.Body = notificationModel.Body;

                    GoogleNotification notification = new GoogleNotification();
                    notification.Data = dataPayLoad;
                    notification.Notification = dataPayLoad;

                    var fcm = new FcmSender(settings,httpClient);
                    var fcmResponse = await fcm.SendAsync(deviceToken, notification);

                    if (fcmResponse.IsSuccess())
                    {
                        response.IsSuccess = true;
                        response.Message = "Notification sent Successfully";
                        return response;
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.Message = fcmResponse.Results[0].Error;
                        return response;
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess=false;
                response.Message = "Something went wrong";
                return response;
            }
        }
    }
}
