using Entities.Base;
using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Employee : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public int? UserId { get; set; } // Sistemde hesabı olan çalışanlar için

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }  // TCKN
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
        public virtual ICollection<AdvanceRequest> AdvanceRequests { get; set; }
        public virtual ICollection<Payroll> Payrolls { get; set; }
        public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; }
        public virtual ICollection<EmployeeDocument> Documents { get; set; }
        public virtual ICollection<EmployeeShift> Shifts { get; set; }
        public virtual ICollection<AttendanceRecord> AttendanceRecords { get; set; }
    }
}
