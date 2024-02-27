using System;

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();

string sobrenome = string.Empty;
Console.WriteLine("Qual é o seu sobrenome?");
sobrenome = Console.ReadLine();

string email = string.Empty;
Console.WriteLine("Qual é o seu email?");
email = Console.ReadLine();

string datan = string.Empty;
Console.WriteLine("Qual é a sua data de mascimento?");
datan = Console.ReadLine();

string sexo = string.Empty;
Console.WriteLine("Qual é o seu sexo?");
sexo = Console.ReadLine();

string cep = string.Empty;
Console.WriteLine("Qual é o seu CEP?");
cep = Console.ReadLine();

string estp = string.Empty;
Console.WriteLine("Em que país e estado você mora?");
estp = Console.ReadLine();

string end = string.Empty;
Console.WriteLine("Qual é o seu endereço? (Rua, N°, Bairro)");
end = Console.ReadLine();

string listagem = $" Ficha de {nome} :D \n" +
                  $"Nome Completo: {nome} {sobrenome} \n" +
                  $"Endereço de E-mail: {email} \n" +
                  $"Data de Nascimento: {datan} \n" +
                  $"Sexo: {sexo} \n" +
                  $"CEP: {cep} \n" +
                  $"Endereço: {end}, {estp}";

Console.WriteLine(listagem);