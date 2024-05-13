using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veddomowewbsite.Models
{
    public class Department
    {
        [Key]
        public int id {  get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

    }

    public class Employee
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public Department Department { get; set; }

    }
}
