using Entities.Base;
using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Position : BaseEntity, IEntity
    {
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public string Title { get; set; }              // Örn: "Yazılım Geliştirici", "İK Uzmanı"
        public string Description { get; set; }        // Pozisyon açıklaması (isteğe bağlı)

        // Navigation properties
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
