using Microsoft.AspNetCore.Mvc;
using NotificationManager.EF.Models;
using NotificationManager.Interfaces;

namespace NotificationManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationDataService _notificationDataService;

        public NotificationController(INotificationDataService notificationDataService)
        {
            _notificationDataService = notificationDataService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNotification([FromBody] Notification notification)
        {
            try
            {
                await _notificationDataService.AddNotification(notification);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveNotifications([FromBody] List<string> notificationsIDS)
        {
            try
            {
                await _notificationDataService.RemoveNotifications(notificationsIDS);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveNotification([FromQuery] string notificationID)
        {
            try
            {
                await _notificationDataService.RemoveNotification(notificationID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNotification([FromBody] Notification notification)
        {
            try
            {
                await _notificationDataService.UpdateNotification(notification);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
