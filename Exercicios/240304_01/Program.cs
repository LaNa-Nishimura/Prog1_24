//Substituíndo conteúdo de strings
string nomeCompleto = "Lana Nishimura";
nomeCompleto = nomeCompleto.Replace("Nishimura", "Donfort");

Console.WriteLine(nomeCompleto);

//Comparação de strings
bool isNomeEqual = (nomeCompleto == "Lana Nishimura");

bool isNomeEqual2 = string.Equals(nomeCompleto, "Lana Donfort");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

//Tipos numéricos
/*
    sbyte: armazena valores entre -128 e 127
    short: armazena valores entre -32,768 e 32,767
    int: armazena valores entre -2,147,483,648 e 2,147,483,647
    long: armazena valores entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807
*/

float myFloat = 10f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;

myDouble = Convert.ToDouble(Console.ReadLine());
