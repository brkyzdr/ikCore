using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad soyad zorunludur.")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "TC kimlik numarası zorunludur.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC kimlik numarası 11 haneli olmalıdır.")]
        public string NationalId { get; set; }

        [Required(ErrorMessage = "Departman seçilmelidir.")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Pozisyon seçilmelidir.")]
        public int PositionId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Status { get; set; }  // Örn: "Aktif", "İşten Ayrıldı"

        public string Email { get; set; }   // Kullanıcıya bağlıysa bilgi amaçlı gösterilebilir
    }
}
