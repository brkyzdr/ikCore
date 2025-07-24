using Entities.Base;
using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Shift : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }                // Örn: "Sabah Vardiyası", "Gece Vardiyası"
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; }
    }
}
