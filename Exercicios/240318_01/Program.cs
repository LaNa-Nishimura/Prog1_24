using System;
using _240318_01.Models;

// Instãncia de objeto do tipo Customer
Customer c1 = new Customer();

// Atribuíndo valores aos atributos do objeto c1
c1.CustomerId = 1;
c1.FirstName = "Lana";
c1.LastName = "Nishimura";
c1.BirthDate = new DateTime();
c1.EmailAddress = "lana@lana.lana";

// Instância de objeto do tipo Address
Address address1 = new Address();
// Atribuíndo valor aos atributos do objeto address1
address1.AddressId = 1;
address1.Street = "Severino José Pasqual";
address1.District = "Universitário";
address1.City = "Videira";
address1.Number = 598;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89566-838";
// AddressType é do tipo enum, portanto espera receber um valor equivalente ao seu tipo
address1.AddressType = AddressType.Residential;

// Guardando um endereço a lista de endereços do consumidor
c1.Addresses.Add(address1);

Console.WriteLine("Endereços: ");
// Imprimindo as informações
foreach(var ad in c1.Addresses) {
    Console.WriteLine("---------------------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Country}");
    Console.WriteLine($"CEP: {ad.ZipCode}");
}

Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine($"Email: {c1.EmailAddress}");