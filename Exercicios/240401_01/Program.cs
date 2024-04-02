// See https://aka.ms/new-console-template for more information
using _240401_01.Models;

Console.WriteLine("Hello, World!");

Customer c1 = new Customer(1);
c1.CustomerId = 1;
c1.Name = "Jake";
c1.EmailAddress = "Jake@sim.net";

// Construtor de instâncição
Customer c2 = new Customer(2);
c1.Name = "Lana";
c1.EmailAddress = "Lana@donfort.net";

// Construtor por atribuição
Customer c3 = new Customer {
    CustomerId = 3,
    Name = "Soobs",
    EmailAddress = "Soobs@choi.net"
};