using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ikCore.Entities.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, EmailAddress, StringLength(150)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public bool IsEmailConfirmed { get; set; }
    }
}
