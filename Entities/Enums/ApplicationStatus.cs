namespace Entities.Enums
{
    public enum ApplicationStatus
    {
        Pending = 0,         // Başvuru alındı, henüz değerlendirilmedi
        UnderReview = 1,     // Değerlendirme aşamasında
        Approved = 2,        // Kabul edildi
        Rejected = 3         // Reddedildi
    }
}
