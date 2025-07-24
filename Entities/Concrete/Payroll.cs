using Entities.Base;
using Entities.Interfaces;
using System;

namespace Entities.Concrete
{
    public class Payroll : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }

        public decimal GrossSalary { get; set; }
        public decimal NetSalary { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal SocialSecurityCut { get; set; }
        public decimal OtherDeductions { get; set; }
        public string Notes { get; set; }

        public DateTime GeneratedAt { get; set; }

        // Navigation property
        public virtual Employee Employee { get; set; }
    }
}
