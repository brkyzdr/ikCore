using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class PerformanceReviewDTO
    {
        public int Id { get; set; }  // Güncelleme işlemleri için

        [Required(ErrorMessage = "Çalışan seçimi zorunludur.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Başlangıç tarihi zorunludur.")]
        public DateTime ReviewPeriodStart { get; set; }

        [Required(ErrorMessage = "Bitiş tarihi zorunludur.")]
        public DateTime ReviewPeriodEnd { get; set; }

        [Required(ErrorMessage = "Puan girilmelidir.")]
        [Range(0, 100, ErrorMessage = "Puan 0-100 arasında olmalıdır.")]
        public int Score { get; set; }

        [MaxLength(100)]
        public string ReviewerName { get; set; }

        [MaxLength(1000)]
        public string Comments { get; set; }

        public DateTime? ReviewDate { get; set; }
    }
}
