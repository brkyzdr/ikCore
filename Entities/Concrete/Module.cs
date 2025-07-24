using Entities.Base;
using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Module : BaseEntity, IEntity
    {
        public string Name { get; set; }             // Örn: "İzin Yönetimi"
        public string Code { get; set; }             // Örn: "LEAVE_MODULE"
        public string Description { get; set; }

        // Navigation properties
        public virtual ICollection<CompanyModule> CompanyModules { get; set; }
    }
}
