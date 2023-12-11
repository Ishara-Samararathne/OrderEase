using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEase.model
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public double total { get; set; }
        public DateTime createdDatetime { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public User customer { get; set; }
    }
}
