using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestPushNotifications.Models;
using TestPushNotifications.Services;

namespace TestPushNotifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> Send([FromBody] NotificationModel notificationModel)
        {
            var response = await _notificationService.SendNotificationAsync(notificationModel);
            return Ok(response);
        }
    }
}
