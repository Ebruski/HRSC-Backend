using System;
using HRSC.Core.Models;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string TIN { get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}
