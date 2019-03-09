using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuhter.Entities
{
    public class ProductCheck
    {
        public int ProductCheckId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CheckId { get; set; }
        public Check Check { get; set; }
    }
}
