using Entities.Base;
using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class User : BaseEntity, IEntity
    {
        public int? CompanyId { get; set; }       // Firma sahibi olmayan kullanıcılar için null olabilir
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }          // Örn: "Admin", "HRManager", "Manager", "Employee"
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } // Kullanıcı bir çalışanla eşleşebilir
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}
