using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class AttendanceRecord : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public DateTime WorkDate { get; set; }
        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public string Source { get; set; } // "Manuel", "Cihaz", "Mobil" vb.

        // Navigation property
        public virtual Employee Employee { get; set; }
    }
}
