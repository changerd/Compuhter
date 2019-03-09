using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuhter.Entities
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Position()
        {
            Employees = new List<Employee>();
        }
    }
}
