using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class EmployeeDocument : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public int DocumentTypeId { get; set; }
        public string FilePath { get; set; }           // Belgelerin saklandığı yol
        public string Description { get; set; }        // Belgeye dair açıklama
        public DateTime UploadedAt { get; set; }
        public int UploadedByUserId { get; set; }      // Kim yüklediyse

        // Navigation properties
        public virtual Employee Employee { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual User UploadedByUser { get; set; }
    }
}
