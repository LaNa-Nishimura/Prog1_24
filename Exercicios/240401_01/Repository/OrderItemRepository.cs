using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class OrderItemRepository
    {
        public void Save(OrderItem orderItem) {
            DataSet.OrderItems.Add(orderItem);
        }

        public OrderItem Retrieve(int id) {
            foreach (var i in DataSet.OrderItems) {
                if (i.IdOrderItem == id) {
                    return i;
                }
            }
            return null;
        }
    }
}