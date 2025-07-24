using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class EmployeeShift : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public int ShiftId { get; set; }
        public DateTime WorkDate { get; set; }   // Vardiyanın ait olduğu gün
        public string Notes { get; set; }        // İsteğe bağlı açıklama

        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
