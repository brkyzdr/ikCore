using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class AuditLog : BaseEntity, IEntity
    {
        public int? UserId { get; set; }
        public int CompanyId { get; set; }
        public string ActionType { get; set; }       // Örn: "Create", "Update", "Delete", "Login"
        public string EntityName { get; set; }       // Örn: "Employee", "LeaveRequest"
        public int? EntityId { get; set; }           // Hangi kayıtta işlem yapıldığı
        public string Description { get; set; }      // Detaylı açıklama (isteğe bağlı)
        public string IpAddress { get; set; }        // İsteği yapan IP (isteğe bağlı)
        public string BrowserInfo { get; set; }      // Tarayıcı bilgisi (isteğe bağlı)
        public DateTime Timestamp { get; set; }

        // Navigation
        public virtual User User { get; set; }
    }
}
