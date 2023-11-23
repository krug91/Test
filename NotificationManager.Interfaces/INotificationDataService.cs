using NotificationManager.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManager.Interfaces
{
    public interface INotificationDataService
    {
        Task<Notification> GetNotification(string id);
        Task UpdateNotification(Notification notification);
        Task AddNotification(Notification notification);
        Task RemoveNotification(string id);
        Task RemoveNotifications(List<string> notificationIDS);
    }
}
