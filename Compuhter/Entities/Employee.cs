using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuhter.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeSurName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSecondName { get; set; }
        public string EmployeeTelephone { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public Employee()
        {
            Checks = new List<Check>();
        }
    }
}
