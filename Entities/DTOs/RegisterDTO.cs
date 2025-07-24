using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı zorunludur.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Rol bilgisi zorunludur.")]
        public string Role { get; set; }  // İsteğe bağlı olarak enum da olabilir

        public int? CompanyId { get; set; } // Firma ID'si girilirse mevcut firmaya katılır, girilmezse yeni firma kurulur
    }
}
