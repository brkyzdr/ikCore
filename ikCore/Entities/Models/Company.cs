using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ikCore.Entities.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string TaxNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
