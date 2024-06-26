using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get;set; }
        public string Name { get;set; }
        public string EmailAddress { get;set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

        public string PrintToExportDelimited() {
            return $"{CustomerId};{Name};{EmailAddress}";
        }

        public override string ToString() {
            return $"{CustomerId} - {this.Name} - {EmailAddress}";
        }

        /*
        public Customer() {
            
        }

        public Customer(int id) {
            CustomerId = id;
        }

        public bool Validate() {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            return isValid;
        }

        public Customer Retrieve(int customerId) {
            return new Customer(); // Encapsulado, retorna o próprio objeto
        }
        public List<Customer> Retrieve() {
            return new List<Customer>();
        }

        public void Save(Customer customer) {

        } */
    }
}