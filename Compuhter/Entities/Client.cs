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
        public string ClientSurName { get; set; }
        public string ClientFirstName { get; set; }        
        public string ClientTelephone { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public Client()
        {
            Checks = new List<Check>();
        }
    }
}
