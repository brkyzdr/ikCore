using Entities.Enums;

namespace Entities.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public RoleType Role { get; set; }

        public int? CompanyId { get; set; }

        public bool IsActive { get; set; }

        public string CompanyName { get; set; } // Include edilmişse gösterilebilir
    }
}
