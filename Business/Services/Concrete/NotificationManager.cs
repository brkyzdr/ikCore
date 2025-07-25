using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Send(Notification notification)
        {
            notification.IsRead = false;
            notification.CreatedAt = DateTime.UtcNow;
            _notificationDal.Add(notification);
        }

        public void MarkAsRead(int notificationId)
        {
            var notification = _notificationDal.Get(x => x.Id == notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
                _notificationDal.Update(notification);
            }
        }

        public void Delete(int id)
        {
            var notification = _notificationDal.Get(x => x.Id == id);
            if (notification != null)
                _notificationDal.Delete(notification);
        }

        public Notification GetById(int id)
        {
            return _notificationDal.Get(x => x.Id == id);
        }

        public List<Notification> GetAll()
        {
            return _notificationDal.GetAll().ToList();
        }

        public List<Notification> GetByUserId(int userId)
        {
            return _notificationDal.GetAll(x => x.UserId == userId).ToList();
        }

        public List<Notification> GetUnreadByUserId(int userId)
        {
            return _notificationDal.GetAll(x => x.UserId == userId && !x.IsRead).ToList();
        }
    }
}
