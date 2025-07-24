using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class JobApplicationDTO
    {
        [Required]
        public int RecruitmentPostId { get; set; }

        [Required(ErrorMessage = "Ad-soyad zorunludur.")]
        [MaxLength(100)]
        public string ApplicantName { get; set; }

        [Required(ErrorMessage = "E-posta zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string Phone { get; set; }

        public string CoverLetter { get; set; }

        [Required(ErrorMessage = "CV dosya yolu zorunludur.")]
        public string CVFilePath { get; set; }
    }
}
