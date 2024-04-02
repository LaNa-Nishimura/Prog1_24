using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Models
{
    public class OrderItem
    {
        public Product Product { get;set; }
        public double Quantity { get;set; }
        public double PurchasePrice { get;set; }
        public bool Validate() {
            return true;
        }

        public OrderItem Retrieve() {
            return new OrderItem(); // Encapsulado, retorna o próprio objeto
        }

        public void Save(OrderItem orderItem) {

        }
    }
}