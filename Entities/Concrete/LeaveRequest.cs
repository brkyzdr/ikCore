using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class LeaveRequest : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public string LeaveType { get; set; }      // Örn: "Yıllık", "Mazeret", "Hastalık"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }         // Örn: "Bekliyor", "Onaylandı", "Reddedildi"
        public DateTime RequestDate { get; set; }

        public int? ApprovedByUserId { get; set; }
        public DateTime? ApprovedDate { get; set; }

        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual User ApprovedByUser { get; set; }
    }
}
