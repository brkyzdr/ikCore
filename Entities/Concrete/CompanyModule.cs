using Entities.Base;
using Entities.Interfaces;

namespace Entities.Concrete
{
    public class CompanyModule : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public int ModuleId { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual Module Module { get; set; }
    }
}
