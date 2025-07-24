using Entities.Base;
using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class RecruitmentPost : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public string Title { get; set; }                // İlan başlığı
        public string Description { get; set; }          // Detaylı açıklama
        public DateTime PublishDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
