using _240401_01.Models;
using _240401_01.Views;
bool aux = true;
do {
    Console.WriteLine("*******************");
    Console.WriteLine("Programa de Pedidos");
    Console.WriteLine("*******************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    try {
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu) {
            case 1:
                CustomerView customerView = new CustomerView();
            break;
            case 2:
                ProductView productView = new ProductView();
            break;
            case 3:
                OrderView orderView = new OrderView();
            break;
            case 0:
                aux = false;
                Console.WriteLine("Obrigado e volte sempre!");
            break;
            default:
                Console.WriteLine("Opção inválida.");
            break;
        }
    }

    catch {
        Console.WriteLine("Opção Inválida.");
        menu = -1;
        aux = true;
    }
}

while(aux);

/*

// See https://aka.ms/new-console-template for more information
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

*/