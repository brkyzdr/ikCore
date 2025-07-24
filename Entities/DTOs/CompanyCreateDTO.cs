using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class CompanyCreateDTO
    {
        [Required(ErrorMessage = "Firma adı zorunludur.")]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Sector { get; set; }  // Örn: Yazılım, İnşaat, Sağlık

        [MaxLength(200)]
        public string Address { get; set; }

        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }
    }
}
