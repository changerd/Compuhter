using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuhter.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public Client()
        {
            Checks = new List<Check>();
        }
    }
}
