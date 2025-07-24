using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class NotificationDTO
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur.")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Mesaj içeriği zorunludur.")]
        [MaxLength(1000)]
        public string Message { get; set; }

        public bool IsRead { get; set; }

        public DateTime SentAt { get; set; }
    }
}
