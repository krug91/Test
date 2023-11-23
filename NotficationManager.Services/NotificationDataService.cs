using Microsoft.EntityFrameworkCore;
using NotificationManager.EF;
using NotificationManager.EF.Models;
using NotificationManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotficationManager.Services
{
    public class NotificationDataService : INotificationDataService
    {
        private readonly ApplicationDbContext _dbContext;

        public NotificationDataService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddNotification(Notification notification)
        {
            _dbContext.Notifications.Add(notification);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Notification> GetNotification(string id)
        {
            var notification = await _dbContext.Notifications.AsNoTracking().Where(x => x.ID.ToString() == id).FirstOrDefaultAsync();

            return notification;
        }

        public async Task RemoveNotification(string id)
        {
            var notification = _dbContext.Notifications.Where(x => x.ID.ToString() == id).FirstOrDefault();
            _dbContext.Notifications.Remove(notification);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveNotifications(List<string> notificationIDS)
        {
            var notificationsList = _dbContext.Notifications.Where(x => notificationIDS.Contains(x.ID.ToString())).ToList();
            _dbContext.Notifications.RemoveRange(notificationsList);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateNotification(Notification notification)
        {
            _dbContext.Entry(notification).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
