using Entities.Base;
using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class DocumentType : BaseEntity, IEntity
    {
        public string Name { get; set; }           // Örn: "Kimlik", "Sözleşme", "Diploma"
        public string Description { get; set; }    // Açıklama (isteğe bağlı)
        public int CompanyId { get; set; }    

        // Navigation property
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
    }
}
