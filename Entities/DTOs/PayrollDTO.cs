using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class PayrollDTO
    {
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime PeriodStart { get; set; }

        [Required]
        public DateTime PeriodEnd { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Brüt maaş negatif olamaz.")]
        public decimal GrossSalary { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Net maaş negatif olamaz.")]
        public decimal NetSalary { get; set; }

        [Range(0, double.MaxValue)]
        public decimal TaxAmount { get; set; }

        [Range(0, double.MaxValue)]
        public decimal SocialSecurityCut { get; set; }

        [Range(0, double.MaxValue)]
        public decimal OtherDeductions { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }
    }
}
