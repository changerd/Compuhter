using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuhter.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductManufacturer { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }
        public virtual ICollection<ProductCheck> ProductChecks { get; set; }
        public Product()
        {
            ProductChecks = new List<ProductCheck>();
        }
    }
}
