using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class ProductRepository
    {
        public void Save(Product product) {
            DataSet.Products.Add(product);
        }

        public Product Retrieve(int id) {
            foreach (var p in DataSet.Products) {
                if (p.IdProduct == id) {
                    return p;
                }
            }
            return null;
        }

    }
}