using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class JobApplication : BaseEntity, IEntity
    {
        public int RecruitmentPostId { get; set; }
        public int CompanyId { get; set; }

        public string ApplicantName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string CVFilePath { get; set; }           // Yüklenen özgeçmiş dosyası
        public string CoverLetter { get; set; }          // Açıklama/ön yazı (isteğe bağlı)
        public string Status { get; set; }               // Örn: "Yeni", "Değerlendiriliyor", "Reddedildi", "Kabul Edildi"

        public DateTime AppliedAt { get; set; }
        public string Notes { get; set; }                // İK tarafından eklenen yorumlar

        // Navigation property
        public virtual RecruitmentPost RecruitmentPost { get; set; }
    }
}
