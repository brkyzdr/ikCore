using System;
using System.ComponentModel.DataAnnotations;
using Entities.Enums;

namespace Entities.DTOs
{
    public class LeaveRequestDTO
    {
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public LeaveType LeaveType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(500)]
        public string Reason { get; set; }
    }
}
