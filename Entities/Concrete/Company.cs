using Entities.Base;
using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Company : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string Sector { get; set; }
        public string Address { get; set; }
        public string UniqueCode { get; set; }

        // Navigation properties
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<CompanyModule> CompanyModules { get; set; }
    }
}
