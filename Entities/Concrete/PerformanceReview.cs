using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class PerformanceReview : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public DateTime ReviewPeriodStart { get; set; }
        public DateTime ReviewPeriodEnd { get; set; }

        public int Score { get; set; }                  // 0-100 arası bir puan
        public string ReviewerName { get; set; }        // Değerlendiren kişi (yönetici veya İK)
        public string Comments { get; set; }            // Geri bildirim

        public DateTime ReviewDate { get; set; }

        // Navigation property
        public virtual Employee Employee { get; set; }
    }
}
