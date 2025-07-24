using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface INotificationService
    {
        void Send(Notification notification);
        void MarkAsRead(int notificationId);
        void Delete(int id);

        Notification GetById(int id);
        List<Notification> GetAll();
        List<Notification> GetByUserId(int userId);
        List<Notification> GetUnreadByUserId(int userId);
    }
}
