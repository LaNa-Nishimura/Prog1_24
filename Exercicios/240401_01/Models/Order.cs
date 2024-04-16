using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Models
{
    public class Order
    {
        public int IdOrder { get;set;}
        public Customer Customer { get;set; }
        public DateTime OrderDate { get;set; }
        public string ShippingAddress { get;set; }
        public List<OrderItem> OrderItems { get;set; }
        public bool Validate() {
            return true;
        }

        public Order Retrieve() {
            return new Order(); // Encapsulado, retorna o próprio objeto
        }

        public void Save(Order order) {

        }
    }
}