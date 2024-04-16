using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class OrderRepository
    {
        public void Save(Order order) {
            DataSet.Orders.Add(order);
        }

        public Order Retrieve(int id) {
            foreach (var o in DataSet.Orders) {
                if (o.IdOrder == id) {
                    return o;
                }
            }
            return null;
        }
    }
}