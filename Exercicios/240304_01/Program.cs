//Substituíndo conteúdo de strings
string nomeCompleto = "Lana Nishimura";
nomeCompleto = nomeCompleto.Replace("Nishimura", "Donfort");

Console.WriteLine(nomeCompleto);

//Comparação de strings
bool isNomeEqual = (nomeCompleto == "Lana Nishimura");

bool isNomeEqual2 = string.Equals(nomeCompleto, "Lana Donfort");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");