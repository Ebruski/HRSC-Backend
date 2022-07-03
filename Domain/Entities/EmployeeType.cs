using Domain.Enums;

namespace Domain.Entities
{
    public class EmployeeType : BaseEntity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public PaymentType PaymentType { get; set; }
        public SalaryType SalaryType { get; set; }
        public bool HasTax { get; set; }
        public decimal Amount { get; set; }
    }
}
