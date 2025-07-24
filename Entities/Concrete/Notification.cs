using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class Notification : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public string Title { get; set; }             // Örn: "İzin Talebiniz Onaylandı"
        public string Message { get; set; }           // Açıklama
        public bool IsRead { get; set; }              // Okundu mu?
        public DateTime SentAt { get; set; }

        // Navigation property
        public virtual User User { get; set; }
    }
}
