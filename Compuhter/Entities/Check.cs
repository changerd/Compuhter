using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuhter.Entities
{
    public class Check
    {
        public int CheckId { get; set; }
        public decimal Amount { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public virtual ICollection<ProductCheck> ProductChecks { get; set; }
        public Check()
        {
            ProductChecks = new List<ProductCheck>();
        }
    }
}
