using Entities.Base;
using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Department : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
