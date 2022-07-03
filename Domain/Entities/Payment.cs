using System;

namespace Domain.Entities
{
    public class Payment : BaseEntity
    {
        public string Month { get; set; }
        public decimal SalaryPaid { get; set; }
        public decimal Tax { get; set; }
        public double Days { get; set; }
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
