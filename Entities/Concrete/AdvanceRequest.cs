using Entities.Base;
using Entities.Interfaces;
using System;


namespace Entities.Concrete
{
    public class AdvanceRequest : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } // TRY, USD, vs.
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ApprovedByUserId { get; set; }

        // Navigation property
        public virtual Employee Employee { get; set; }
    }
}
