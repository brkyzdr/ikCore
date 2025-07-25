using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Giriş yapan kullanıcıya ait bilgiler (sunucu tarafında set edilecek)
        public int UserId { get; set; }
        public string Role { get; set; }
        public int? CompanyId { get; set; }
    }
}
