using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Models
{
    public class Product
    {
        public int IdProduct { get;set;}
        public string ProductName { get;set; }
        public string Description { get;set; }
        public float CurrentPrice { get;set; }
        public bool Validate() {
            return true;
        }

        public Product Retrieve() {
            return new Product(); // Encapsulado, retorna o próprio objeto
        }

        public void Save(Product product) {

        }
    }
}