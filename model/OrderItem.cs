using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase.model
{
    public class OrderItem
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public Product Product { get; set; }
    }
}
